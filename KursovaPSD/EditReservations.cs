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
    public partial class EditReservations : Form
    {
        private List<Reservation> editReservations = new List<Reservation>();
        private const string RESERVATIONS_FILE = "reservations.dat";
        public EditReservations(List<Reservation> x) 
        {
            InitializeComponent();
            editReservations = x;
        }

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        private void save_Reservations_File()
        {
            if (MessageBox.Show("Наистина ли искате да създадете резервацията?", "Създаване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FileStream fs = new FileStream(RESERVATIONS_FILE, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, editReservations);
                fs.Close();
                MessageBox.Show("Резервацията беше добавена успешно.");
            }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            List<Reservation> searchList = new List<Reservation>();
            searchDGV.Visible = false;
            foreach (Reservation check in editReservations)
            {
                if (check.GuestName.ToLower().Contains(searchName_TB.Text.ToLower())
                    || check.ReservationNumber.Contains(reservation_TB.Text))
                {
                    searchList.Add(check);
                }

            }
            searchDGV.DataSource = searchList;
            searchDGV.Visible = true;

            if (searchList.Count == 0) MessageBox.Show("Търсенето е неуспешно.");
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = true;
            onFormClosed(x);
            Close();
        }

        private void searchDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 && e.RowIndex >= 0)
                || (e.ColumnIndex == 0 && e.RowIndex >=0))
            {
                Reservation item = new Reservation();
                foreach (Reservation x in editReservations)
                {
                    if (x.GuestName == searchDGV.CurrentCell.Value.ToString())
                        item = x;
                    else if (x.ReservationNumber == searchDGV.CurrentCell.Value.ToString())
                        item = x;
                }
                Edit m = new Edit(editReservations, item);
                m.Show();
            }
        }

       
        
    }
}
