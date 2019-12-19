using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace KursovaPSD
{
    public partial class AllReservationsData : Form
    {
        private const string RESERVATIONS_FILE = "reservations.dat";
        private bool additionalRights = false;
        private bool dataEdit;
        private BinaryFormatter bf = new BinaryFormatter();
        private FileStream fs;
        private List<Reservation> searchList = new List<Reservation>(); 
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        
        public AllReservationsData(List<Reservation> resList, string rights)
        {
            
            InitializeComponent();
            searchList = resList;
            allReservations_DataGridView.DataSource = resList;
       
            dataEdit = false;
            
            //Потребители с по-висок ранг/ниво на достъп
            //могат да видят допълнителни данни за гостите(dataGridView1_CellContentClick()).
            if (rights == "Собственик" || rights == "Администратор")
            {
                additionalRights = true;
                deleteReservations_Button.Enabled = true;
                allReservations_DataGridView.ReadOnly = false;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0 && additionalRights)
            {
                Reservation item = new Reservation();
                foreach (Reservation x in searchList)
                {
                    if (x.GuestName == allReservations_DataGridView.CurrentCell.Value.ToString())
                        item = x;
                }
                Additional_Info m = new Additional_Info(item);
                m.Show();
            }
        }       
        private bool FindID(Reservation idItem)
        {
            if (idItem.ReservationNumber == allReservations_DataGridView.CurrentCell.Value.ToString())
                return true;
            else return false;
        }
        private void deleteReservations_Button_Click(object sender, EventArgs e)
        {
            //Изтрива избраната резервация(сравнява се чрез функцията FindID), презаписва файла за резервациите
            //и презарежда таблицата(allReservations_DataGridView).
            fs = new FileStream(RESERVATIONS_FILE, FileMode.Create);

            if (additionalRights && MessageBox.Show("Наистина ли искате да изтриете тези данни?", "Изтриване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<Reservation> delete = searchList.FindAll(FindID);
                if (delete.Count > 0)
                {
                    foreach (Reservation cnt in delete)
                    {
                        searchList.Remove(cnt);
                    }
                    CurrencyManager cm = (CurrencyManager)this.BindingContext[searchList];
                    cm.Refresh();
                }
            }
            bf.Serialize(fs, searchList);
            fs.Close();
            dataEdit = true;
            allReservations_DataGridView.DataSource = searchList;
        }
        
        private void allDataClose_Button_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(RESERVATIONS_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, searchList);
            fs.Close();
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = dataEdit;
            onFormClosed(x);
            Close();
        }

        private void allReservations_DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Сортиране според това, върху коя колона е кликнато с мишката
            if (e.ColumnIndex == 0) //Колона 0 - № на резервацията
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {

                        if (int.Parse(searchList[i].ReservationNumber) > int.Parse(searchList[j].ReservationNumber))
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 1) //  Колона 1 - Име на госта
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        int x = String.Compare(searchList[i].GuestName, searchList[j].GuestName);
                        if (x==1)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 3) // Колона 3 - Държави
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        int x = String.Compare(searchList[i].Country, searchList[j].Country);
                        if (x == 1)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 4) //Колона 4 - № на стая
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {

                        if (searchList[i].RoomNumber > searchList[j].RoomNumber)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 5) // Колона 5 - Брой гости
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        if (searchList[i].GuestsCount > searchList[j].GuestsCount)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 6) // Колона 6 - Дата на пристигане
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        int x = DateTime.Compare(searchList[i].DateFrom.Date, searchList[j].DateFrom.Date);
                        if (x == 1)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 7) // Колона 7 - Дата на заминаване
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        int x = DateTime.Compare(searchList[i].DateUntil.Date, searchList[j].DateUntil.Date);
                        if (x == 1)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            else if (e.ColumnIndex == 10) // Колона 10 - Дължими суми
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    for (int j = i + 1; j < searchList.Count; j++)
                    {
                        if (searchList[i].Sum > searchList[j].Sum)
                        {
                            Reservation tempItem = searchList[j];
                            searchList[j] = searchList[i];
                            searchList[i] = tempItem;
                        }

                    }
                }
            }
            allReservations_DataGridView.Refresh();
        }
    }
}