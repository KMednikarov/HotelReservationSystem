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
    public partial class Login : Form
    {
        private List<User> userInfo = new List<User>();
        
        public Login(List<User> x)
        {
            InitializeComponent();
            userInfo = x;
        }

        public event EventHandler<CloseFormEvent> formClosed;
        protected virtual void onFormClosed(CloseFormEvent e)
        {
            if (formClosed != null)
                formClosed(this, e);
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            CloseFormEvent x = new CloseFormEvent();
            x.CloseForm = true;            
            onFormClosed(x);
            Close();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            /* Проверява дали въведените име и парола се
             * съдържат в масива userInfo(подаден от Main формата) 
             * и при успех връща на Main формата съответния потребител и неговот ниво на достъп(AccessToken).
             */
            for (int i = 0; i < userInfo.Count; i++)
            {
                if (userName_TB.Text == userInfo[i].UserName.ToString())
                {
                    if (password_TB.Text == userInfo[i].Password.ToString())
                    {
                        MessageBox.Show("Вие се вписахте успешно.");
                        CloseFormEvent x = new CloseFormEvent();
                        x.CloseForm = true;
                        x.IsLogged = true;
                        x.LoggedUser = userInfo[i].UserName.ToString();
                        x.AccessToken = userInfo[i].AccessToken.ToString();
                        x.EditedData = true;
                        onFormClosed(x);
                        Close();                        
                    }
                    else
                    {
                        invalidUserPwd_Label.Visible = true;
                        break;
                    }
                }
                
                
            }
        }
    }
}
