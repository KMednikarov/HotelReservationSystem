namespace KursovaPSD
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginLogout_Button = new System.Windows.Forms.Button();
            this.file_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.users_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUser_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUser_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUser_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservations_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newReservation_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReservation_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReservation_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.allReservations_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsByDate_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prices_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.resNumberSearch_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestNameSearch_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.изгледToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лентаСИнструментиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПрограматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggedUser_Label = new System.Windows.Forms.Label();
            this.youAreLogged_Label = new System.Windows.Forms.Label();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editReservationsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reservations_Table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reservedFrom_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservedUntil_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservations_GroupBox = new System.Windows.Forms.GroupBox();
            this.showReservedRooms_Button = new System.Windows.Forms.Button();
            this.reservedUntil_Label = new System.Windows.Forms.Label();
            this.reservedFrom_Label = new System.Windows.Forms.Label();
            this.information_GroupBox = new System.Windows.Forms.GroupBox();
            this.reservedRoomsCount_Label = new System.Windows.Forms.Label();
            this.allGuests_Label = new System.Windows.Forms.Label();
            this.oweSum_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reservations_GroupBox.SuspendLayout();
            this.information_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLogout_Button
            // 
            this.loginLogout_Button.Location = new System.Drawing.Point(887, 12);
            this.loginLogout_Button.Name = "loginLogout_Button";
            this.loginLogout_Button.Size = new System.Drawing.Size(75, 23);
            this.loginLogout_Button.TabIndex = 8;
            this.loginLogout_Button.Text = "Вписване";
            this.loginLogout_Button.UseVisualStyleBackColor = true;
            this.loginLogout_Button.Click += new System.EventHandler(this.loginLogout_Button_Click);
            // 
            // file_ToolStrip
            // 
            this.file_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.users_ToolStripItem,
            this.exit_ToolStripItem});
            this.file_ToolStrip.Name = "file_ToolStrip";
            this.file_ToolStrip.Size = new System.Drawing.Size(66, 20);
            this.file_ToolStrip.Text = "Система";
            // 
            // users_ToolStripItem
            // 
            this.users_ToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUser_ToolStrip,
            this.addNewUser_ToolStrip,
            this.deleteUser_ToolStrip});
            this.users_ToolStripItem.Name = "users_ToolStripItem";
            this.users_ToolStripItem.Size = new System.Drawing.Size(147, 22);
            this.users_ToolStripItem.Text = "Потребители";
            // 
            // changeUser_ToolStrip
            // 
            this.changeUser_ToolStrip.Name = "changeUser_ToolStrip";
            this.changeUser_ToolStrip.Size = new System.Drawing.Size(215, 22);
            this.changeUser_ToolStrip.Text = "Смяна на потребител";
            this.changeUser_ToolStrip.Click += new System.EventHandler(this.changeUser_ToolStrip_Click);
            // 
            // addNewUser_ToolStrip
            // 
            this.addNewUser_ToolStrip.Enabled = false;
            this.addNewUser_ToolStrip.Name = "addNewUser_ToolStrip";
            this.addNewUser_ToolStrip.Size = new System.Drawing.Size(215, 22);
            this.addNewUser_ToolStrip.Text = "Нов потребител";
            this.addNewUser_ToolStrip.Click += new System.EventHandler(this.addNewUser_ToolStrip_Click);
            // 
            // deleteUser_ToolStrip
            // 
            this.deleteUser_ToolStrip.Enabled = false;
            this.deleteUser_ToolStrip.Name = "deleteUser_ToolStrip";
            this.deleteUser_ToolStrip.Size = new System.Drawing.Size(215, 22);
            this.deleteUser_ToolStrip.Text = "Изтриване на потребител";
            this.deleteUser_ToolStrip.Click += new System.EventHandler(this.deleteUser_ToolStrip_Click);
            // 
            // exit_ToolStripItem
            // 
            this.exit_ToolStripItem.Name = "exit_ToolStripItem";
            this.exit_ToolStripItem.Size = new System.Drawing.Size(147, 22);
            this.exit_ToolStripItem.Text = "Изход";
            this.exit_ToolStripItem.Click += new System.EventHandler(this.exit_ToolStripItem_Click);
            // 
            // reservations_ToolStrip
            // 
            this.reservations_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReservation_ToolStripItem,
            this.editReservation_ToolStripItem,
            this.deleteReservation_ToolStripItem});
            this.reservations_ToolStrip.Name = "reservations_ToolStrip";
            this.reservations_ToolStrip.Size = new System.Drawing.Size(83, 20);
            this.reservations_ToolStrip.Text = "Резервации";
            // 
            // newReservation_ToolStripItem
            // 
            this.newReservation_ToolStripItem.Enabled = false;
            this.newReservation_ToolStripItem.Name = "newReservation_ToolStripItem";
            this.newReservation_ToolStripItem.Size = new System.Drawing.Size(168, 22);
            this.newReservation_ToolStripItem.Text = "Нова резервация";
            this.newReservation_ToolStripItem.Click += new System.EventHandler(this.newReservation_ToolStripItem_Click);
            // 
            // editReservation_ToolStripItem
            // 
            this.editReservation_ToolStripItem.Enabled = false;
            this.editReservation_ToolStripItem.Name = "editReservation_ToolStripItem";
            this.editReservation_ToolStripItem.Size = new System.Drawing.Size(168, 22);
            this.editReservation_ToolStripItem.Text = "Редактиране";
            this.editReservation_ToolStripItem.Click += new System.EventHandler(this.editReservation_ToolStripItem_Click);
            // 
            // deleteReservation_ToolStripItem
            // 
            this.deleteReservation_ToolStripItem.Enabled = false;
            this.deleteReservation_ToolStripItem.Name = "deleteReservation_ToolStripItem";
            this.deleteReservation_ToolStripItem.Size = new System.Drawing.Size(168, 22);
            this.deleteReservation_ToolStripItem.Text = "Изтриване";
            this.deleteReservation_ToolStripItem.Click += new System.EventHandler(this.deleteReservation_ToolStripItem_Click);
            // 
            // info_ToolStrip
            // 
            this.info_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allReservations_ToolStripItem,
            this.reservationsByDate_ToolStripItem,
            this.prices_ToolStripItem});
            this.info_ToolStrip.Name = "info_ToolStrip";
            this.info_ToolStrip.Size = new System.Drawing.Size(66, 20);
            this.info_ToolStrip.Text = "Справки";
            // 
            // allReservations_ToolStripItem
            // 
            this.allReservations_ToolStripItem.Enabled = false;
            this.allReservations_ToolStripItem.Name = "allReservations_ToolStripItem";
            this.allReservations_ToolStripItem.Size = new System.Drawing.Size(181, 22);
            this.allReservations_ToolStripItem.Text = "Всички резервации";
            this.allReservations_ToolStripItem.Click += new System.EventHandler(this.allReservations_ToolStripItem_Click);
            // 
            // reservationsByDate_ToolStripItem
            // 
            this.reservationsByDate_ToolStripItem.Enabled = false;
            this.reservationsByDate_ToolStripItem.Name = "reservationsByDate_ToolStripItem";
            this.reservationsByDate_ToolStripItem.Size = new System.Drawing.Size(181, 22);
            this.reservationsByDate_ToolStripItem.Text = "По дата";
            this.reservationsByDate_ToolStripItem.Click += new System.EventHandler(this.reservationsByDate_ToolStripItem_Click);
            // 
            // prices_ToolStripItem
            // 
            this.prices_ToolStripItem.Enabled = false;
            this.prices_ToolStripItem.Name = "prices_ToolStripItem";
            this.prices_ToolStripItem.Size = new System.Drawing.Size(181, 22);
            this.prices_ToolStripItem.Text = "Ценоразпис";
            this.prices_ToolStripItem.Click += new System.EventHandler(this.prices_ToolStripItem_Click);
            // 
            // search_ToolStrip
            // 
            this.search_ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resNumberSearch_ToolStripItem,
            this.guestNameSearch_ToolStripItem});
            this.search_ToolStrip.Name = "search_ToolStrip";
            this.search_ToolStrip.Size = new System.Drawing.Size(65, 20);
            this.search_ToolStrip.Text = "Търсене";
            // 
            // resNumberSearch_ToolStripItem
            // 
            this.resNumberSearch_ToolStripItem.Enabled = false;
            this.resNumberSearch_ToolStripItem.Name = "resNumberSearch_ToolStripItem";
            this.resNumberSearch_ToolStripItem.Size = new System.Drawing.Size(211, 22);
            this.resNumberSearch_ToolStripItem.Text = "По номер на резервация";
            this.resNumberSearch_ToolStripItem.Click += new System.EventHandler(this.resNumberSearch_ToolStripItem_Click);
            // 
            // guestNameSearch_ToolStripItem
            // 
            this.guestNameSearch_ToolStripItem.Enabled = false;
            this.guestNameSearch_ToolStripItem.Name = "guestNameSearch_ToolStripItem";
            this.guestNameSearch_ToolStripItem.Size = new System.Drawing.Size(211, 22);
            this.guestNameSearch_ToolStripItem.Text = "По име на госта";
            this.guestNameSearch_ToolStripItem.Click += new System.EventHandler(this.guestNameSearch_ToolStripItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStrip,
            this.reservations_ToolStrip,
            this.info_ToolStrip,
            this.search_ToolStrip,
            this.изгледToolStripMenuItem,
            this.помощToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // изгледToolStripMenuItem
            // 
            this.изгледToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лентаСИнструментиToolStripMenuItem});
            this.изгледToolStripMenuItem.Name = "изгледToolStripMenuItem";
            this.изгледToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.изгледToolStripMenuItem.Text = "Изглед";
            // 
            // лентаСИнструментиToolStripMenuItem
            // 
            this.лентаСИнструментиToolStripMenuItem.Checked = true;
            this.лентаСИнструментиToolStripMenuItem.CheckOnClick = true;
            this.лентаСИнструментиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.лентаСИнструментиToolStripMenuItem.Name = "лентаСИнструментиToolStripMenuItem";
            this.лентаСИнструментиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.лентаСИнструментиToolStripMenuItem.Text = "Лента с инструменти";
            this.лентаСИнструментиToolStripMenuItem.CheckedChanged += new System.EventHandler(this.лентаСИнструментиToolStripMenuItem_CheckedChanged);
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заПрограматаToolStripMenuItem});
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.помощToolStripMenuItem.Text = "Помощ";
            // 
            // заПрограматаToolStripMenuItem
            // 
            this.заПрограматаToolStripMenuItem.Name = "заПрограматаToolStripMenuItem";
            this.заПрограматаToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.заПрограматаToolStripMenuItem.Text = "За програмата";
            this.заПрограматаToolStripMenuItem.Click += new System.EventHandler(this.заПрограматаToolStripMenuItem_Click);
            // 
            // loggedUser_Label
            // 
            this.loggedUser_Label.AutoSize = true;
            this.loggedUser_Label.ForeColor = System.Drawing.Color.Green;
            this.loggedUser_Label.Location = new System.Drawing.Point(826, 17);
            this.loggedUser_Label.Name = "loggedUser_Label";
            this.loggedUser_Label.Size = new System.Drawing.Size(35, 13);
            this.loggedUser_Label.TabIndex = 10;
            this.loggedUser_Label.Text = "label1";
            this.loggedUser_Label.Visible = false;
            // 
            // youAreLogged_Label
            // 
            this.youAreLogged_Label.AutoSize = true;
            this.youAreLogged_Label.Location = new System.Drawing.Point(667, 17);
            this.youAreLogged_Label.Name = "youAreLogged_Label";
            this.youAreLogged_Label.Size = new System.Drawing.Size(153, 13);
            this.youAreLogged_Label.TabIndex = 11;
            this.youAreLogged_Label.Text = "В момента сте влезли като: ";
            this.youAreLogged_Label.Visible = false;
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.reportToolStripButton,
            this.searchToolStripButton,
            this.editReservationsToolStripButton,
            this.toolStripSeparator,
            this.loginToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolBar.Size = new System.Drawing.Size(224, 25);
            this.toolBar.TabIndex = 12;
            this.toolBar.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Enabled = false;
            this.newToolStripButton.Image = global::KursovaPSD.Properties.Resources.NewReservationButton2;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.newToolStripButton.ToolTipText = "Нова резервация";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // reportToolStripButton
            // 
            this.reportToolStripButton.AutoSize = false;
            this.reportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportToolStripButton.Enabled = false;
            this.reportToolStripButton.Image = global::KursovaPSD.Properties.Resources.ReportButton;
            this.reportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportToolStripButton.Name = "reportToolStripButton";
            this.reportToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.reportToolStripButton.ToolTipText = "Справки";
            this.reportToolStripButton.Click += new System.EventHandler(this.reportToolStripButton_Click);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.AutoSize = false;
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Enabled = false;
            this.searchToolStripButton.Image = global::KursovaPSD.Properties.Resources.SearchButton;
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.searchToolStripButton.ToolTipText = "Търсене";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // editReservationsToolStripButton
            // 
            this.editReservationsToolStripButton.AutoSize = false;
            this.editReservationsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editReservationsToolStripButton.Enabled = false;
            this.editReservationsToolStripButton.Image = global::KursovaPSD.Properties.Resources.editReservationButton;
            this.editReservationsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editReservationsToolStripButton.Name = "editReservationsToolStripButton";
            this.editReservationsToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.editReservationsToolStripButton.ToolTipText = "Редактиране на резервации";
            this.editReservationsToolStripButton.Click += new System.EventHandler(this.editReservationsToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // loginToolStripButton
            // 
            this.loginToolStripButton.AutoSize = false;
            this.loginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginToolStripButton.Image = global::KursovaPSD.Properties.Resources.Login;
            this.loginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginToolStripButton.Name = "loginToolStripButton";
            this.loginToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.loginToolStripButton.ToolTipText = "Вписване";
            this.loginToolStripButton.Click += new System.EventHandler(this.loginToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.AutoSize = false;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = global::KursovaPSD.Properties.Resources.HelpButton;
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(30, 25);
            this.helpToolStripButton.ToolTipText = "За програмата";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // reservations_Table
            // 
            this.reservations_Table.ColumnCount = 10;
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservations_Table.Location = new System.Drawing.Point(26, 57);
            this.reservations_Table.Name = "reservations_Table";
            this.reservations_Table.RowCount = 6;
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.reservations_Table.Size = new System.Drawing.Size(899, 461);
            this.reservations_Table.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.MinimumSize = new System.Drawing.Size(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Свободна\r\nстая\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 16);
            this.label2.MinimumSize = new System.Drawing.Size(74, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Резервирана\r\nстая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 65);
            this.label3.TabIndex = 16;
            this.label3.Text = "APP\r\nDBL\r\nDBL+ \r\nSGL\r\nPTH ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 615);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 131);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Легенда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 65);
            this.label4.TabIndex = 17;
            this.label4.Text = "Апартамент\r\nДвойна стая\r\nДвойна разширена\r\nЕдинична\r\nМезонет";
            // 
            // reservedFrom_DateTimePicker
            // 
            this.reservedFrom_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservedFrom_DateTimePicker.Location = new System.Drawing.Point(76, 25);
            this.reservedFrom_DateTimePicker.Name = "reservedFrom_DateTimePicker";
            this.reservedFrom_DateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.reservedFrom_DateTimePicker.TabIndex = 18;
            // 
            // reservedUntil_DateTimePicker
            // 
            this.reservedUntil_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservedUntil_DateTimePicker.Location = new System.Drawing.Point(244, 25);
            this.reservedUntil_DateTimePicker.Name = "reservedUntil_DateTimePicker";
            this.reservedUntil_DateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.reservedUntil_DateTimePicker.TabIndex = 19;
            // 
            // reservations_GroupBox
            // 
            this.reservations_GroupBox.Controls.Add(this.showReservedRooms_Button);
            this.reservations_GroupBox.Controls.Add(this.reservedUntil_Label);
            this.reservations_GroupBox.Controls.Add(this.reservedFrom_Label);
            this.reservations_GroupBox.Controls.Add(this.reservations_Table);
            this.reservations_GroupBox.Controls.Add(this.reservedFrom_DateTimePicker);
            this.reservations_GroupBox.Controls.Add(this.reservedUntil_DateTimePicker);
            this.reservations_GroupBox.Location = new System.Drawing.Point(12, 52);
            this.reservations_GroupBox.Name = "reservations_GroupBox";
            this.reservations_GroupBox.Size = new System.Drawing.Size(947, 533);
            this.reservations_GroupBox.TabIndex = 20;
            this.reservations_GroupBox.TabStop = false;
            this.reservations_GroupBox.Text = "Резервирани стаи за периода";
            // 
            // showReservedRooms_Button
            // 
            this.showReservedRooms_Button.Location = new System.Drawing.Point(367, 19);
            this.showReservedRooms_Button.Name = "showReservedRooms_Button";
            this.showReservedRooms_Button.Size = new System.Drawing.Size(65, 32);
            this.showReservedRooms_Button.TabIndex = 22;
            this.showReservedRooms_Button.Text = "Покажи";
            this.showReservedRooms_Button.UseVisualStyleBackColor = true;
            this.showReservedRooms_Button.Click += new System.EventHandler(this.showReservedRooms_Button_Click);
            // 
            // reservedUntil_Label
            // 
            this.reservedUntil_Label.Location = new System.Drawing.Point(207, 28);
            this.reservedUntil_Label.Name = "reservedUntil_Label";
            this.reservedUntil_Label.Size = new System.Drawing.Size(31, 23);
            this.reservedUntil_Label.TabIndex = 21;
            this.reservedUntil_Label.Text = "До";
            this.reservedUntil_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reservedFrom_Label
            // 
            this.reservedFrom_Label.Location = new System.Drawing.Point(39, 28);
            this.reservedFrom_Label.Name = "reservedFrom_Label";
            this.reservedFrom_Label.Size = new System.Drawing.Size(31, 23);
            this.reservedFrom_Label.TabIndex = 20;
            this.reservedFrom_Label.Text = "От";
            this.reservedFrom_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // information_GroupBox
            // 
            this.information_GroupBox.AutoSize = true;
            this.information_GroupBox.Controls.Add(this.reservedRoomsCount_Label);
            this.information_GroupBox.Controls.Add(this.allGuests_Label);
            this.information_GroupBox.Controls.Add(this.oweSum_Label);
            this.information_GroupBox.Controls.Add(this.label7);
            this.information_GroupBox.Controls.Add(this.label6);
            this.information_GroupBox.Controls.Add(this.label5);
            this.information_GroupBox.Location = new System.Drawing.Point(778, 615);
            this.information_GroupBox.Name = "information_GroupBox";
            this.information_GroupBox.Size = new System.Drawing.Size(159, 127);
            this.information_GroupBox.TabIndex = 21;
            this.information_GroupBox.TabStop = false;
            this.information_GroupBox.Text = "Обща информация";
            // 
            // reservedRoomsCount_Label
            // 
            this.reservedRoomsCount_Label.AutoSize = true;
            this.reservedRoomsCount_Label.Location = new System.Drawing.Point(101, 32);
            this.reservedRoomsCount_Label.Name = "reservedRoomsCount_Label";
            this.reservedRoomsCount_Label.Size = new System.Drawing.Size(35, 13);
            this.reservedRoomsCount_Label.TabIndex = 5;
            this.reservedRoomsCount_Label.Text = "label8";
            this.reservedRoomsCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allGuests_Label
            // 
            this.allGuests_Label.AutoSize = true;
            this.allGuests_Label.Location = new System.Drawing.Point(101, 57);
            this.allGuests_Label.Name = "allGuests_Label";
            this.allGuests_Label.Size = new System.Drawing.Size(35, 13);
            this.allGuests_Label.TabIndex = 4;
            this.allGuests_Label.Text = "label8";
            this.allGuests_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oweSum_Label
            // 
            this.oweSum_Label.AutoSize = true;
            this.oweSum_Label.Location = new System.Drawing.Point(101, 98);
            this.oweSum_Label.Name = "oweSum_Label";
            this.oweSum_Label.Size = new System.Drawing.Size(35, 13);
            this.oweSum_Label.TabIndex = 3;
            this.oweSum_Label.Text = "label8";
            this.oweSum_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дължими суми \r\nот клиенти:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Общ брой гости:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Общ брой \r\nрезервации:";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(KursovaPSD.Reservation);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 757);
            this.Controls.Add(this.information_GroupBox);
            this.Controls.Add(this.reservations_GroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.youAreLogged_Label);
            this.Controls.Add(this.loggedUser_Label);
            this.Controls.Add(this.loginLogout_Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(942, 796);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.reservations_GroupBox.ResumeLayout(false);
            this.information_GroupBox.ResumeLayout(false);
            this.information_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginLogout_Button;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem users_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem changeUser_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewUser_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteUser_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem reservations_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newReservation_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem editReservation_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReservation_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem info_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem search_ToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label loggedUser_Label;
        private System.Windows.Forms.Label youAreLogged_Label;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripButton reportToolStripButton;
        private System.Windows.Forms.ToolStripButton editReservationsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton loginToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TableLayoutPanel reservations_Table;
        private System.Windows.Forms.Label[] rooms_Label = new System.Windows.Forms.Label[60];
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem reservationsByDate_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem allReservations_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem resNumberSearch_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem guestNameSearch_ToolStripItem;
        private System.Windows.Forms.DateTimePicker reservedFrom_DateTimePicker;
        private System.Windows.Forms.DateTimePicker reservedUntil_DateTimePicker;
        private System.Windows.Forms.GroupBox reservations_GroupBox;
        private System.Windows.Forms.Label reservedUntil_Label;
        private System.Windows.Forms.Label reservedFrom_Label;
        private System.Windows.Forms.Button showReservedRooms_Button;
        private System.Windows.Forms.GroupBox information_GroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem prices_ToolStripItem;
        private System.Windows.Forms.Label oweSum_Label;
        private System.Windows.Forms.Label allGuests_Label;
        private System.Windows.Forms.Label reservedRoomsCount_Label;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПрограматаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изгледToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лентаСИнструментиToolStripMenuItem;

    }
}

