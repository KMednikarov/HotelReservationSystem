using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace KursovaPSD
{
    [Serializable]
    public class User
    {
       private string userName;
       public string UserName
       {
           get { return userName; }
           set { userName = value; }
       }

       private string password;
       public string Password
       {
           get { return password; }
           set { password = value; }
       }

       private string accessToken;
       public string AccessToken
       {
           get { return accessToken; }
           set { accessToken = value; }
       }       
    }
}