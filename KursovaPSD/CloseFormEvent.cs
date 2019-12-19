using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaPSD
{
    /*
     * "Custom event", чрез който Мain формата следи(чрез bool CloseForm)
     * дали се затварят допълнителните прозорци. Възможно е различните по функции
     * прозорци да предадат данни на Мain формата.
     */
    public class CloseFormEvent : EventArgs
    {
        public bool CloseForm { get; set; }
        public bool EditedData { get; set; }
        public bool IsLogged { get; set; }
        public string LoggedUser { get; set; }
        public string AccessToken { get; set; }
    }
}