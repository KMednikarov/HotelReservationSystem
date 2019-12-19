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
    public partial class Additional_Info : Form
    {
        Reservation additional = new Reservation();      
        public Additional_Info(Reservation x)
        {
            InitializeComponent();
            additional = x;
            addIfno();
        }

        private void addIfno()
        {
            guestNameLabel1.Text = additional.GuestName;
            countryLabel1.Text = additional.Country;
            addressLabel1.Text = additional.Address;
            egnLabel1.Text = additional.Egn;
            sexLabel1.Text = additional.Sex;
        }
        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}