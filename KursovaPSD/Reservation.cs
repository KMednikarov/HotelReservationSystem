using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaPSD
{
    [Serializable]
    public class Reservation
    {
        //Класът съдържа всички данни за гостите на хотела.
        private string reservationNumber;
        public string ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }

        private string guestName;
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        private string egn;
        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private int roomNumber;
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        private int guestsCount;
        public int GuestsCount
        {
            get { return guestsCount; }
            set { guestsCount = value; }
        }

        private DateTime dateFrom;
        public DateTime DateFrom
        {
            get { return dateFrom; }
            set { dateFrom = value; }
        }

        private DateTime dateUntil;
        public DateTime DateUntil
        {
            get { return dateUntil; }
            set { dateUntil = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private int sum;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
    }
}