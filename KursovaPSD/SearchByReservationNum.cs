using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaPSD
{
    public partial class SearchByReservationNum : Form
    {
        private List<Reservation> resList = new List<Reservation>();
        public SearchByReservationNum(List<Reservation> x)
        {
            InitializeComponent();
            resList = x;
        }
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }
        private void search_Button_Click(object sender, EventArgs e)
        {
            List<Reservation> searchList = new List<Reservation>();
            searchDGV.Visible = false;
            foreach (Reservation check in resList)
            {
                if (check.ReservationNumber.ToLower().Contains(search_TB.Text.ToLower()))
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
            onFormClosed(x);
            Close();
        }

        
    }
}
