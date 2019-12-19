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
    public partial class Edit : Form
    {
        private const string RESERVATIONS_FILE = "reservations.dat";
        private List<Reservation> editReservations;
        private Reservation item;
        private bool dataEdit = false;

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }
        
        private void fillFields()
        {
            int x = item.GuestName.IndexOf(' ');
            firstName_TB.Text = item.GuestName.Substring(0, x).ToString();
            familyName_TB.Text = item.GuestName.Substring(x+1).ToString();
            egn_TB.Text = item.Egn.ToString();
            country_ComboBox.SelectedItem = item.Country.ToString();
            x = item.Address.IndexOf(' ');
            int i = item.Address.IndexOf(',') - x-1;
            city_TextBox.Text = item.Address.Substring(x+1, i).ToString();
            address_TB.Text = item.Address.Substring(i+6).ToString();
            sex_ComboBox.SelectedItem = item.Sex.ToString();
            dateTimePicker1.Value = item.DateFrom;
            dateTimePicker2.Value = item.DateUntil;
            reservation_TB.Text = item.ReservationNumber.ToString();
            roomNumber_TB.Text = item.RoomNumber.ToString();
            guestsCount_TB.Text = item.GuestsCount.ToString();
        }
        public Edit(List<Reservation> editReservations, Reservation item)
        {
            InitializeComponent();
            this.editReservations = editReservations;
            this.item = item;
            fillFields();
        }


        
       
        private void save_Reservations_File()
        {
            if (MessageBox.Show("Наистина ли искате да редактирате резервацията?", "Редактиране", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FileStream fs = new FileStream(RESERVATIONS_FILE, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, editReservations);
                fs.Close();
                MessageBox.Show("Резервацията беше редактирана успешно.");
            }
        }
          
        private void edit_Button_Click(object sender, EventArgs e)
        {
            bool filled_Fields1 = false;
            bool filled_Fields2 = false;
            foreach (Control c in guestInformation_GroupBox.Controls)
            {
                if (c.Text == "")
                {
                    MessageBox.Show("Моля попълнете всички полета.");
                    return;
                }
                else filled_Fields1 = true;
            }
            foreach (Control c in resInformation_GroupBox.Controls)
            {
                if (c.Text == "")
                {
                    MessageBox.Show("Моля попълнете всички полета.");
                    return;
                }
                else filled_Fields2 = true;
            }
            if (filled_Fields1 && filled_Fields2)
            {
                string guestName = firstName_TB.Text + " " + familyName_TB.Text;
           
                    editReservations.Add(new Reservation()
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
                        Sex = sex_ComboBox.SelectedItem.ToString()
                    });
                    editReservations.Remove(item);
                    dataEdit = true;
                    save_Reservations_File();
                
            }

        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = dataEdit;
            onFormClosed(x);
            Close();
        }
    }
}
