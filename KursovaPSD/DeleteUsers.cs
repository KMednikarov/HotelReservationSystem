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
    public partial class DeleteUsers : Form
    {
        private const string RESERVATIONS_FILE = "users.dat";
        private bool dataEdit = false;
        private List<User> users = new List<User>();
        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        public DeleteUsers(List<User> a)
        {
            InitializeComponent();
            users = a;
            users_DGV.DataSource = a;
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            x.EditedData = dataEdit;
            onFormClosed(x);
            Close();
        }
         private bool FindID(User idItem)
        {
            if (idItem.UserName == users_DGV.CurrentCell.Value.ToString())
            {
                if (idItem.AccessToken != "Собственик")
                {

                    return true;
                }
                else
                {
                    MessageBox.Show("Не можете да изтриете потребител от ранг \"Собственик\"");
                    return false;
                }
            }
            else return false;
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(RESERVATIONS_FILE, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            if (MessageBox.Show("Наистина ли искате да изтриете тези данни?", "Изтриване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                List<User> delete = users.FindAll(FindID);
                if (delete.Count > 0)
                {
                    foreach (User cnt in delete)
                    {
                        users.Remove(cnt);
                    }
                    CurrencyManager cm = (CurrencyManager)this.BindingContext[users];
                    cm.Refresh();
                }
            }
            bf.Serialize(fs, users);
            fs.Close();
            dataEdit = true;
            users_DGV.DataSource = users;
        }
    }
}
