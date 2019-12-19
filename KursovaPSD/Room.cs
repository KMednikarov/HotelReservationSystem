using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaPSD
{
   
    class Room
    {
        private int roomNumber;
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        private string roomType;
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }
        private bool isReserved = false;
        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }      
    }
}