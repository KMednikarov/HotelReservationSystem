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
    public partial class RoomPrices : Form
    {
        private List<string> prices = new List<string>();
        private bool dataEdit = false;
        private const string ROOMS_PRICES_FILE = "prices.dat";
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        private void Load_Prices_File()
        {
            FileStream fs = new FileStream(ROOMS_PRICES_FILE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BinaryFormatter bw = new BinaryFormatter();
            prices = (List<string>)bw.Deserialize(fs);
            fs.Close();
            appPrice_TB.Text = prices[0];   //За Апартамент
            dblPrice_TB.Text = prices[1];   //За Двойна стая
            dbl2Price_TB.Text = prices[2];  //За Двойна разширена
            sglPrice_TB.Text = prices[3];   //За Единична
            pthPrice_TB.Text = prices[4];   //За Мезонет
            prices.Clear();
        }

        public RoomPrices(string a)
        {
            InitializeComponent();
            Load_Prices_File();

            if (a == "Собственик" || a == "Администратор")
            {
                appPrice_TB.ReadOnly = false;
                dblPrice_TB.ReadOnly = false;
                dbl2Price_TB.ReadOnly = false;
                sglPrice_TB.ReadOnly = false;
                pthPrice_TB.ReadOnly = false;
            }
        }
        private void saveFile()
        {
            FileStream fs = new FileStream(ROOMS_PRICES_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bw = new BinaryFormatter();
            prices.Add(appPrice_TB.Text);
            prices.Add(dblPrice_TB.Text);
            prices.Add(dbl2Price_TB.Text);
            prices.Add(sglPrice_TB.Text);
            prices.Add(pthPrice_TB.Text);
            bw.Serialize(fs, prices);
            fs.Close();

        }
        private void ok_Button_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c.Text.Trim().Length == 0 || c.Text == "0")
                {
                    MessageBox.Show("Моля попълнете коректно всички полета.");
                    return;
                }
            }
            saveFile();
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = dataEdit;
            onFormClosed(x);
            Close();

        }

    }
}
