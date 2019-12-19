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
    public partial class ResDataByDates : Form
    {
        private List<Reservation> searchList = new List<Reservation>();

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        public ResDataByDates(List<Reservation> resList)
        {
            InitializeComponent();
            searchList = resList;
        }

        private void showReservations_Button_Click(object sender, EventArgs e)
        {
            DateTime date_From = from_DateTimePicker.Value.Date;
            DateTime date_Until = until_DateTimePicker.Value.Date;
            //Проверява се чрез DateTime.Compare(), дали
            //датите на резервациите са в периода въведен от потребителя
            //и ако това е така се извеждат на екрана(reservationBindingSource.Add()).
            reservationBindingSource.Clear();
            foreach (var item in reservationBindingSource)
            {
                reservationBindingSource.Remove(item);
            }
            foreach (Reservation item in searchList)
            {
                int x = DateTime.Compare(date_From, item.DateFrom.Date);
                if (x == 0 || x == -1)
                {
                    int y = DateTime.Compare(date_Until, item.DateUntil.Date);
                    if (y == 0 || y == 1)
                        reservationBindingSource.Add(item);
                }
            }
        }
        private void clearData_Button_Click(object sender, EventArgs e)
        {
            reservationBindingSource.Clear();
            foreach (var item in reservationBindingSource)
            {
                reservationBindingSource.Remove(item);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            onFormClosed(x);
            Close();
        }
    }
}