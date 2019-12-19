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

    public partial class Main : Form
    {
        private const string USERS_FILE = "users.dat";
        private const string RESERVATIONS_FILE = "reservations.dat";
        private double oweSum = 0;
        private int allGuests = 0;
        private int reservedRoomsCount = 0;
        private List<string> prices = new List<string>();
        private const int MAX_ROOMS = 60;
        private bool isLogged = false;
        private string loggedUser = "";
        private string accessToken = "";
        private BinaryFormatter bf = new BinaryFormatter();
        private FileStream fs;
        private Room[] allRooms = new Room[MAX_ROOMS];
        private List<Reservation> allReservations = new List<Reservation>();
        private List<User> userInfo = new List<User>();


        private void Initialize_General_Info()
        {
            foreach (Reservation item in allReservations)
            {
                oweSum += item.Sum;
                allGuests += item.GuestsCount;
                reservedRoomsCount++;
            }
            oweSum_Label.Text = oweSum.ToString() + " лв.";
            allGuests_Label.Text = allGuests.ToString();
            reservedRoomsCount_Label.Text = reservedRoomsCount.ToString();            
            oweSum = 0;
            reservedRoomsCount = 0;
            allGuests = 0;
        }
        private void Initialize_Rooms(int a)
        {            
            DateTime currentDate = DateTime.Today;

            /*
             * Функцията инициализира динамичен масив от клас Room 
             * с 60 стаи и сравнява за всяка стая дали се съдържа в
             * масива allReservations(данните се изтеглят от файл reservations.dat).
             * Ако конкретна стая се съдържа в масива за резервациите и ако
             * датите подадени от потребителя са в съответния период(булева променлива checkDates),
             * то в новосъздадения масив (allRooms[].IsReserved) се отбеляза, че стаята е заета.
             */
            for (int i = 0; i < MAX_ROOMS; i++)
            {
                allRooms[i] = new Room();
            }
                        
            for (int i = 0; i < MAX_ROOMS; i++)
            {
                allRooms[i].RoomNumber = i + 1;
                allRooms[i].IsReserved = false;

                for (int j = 0; j < allReservations.Count; j++)
                {   /*
                    Чрез подаденият аргумент 'а' на функцията се определя дали потребителят е
                    избрал различни дати. Ако не е избрал се използва днешна дата(currentDate).                    
                    */
                    int compareDates1 = DateTime.Compare(currentDate.Date, allReservations[j].DateFrom.Date);
                    int compareDates2 = DateTime.Compare(currentDate.Date, allReservations[j].DateUntil.Date);
                    /*
                     При промяна на датите в главното табло reservations_Table програмата
                    проверява дали датите от резервациите са в избрания период.
                     */
                    if (a == 1)
                    {
                        compareDates1 = DateTime.Compare(reservedFrom_DateTimePicker.Value.Date, allReservations[j].DateFrom.Date);
                        compareDates2 = DateTime.Compare(reservedUntil_DateTimePicker.Value.Date, allReservations[j].DateUntil.Date);
                    }
                    //Проверява дали резервацията е в периода на избраните дати в reservations_GroupBox.
                    bool checkDate = (compareDates1 == -1 || compareDates1 == 0) && (compareDates2 == 0 || compareDates2 == 1);
                    if (allReservations[j].RoomNumber == allRooms[i].RoomNumber && (a == 0 || checkDate))
                    {
                        allRooms[i].IsReserved = true;
                    }
                }
                //Според номера на стаята се определя от какъв вид е тя. Видовете стаи са определени
                // в легендата на главният екран.
                if (allRooms[i].RoomNumber >= 1 && allRooms[i].RoomNumber <= 15) allRooms[i].RoomType = "DBL";
                else if (allRooms[i].RoomNumber >= 16 && allRooms[i].RoomNumber <= 25) allRooms[i].RoomType = "DBL+";
                else if (allRooms[i].RoomNumber >= 26 && allRooms[i].RoomNumber <= 35) allRooms[i].RoomType = "SGL";
                else if (allRooms[i].RoomNumber >= 36 && allRooms[i].RoomNumber <= 50) allRooms[i].RoomType = "APP";
                else if (allRooms[i].RoomNumber >= 51 && allRooms[i].RoomNumber <= 60) allRooms[i].RoomType = "PTH";
            }
        }
        private void Initialize_Rooms_Labels()
        {
            /*
             * Функцията инициализира масив от лейбъли(rooms_Label[]),
             * в който се определя номера и типа на стаята(от масива allRooms[]).
             * Проверява се дали е заета и в зависимост от това, цвета на клетката(BackColor)
             * в reservations_Table се променя на зелен/червен.
             */
            for (int i = 0; i < MAX_ROOMS; i++)
            {
                rooms_Label[i] = new Label();
            }            
            for (int i = 0; i < MAX_ROOMS; i++)
            {
                rooms_Label[i].Text = "Стая " + allRooms[i].RoomNumber + "\n\n" + allRooms[i].RoomType;
                rooms_Label[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                rooms_Label[i].Dock = DockStyle.Fill;
                rooms_Label[i].ForeColor = System.Drawing.Color.White;
                if (allRooms[i].IsReserved)
                    rooms_Label[i].BackColor = System.Drawing.Color.Red;
                else rooms_Label[i].BackColor = System.Drawing.Color.Green;
                rooms_Label[i].BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private void Add_Controls_to_TableLayoutPanel()
        {
            //Масивът от лейбъли (rooms_Label[]) се добавя
            //в главното табло(reservations_Table.
            
            for (int i = 0; i < MAX_ROOMS; i++)
            {
                reservations_Table.Controls.Add(rooms_Label[i]);
            }
        }
        private void draw_TableLayoutPanel(int a=0)
        {
            //Функцията изчиства(Clear()) данните таблото, в случай, че данните се променят
            //и го презарежда.
            reservations_Table.Controls.Clear();
            Initialize_Rooms(a);
            Initialize_Rooms_Labels();
            Add_Controls_to_TableLayoutPanel();
        }
        private void Load_Users_File()
        {
            if (File.Exists(USERS_FILE))
            {
                fs = new FileStream(USERS_FILE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                userInfo = (List<User>)bf.Deserialize(fs);
                fs.Close();
            }
        }
        private void Load_Reservations_File()
        {
            if (File.Exists(RESERVATIONS_FILE))
            {
                fs = new FileStream(RESERVATIONS_FILE, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                allReservations = (List<Reservation>)bf.Deserialize(fs);
                fs.Close();
            }
        }
        
        public Main()
        {
            InitializeComponent();
            Load_Users_File();
            Load_Reservations_File();
            draw_TableLayoutPanel(0);
            Initialize_General_Info();
        }


        private void UserLogin(){
            //Функцията се изпълнява при вход в системата от формата Login(виж formClosed event)
            if (isLogged)
            {
                //Включване на допълнителни привилегии в зависимост от нивото на достъп.
                newToolStripButton.Enabled = true;
                if (accessToken == "Собственик")
                {
                    addNewUser_ToolStrip.Enabled = true;
                    deleteUser_ToolStrip.Enabled = true;
                }
                newReservation_ToolStripItem.Enabled = true;
                if (accessToken == "Собственик" || accessToken == "Администратор")
                {
                    deleteReservation_ToolStripItem.Enabled = true;
                    editReservationsToolStripButton.Enabled = true;
                    editReservation_ToolStripItem.Enabled = true;
                }
                resNumberSearch_ToolStripItem.Enabled = true;
                reservationsByDate_ToolStripItem.Enabled = true;
                allReservations_ToolStripItem.Enabled = true;
                guestNameSearch_ToolStripItem.Enabled = true;
                reservationsByDate_ToolStripItem.Enabled = true;
                changeUser_ToolStrip.Enabled = true;
                prices_ToolStripItem.Enabled = true;
                loggedUser_Label.Text = loggedUser;
                loggedUser_Label.Visible = true;
                loginLogout_Button.Text = "Отписване";
                youAreLogged_Label.Visible = true;
                newToolStripButton.Enabled = true;
                reportToolStripButton.Enabled = true;
                searchToolStripButton.Enabled = true;
            }
        }
        private void exit_ToolStripItem_Click(object sender, EventArgs e) // Yes/No
        {
            if(MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Изход",MessageBoxButtons.YesNo) == DialogResult.Yes)
            Application.Exit();
        }

        /*
         *
         * За всички функции отварящи нов прозорец, програмата изключва(Enabled=false) главния(Main) прозорец
         * и не позволява кликане с мишката.
         *
         */
        private void addNewUser_ToolStrip_Click(object sender, EventArgs e)
        {
            AddUser newUser = new AddUser();
            newUser.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            newUser.Show();
            this.Enabled = false;
        }
        private void loginLogout_Button_Click(object sender, EventArgs e)
        {
            /* Ако вече има "вписан" потребител(проверка с isLogged),
             * програмата "отписва" съответния потребител.
             * Ако няма "вписан"/логнат потребител, се появява
             * нов прозорец(Login form), където могат да се въведат име и парола.
             */
            if (isLogged)
            {
                //Изключва(бутоните) допълнителните привилегии на потребителите
                Load_Users_File();
                newToolStripButton.Enabled = false;
                addNewUser_ToolStrip.Enabled = false;
                deleteUser_ToolStrip.Enabled = false;
                reservationsByDate_ToolStripItem.Enabled = false;
                resNumberSearch_ToolStripItem.Enabled = false;
                editReservation_ToolStripItem.Enabled = false;
                newReservation_ToolStripItem.Enabled = false;
                deleteReservation_ToolStripItem.Enabled = false;
                guestNameSearch_ToolStripItem.Enabled = false;
                loggedUser_Label.Visible = false;
                youAreLogged_Label.Visible = false;
                reportToolStripButton.Enabled = false;
                searchToolStripButton.Enabled = false;
                editReservationsToolStripButton.Enabled = false;
                loginLogout_Button.Text = "Вписване";
                accessToken = "";
                loggedUser = "";
                isLogged = false;
            }
            else
            {
                Login login = new Login(userInfo);
                login.formClosed += new EventHandler<CloseFormEvent>(formClosed);
                login.Show();
                this.Enabled = false;                
            }
        }
      
        private void newReservation_ToolStripItem_Click(object sender, EventArgs e)
        {
            NewReservations res = new NewReservations(allReservations);
            res.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            res.Show();
            this.Enabled = false;
        }       
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewReservations res = new NewReservations(allReservations);
            res.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            res.Show();
            this.Enabled = false;
        }
        private void deleteReservation_ToolStripItem_Click(object sender, EventArgs e)
        {
            AllReservationsData data = new AllReservationsData(allReservations, accessToken);
            data.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            data.Show();
            this.Enabled = false;
        }
        private void reservationsByDate_ToolStripItem_Click(object sender, EventArgs e)
        {
            ResDataByDates reservationsByDates = new ResDataByDates(allReservations);
            reservationsByDates.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            reservationsByDates.Show();
            this.Enabled = false;
        }
        private void allReservations_ToolStripItem_Click(object sender, EventArgs e)
        {
            AllReservationsData data = new AllReservationsData(allReservations, accessToken);
            data.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            data.Show();
            this.Enabled = false;
        }
        private void guestNameSearch_ToolStripItem_Click(object sender, EventArgs e)
        {
            SearchByName search = new SearchByName(allReservations);
            search.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            search.Show();
            this.Enabled = false;
        }
        private void resNumberSearch_ToolStripItem_Click(object sender, EventArgs e)
        {
            SearchByReservationNum search = new SearchByReservationNum(allReservations);
            search.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            search.Show();
            this.Enabled = false;
        }
        private void deleteUser_ToolStrip_Click(object sender, EventArgs e)
        {
            DeleteUsers deleteUsers = new DeleteUsers(userInfo);
            deleteUsers.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            deleteUsers.Show();
            this.Enabled = false;
        }
        private void editReservation_ToolStripItem_Click(object sender, EventArgs e)
        {
            EditReservations edit = new EditReservations(allReservations);
            edit.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            edit.Show();
            this.Enabled = false;
        }

        private void prices_ToolStripItem_Click(object sender, EventArgs e)
        {
            RoomPrices prices = new RoomPrices(accessToken);
            prices.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            prices.Show();
            this.Enabled = false;
        }
        private void changeUser_ToolStrip_Click(object sender, EventArgs e)
        {
            Login login = new Login(userInfo);
            login.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            login.Show();
            this.Enabled = false;

        }
        private void заПрограматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            about.Show();
            this.Enabled = false;
        }
         //Toolbar
        private void лентаСИнструментиToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (toolBar.Visible == true)
                toolBar.Visible = false;
            else toolBar.Visible = true;
        }
        private void reportToolStripButton_Click(object sender, EventArgs e)
        {
            AllReservationsData data = new AllReservationsData(allReservations, accessToken);
            data.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            data.Show();
            this.Enabled = false;
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            SearchByName search = new SearchByName(allReservations);
            search.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            search.Show();
            this.Enabled = false;
        }

        private void editReservationsToolStripButton_Click(object sender, EventArgs e)
        {
            EditReservations edit = new EditReservations(allReservations);
            edit.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            edit.Show();
            this.Enabled = false;
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            Login login = new Login(userInfo);
            login.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            login.Show();
            this.Enabled = false;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.formClosed += new EventHandler<CloseFormEvent>(formClosed);
            about.Show();
            this.Enabled = false;
        }

        /* Функцията formClosed следи за затваряне на отворените прозорци. При затваряне на допълнителен прозорец,
         * главния(Main) прозорец отново се включва и се презарежда таблото с резервирани стаи.
         * Възможно е промяна на данни от някои форми: 
         *    -Login;
         *    -AllReservationsDatа - при изтриване на резервация се прерисува таблото reservations_Table;
         *    -Reservations;
         *    -AddUser.
         */
        private void formClosed(object sender, CloseFormEvent e)
        {
            if (e != null)
            {
                if (e.CloseForm != false)
                    this.Enabled = e.CloseForm;
                if (e.EditedData != false)
                {
                    draw_TableLayoutPanel(0);
                    Initialize_General_Info();
                    Load_Users_File();
                    Load_Reservations_File();
                }
                if (e.IsLogged)
                {
                    isLogged = e.IsLogged;
                    loggedUser = e.LoggedUser;
                    accessToken = e.AccessToken;
                    UserLogin();
                }
            }
        }

        private void showReservedRooms_Button_Click(object sender, EventArgs e)
        {
            draw_TableLayoutPanel(1);
        }

    }
}