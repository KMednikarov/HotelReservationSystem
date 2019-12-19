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
    public partial class AddUser : Form
    {
        private const string USERS_FILE = "users.dat";
        private BinaryFormatter bf = new BinaryFormatter();
        private FileStream fs;
        private List<User> newUser = new List<User>();

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }


        public AddUser()
        {
            InitializeComponent();
            if (File.Exists(USERS_FILE))
            {
                fs = new FileStream(USERS_FILE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                newUser = (List<User>)bf.Deserialize(fs);               
                fs.Close();
            }
        }


        private void addNewUser_Button_Click(object sender, EventArgs e)
        {
            /* Проверява се дали въведените данни не се съдържат
             * в масива newUser, който взима информацията от файла users.dat.
             */
            bool wrongUser = false;
            for (int i = 0; i < newUser.Count; i++)
            {
                if (newUser[i].UserName == userName_TB.Text)
                {
                    MessageBox.Show("Потребителското име е заето.");
                    wrongUser = true;
                    break;
                }
            }
            //При съществуващ потребител формата се отваря наново.
            if (wrongUser)
            {
                userName_TB.Clear();
                newPassword_TB.Clear();
                accessToken_ComboBox.Text = "";
            }
            else if (!wrongUser)
            {
                newUser.Add(new User()
                {
                    UserName = userName_TB.Text,
                    Password = newPassword_TB.Text,
                    AccessToken = accessToken_ComboBox.SelectedItem.ToString()
                });
               
                FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);                
                bf.Serialize(fs, newUser);               
                fs.Close();

                CloseFormEvent s = new CloseFormEvent();
                s.CloseForm = true;
                s.EditedData = true;
                onFormClosed(s);
                Close();                
            }            
        }
        private void addUserCancel_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;
            onFormClosed(x);
            Close();            
        }
    }
}