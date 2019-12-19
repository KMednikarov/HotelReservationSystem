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
    public partial class SearchByName : Form
    {
        private List<Reservation> resList = new List<Reservation>();
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }
        public SearchByName(List<Reservation> x)
        {
            InitializeComponent();
            resList = x;
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            onFormClosed(x);
            Close();
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            List<Reservation> searchList = new List<Reservation>();
            searchDGV.Visible = false;
            foreach (Reservation check in resList)
            {
                if (check.GuestName.ToLower().Contains(searchName_TB.Text.ToLower()))
                {
                    searchList.Add(check);
                }

            }
            searchDGV.DataSource = searchList;
            searchDGV.Visible = true;

            if (searchList.Count == 0) MessageBox.Show("Търсенето е неуспешно.");
        }
    }
}