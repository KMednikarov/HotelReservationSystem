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
    public partial class AboutProgram : Form
    {
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }
        public AboutProgram()
        {
            InitializeComponent();
        }


        private void cancel_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            onFormClosed(x);
            Close();
        }   
    }
}