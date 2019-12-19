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
            
    
    public partial class NewReservations : Form
    {
        private const string RESERVATIONS_FILE = "reservations.dat";
        private const string ROOM_PRICES_FILE = "prices.dat";
        private int reservation_Number = 0;
        private List<Reservation> myReservations = new List<Reservation>();
        private bool dataEdit;
        private List<string> roomPrices = new List<string>(5);

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }
   
        private void Load_Prices_File()
        {
            if (File.Exists(ROOM_PRICES_FILE))
            {
                FileStream fs = new FileStream(ROOM_PRICES_FILE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                roomPrices = (List<string>)bf.Deserialize(fs);
                fs.Close();
            }
            
        }
        public NewReservations(List<Reservation> a)
        {
            InitializeComponent();
            Load_Prices_File();
            myReservations = a;
            dataEdit = false;
            reservation_Number = int.Parse(a[a.Count-1].ReservationNumber) + 1;
            reservation_TB.Text = reservation_Number.ToString();
        }

      
        private void save_Reservations_File()
        {
            if (MessageBox.Show("Наистина ли искате да създадете резервацията?", "Създаване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FileStream fs = new FileStream(RESERVATIONS_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, myReservations);
                fs.Close();
                MessageBox.Show("Резервацията беше добавена успешно.");
            }
        }
        private void clearFields()
        {           
            reservation_TB.Text = reservation_Number.ToString();
            firstName_TB.Clear();
            familyName_TB.Clear();
            egn_TB.Clear();
            roomNumber_TB.Clear();
            guestsCount_TB.Clear();
            address_TB.Clear();            
        }

        private bool check_Fields()
        {
            bool filled_Fields1 = false;
            bool filled_Fields2 = false;
            foreach (Control c in guestInformation_GroupBox.Controls)
            {
                if (c.Text == "")
                {
                    filled_Fields1 = false;
                    break;
                }
                else filled_Fields1 = true;
            }
            foreach (Control c in resInformation_GroupBox.Controls)
            {
                if (c.Text == "")
                {
                    filled_Fields2 = false;
                    break;
                }
                else filled_Fields2 = true;
            } 
           
            if (filled_Fields1 && filled_Fields2)
            {
                bool existingReservation = false;
                for (int i = 0; i < myReservations.Count; i++)
                {
                    if (myReservations[i].ReservationNumber == reservation_TB.Text.ToString())
                    {
                        MessageBox.Show("Резервацията вече съществува.");
                        existingReservation = true;
                        break;
                    }
                    else if (myReservations[i].RoomNumber.ToString() == roomNumber_TB.Text)
                    {
                        MessageBox.Show("Стаята е заета.");
                        existingReservation = true;
                        break;
                    }
                    else if (egn_TB.TextLength != 10)
                    {
                        MessageBox.Show("Невалидно ЕГН.");
                        existingReservation = true;
                        break;
                    }
                    else if (int.Parse(roomNumber_TB.Text) < 1 || int.Parse(roomNumber_TB.Text) > 70)
                    {
                        MessageBox.Show("Няма такава стая.");
                        existingReservation = true;
                        break;
                    }
                }
                if (!existingReservation) return true;
                else return false;
            }
            else
            {
                MessageBox.Show("Моля попълнете всички полета.");
                return false;
            }
            
        }
        private void addReservation_Button_Click(object sender, EventArgs e)
        {
            /* Проверява се дали са попълнени коректно всички полета.
             * Извежда грешка при празни полета, съществуващи или грешни данни.
             * Ако всичко е наред - програмата добавя новата резервация в масива myReservations
             * и го записва(save_Reservations_File()) във файла reservations.dat. 
             * След това се изчистват всички полета(clearFields())                    
             * и потребителя може да въвежда нови данни.             
             */
           
            if (check_Fields())
            {
                
                    string guestName = firstName_TB.Text + " " + familyName_TB.Text;
                    int price = 1;
                    int n = int.Parse(roomNumber_TB.Text);
                    if (n >= 1 && n <= 15) price= int.Parse(roomPrices[0]);       //За Апартамент
                    else if (n >= 16 && n <= 25) price= int.Parse(roomPrices[1]); //За Двойна стая
                    else if (n >= 26 && n <= 35) price= int.Parse(roomPrices[2]); //За Двойна разширена
                    else if (n >= 36 && n <= 50) price= int.Parse(roomPrices[3]); //За Единична
                    else if (n >= 51 && n <= 60) price= int.Parse(roomPrices[4]); //За Мезонет
                    myReservations.Add(new Reservation()
                    {
                        ReservationNumber = reservation_TB.Text.ToString(),
                        GuestName = guestName,
                        Egn = egn_TB.Text.ToString(),
                        Country = country_ComboBox.SelectedItem.ToString(),
                        RoomNumber = int.Parse(roomNumber_TB.Text),
                        GuestsCount = int.Parse(guestsCount_TB.Text),
                        DateFrom = dateTimePicker1.Value.Date,
                        DateUntil = dateTimePicker2.Value.Date,
                        Address = "гр. " + city_TextBox.Text + ", " + address_TB.Text.ToString(),
                        Sex = sex_ComboBox.SelectedItem.ToString(),
                        Sum = int.Parse(guestsCount_TB.Text) * price * Convert.ToInt32((dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).TotalDays)
                    });
                    dataEdit = true;
                    save_Reservations_File();
                    reservation_Number++;
                    clearFields();
                
            }
        }
        
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            /* Ако са добавяни нови данни - програмата отчита,
             * че са правени промени чрез променливата dataEdit
             * и след това предава резултата на Main формата, за да може да се прерисува reservations_Table.
             */
            
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = dataEdit;
            onFormClosed(x);
            Close();
        }
        
    }
}