namespace KursovaPSD
{
    partial class NewReservations
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
            this.reservation_Label = new System.Windows.Forms.Label();
            this.reservation_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.egn_Label = new System.Windows.Forms.Label();
            this.egn_TB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateFrom_Label = new System.Windows.Forms.Label();
            this.dateUntil_Label = new System.Windows.Forms.Label();
            this.country_Label = new System.Windows.Forms.Label();
            this.country_ComboBox = new System.Windows.Forms.ComboBox();
            this.room_Label = new System.Windows.Forms.Label();
            this.addReservation_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.guestsCount_Label = new System.Windows.Forms.Label();
            this.guestsCount_TB = new System.Windows.Forms.TextBox();
            this.guestInformation_GroupBox = new System.Windows.Forms.GroupBox();
            this.city_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.familyName_TB = new System.Windows.Forms.TextBox();
            this.familyName_Label = new System.Windows.Forms.Label();
            this.sex_ComboBox = new System.Windows.Forms.ComboBox();
            this.address_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_Label = new System.Windows.Forms.Label();
            this.roomNumber_TB = new System.Windows.Forms.TextBox();
            this.resInformation_GroupBox = new System.Windows.Forms.GroupBox();
            this.guestInformation_GroupBox.SuspendLayout();
            this.resInformation_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservation_Label
            // 
            this.reservation_Label.AutoSize = true;
            this.reservation_Label.Location = new System.Drawing.Point(6, 139);
            this.reservation_Label.Name = "reservation_Label";
            this.reservation_Label.Size = new System.Drawing.Size(46, 13);
            this.reservation_Label.TabIndex = 0;
            this.reservation_Label.Text = "Рез. №:";
            // 
            // reservation_TB
            // 
            this.reservation_TB.Location = new System.Drawing.Point(140, 136);
            this.reservation_TB.Name = "reservation_TB";
            this.reservation_TB.ReadOnly = true;
            this.reservation_TB.Size = new System.Drawing.Size(80, 20);
            this.reservation_TB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Име:";
            // 
            // firstName_TB
            // 
            this.firstName_TB.Location = new System.Drawing.Point(92, 31);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(142, 20);
            this.firstName_TB.TabIndex = 0;
            // 
            // egn_Label
            // 
            this.egn_Label.AutoSize = true;
            this.egn_Label.Location = new System.Drawing.Point(15, 86);
            this.egn_Label.Name = "egn_Label";
            this.egn_Label.Size = new System.Drawing.Size(31, 13);
            this.egn_Label.TabIndex = 4;
            this.egn_Label.Text = "ЕГН:";
            // 
            // egn_TB
            // 
            this.egn_TB.Location = new System.Drawing.Point(92, 83);
            this.egn_TB.Name = "egn_TB";
            this.egn_TB.Size = new System.Drawing.Size(142, 20);
            this.egn_TB.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(32, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateFrom_Label
            // 
            this.dateFrom_Label.AutoSize = true;
            this.dateFrom_Label.Location = new System.Drawing.Point(18, 34);
            this.dateFrom_Label.Name = "dateFrom_Label";
            this.dateFrom_Label.Size = new System.Drawing.Size(112, 13);
            this.dateFrom_Label.TabIndex = 8;
            this.dateFrom_Label.Text = "Дата на пристигане:";
            // 
            // dateUntil_Label
            // 
            this.dateUntil_Label.AutoSize = true;
            this.dateUntil_Label.Location = new System.Drawing.Point(18, 86);
            this.dateUntil_Label.Name = "dateUntil_Label";
            this.dateUntil_Label.Size = new System.Drawing.Size(116, 13);
            this.dateUntil_Label.TabIndex = 9;
            this.dateUntil_Label.Text = "Дата на заминаване:";
            // 
            // country_Label
            // 
            this.country_Label.AutoSize = true;
            this.country_Label.Location = new System.Drawing.Point(15, 112);
            this.country_Label.Name = "country_Label";
            this.country_Label.Size = new System.Drawing.Size(58, 13);
            this.country_Label.TabIndex = 10;
            this.country_Label.Text = "Държава:";
            // 
            // country_ComboBox
            // 
            this.country_ComboBox.FormattingEnabled = true;
            this.country_ComboBox.Items.AddRange(new object[] {
            "Австрия\t ",
            "Албания\t ",
            "Англия\t ",
            "Андора\t ",
            "Беларус\t ",
            "Белгия\t ",
            "Босна и Херцеговина\t ",
            "България\t ",
            "Ватикан\t ",
            "Германия\t ",
            "Гренландия\t ",
            "Гърция\t ",
            "Дания\t ",
            "Естония\t ",
            "Ирландия\t ",
            "Исландия\t ",
            "Испания\t ",
            "Италия\t ",
            "Кипър\t ",
            "Латвия\t ",
            "Литва\t ",
            "Лихтенщайн\t ",
            "Люксембург\t ",
            "Македония\t ",
            "Малта\t ",
            "Молдова\t ",
            "Монако\t ",
            "Норвегия\t ",
            "Полша\t ",
            "Португалия\t ",
            "Румъния\t ",
            "Русия\t ",
            "Сан Марино\t ",
            "Словакия\t ",
            "Словения\t ",
            "Сърбия\t ",
            "Турция\t ",
            "Украйна\t ",
            "Унгария\t ",
            "Финландия\t ",
            "Франция\t ",
            "Холандия\t ",
            "Хърватия\t ",
            "Черна гора\t ",
            "Чехия\t ",
            "Швейцария\t ",
            "Швеция"});
            this.country_ComboBox.Location = new System.Drawing.Point(92, 109);
            this.country_ComboBox.Name = "country_ComboBox";
            this.country_ComboBox.Size = new System.Drawing.Size(142, 21);
            this.country_ComboBox.TabIndex = 3;
            // 
            // room_Label
            // 
            this.room_Label.AutoSize = true;
            this.room_Label.Location = new System.Drawing.Point(6, 165);
            this.room_Label.Name = "room_Label";
            this.room_Label.Size = new System.Drawing.Size(48, 13);
            this.room_Label.TabIndex = 12;
            this.room_Label.Text = "Стая №:";
            // 
            // addReservation_Button
            // 
            this.addReservation_Button.Location = new System.Drawing.Point(352, 257);
            this.addReservation_Button.Name = "addReservation_Button";
            this.addReservation_Button.Size = new System.Drawing.Size(80, 23);
            this.addReservation_Button.TabIndex = 11;
            this.addReservation_Button.Text = "Добави";
            this.addReservation_Button.UseVisualStyleBackColor = true;
            this.addReservation_Button.Click += new System.EventHandler(this.addReservation_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(472, 257);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(80, 23);
            this.cancel_Button.TabIndex = 12;
            this.cancel_Button.Text = "Затвори";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // guestsCount_Label
            // 
            this.guestsCount_Label.AutoSize = true;
            this.guestsCount_Label.Location = new System.Drawing.Point(6, 191);
            this.guestsCount_Label.Name = "guestsCount_Label";
            this.guestsCount_Label.Size = new System.Drawing.Size(66, 13);
            this.guestsCount_Label.TabIndex = 16;
            this.guestsCount_Label.Text = "Брой гости:";
            // 
            // guestsCount_TB
            // 
            this.guestsCount_TB.Location = new System.Drawing.Point(140, 187);
            this.guestsCount_TB.Name = "guestsCount_TB";
            this.guestsCount_TB.Size = new System.Drawing.Size(80, 20);
            this.guestsCount_TB.TabIndex = 10;
            // 
            // guestInformation_GroupBox
            // 
            this.guestInformation_GroupBox.Controls.Add(this.city_TextBox);
            this.guestInformation_GroupBox.Controls.Add(this.label3);
            this.guestInformation_GroupBox.Controls.Add(this.familyName_TB);
            this.guestInformation_GroupBox.Controls.Add(this.familyName_Label);
            this.guestInformation_GroupBox.Controls.Add(this.sex_ComboBox);
            this.guestInformation_GroupBox.Controls.Add(this.address_TB);
            this.guestInformation_GroupBox.Controls.Add(this.label2);
            this.guestInformation_GroupBox.Controls.Add(this.address_Label);
            this.guestInformation_GroupBox.Controls.Add(this.label1);
            this.guestInformation_GroupBox.Controls.Add(this.firstName_TB);
            this.guestInformation_GroupBox.Controls.Add(this.egn_Label);
            this.guestInformation_GroupBox.Controls.Add(this.egn_TB);
            this.guestInformation_GroupBox.Controls.Add(this.country_ComboBox);
            this.guestInformation_GroupBox.Controls.Add(this.country_Label);
            this.guestInformation_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.guestInformation_GroupBox.Name = "guestInformation_GroupBox";
            this.guestInformation_GroupBox.Size = new System.Drawing.Size(260, 229);
            this.guestInformation_GroupBox.TabIndex = 18;
            this.guestInformation_GroupBox.TabStop = false;
            this.guestInformation_GroupBox.Text = "Информация за госта";
            // 
            // city_TextBox
            // 
            this.city_TextBox.Location = new System.Drawing.Point(92, 136);
            this.city_TextBox.Name = "city_TextBox";
            this.city_TextBox.Size = new System.Drawing.Size(142, 20);
            this.city_TextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Град:";
            // 
            // familyName_TB
            // 
            this.familyName_TB.Location = new System.Drawing.Point(92, 57);
            this.familyName_TB.Name = "familyName_TB";
            this.familyName_TB.Size = new System.Drawing.Size(142, 20);
            this.familyName_TB.TabIndex = 1;
            // 
            // familyName_Label
            // 
            this.familyName_Label.AutoSize = true;
            this.familyName_Label.Location = new System.Drawing.Point(15, 60);
            this.familyName_Label.Name = "familyName_Label";
            this.familyName_Label.Size = new System.Drawing.Size(59, 13);
            this.familyName_Label.TabIndex = 16;
            this.familyName_Label.Text = "Фамилия:";
            // 
            // sex_ComboBox
            // 
            this.sex_ComboBox.FormattingEnabled = true;
            this.sex_ComboBox.Items.AddRange(new object[] {
            "Мъж",
            "Жена"});
            this.sex_ComboBox.Location = new System.Drawing.Point(92, 188);
            this.sex_ComboBox.Name = "sex_ComboBox";
            this.sex_ComboBox.Size = new System.Drawing.Size(142, 21);
            this.sex_ComboBox.TabIndex = 6;
            // 
            // address_TB
            // 
            this.address_TB.Location = new System.Drawing.Point(92, 162);
            this.address_TB.Name = "address_TB";
            this.address_TB.Size = new System.Drawing.Size(142, 20);
            this.address_TB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пол:";
            // 
            // address_Label
            // 
            this.address_Label.AutoSize = true;
            this.address_Label.Location = new System.Drawing.Point(15, 165);
            this.address_Label.Name = "address_Label";
            this.address_Label.Size = new System.Drawing.Size(41, 13);
            this.address_Label.TabIndex = 12;
            this.address_Label.Text = "Адрес:";
            // 
            // roomNumber_TB
            // 
            this.roomNumber_TB.Location = new System.Drawing.Point(140, 162);
            this.roomNumber_TB.Name = "roomNumber_TB";
            this.roomNumber_TB.Size = new System.Drawing.Size(80, 20);
            this.roomNumber_TB.TabIndex = 9;
            // 
            // resInformation_GroupBox
            // 
            this.resInformation_GroupBox.Controls.Add(this.dateFrom_Label);
            this.resInformation_GroupBox.Controls.Add(this.roomNumber_TB);
            this.resInformation_GroupBox.Controls.Add(this.dateTimePicker2);
            this.resInformation_GroupBox.Controls.Add(this.guestsCount_Label);
            this.resInformation_GroupBox.Controls.Add(this.reservation_Label);
            this.resInformation_GroupBox.Controls.Add(this.dateTimePicker1);
            this.resInformation_GroupBox.Controls.Add(this.dateUntil_Label);
            this.resInformation_GroupBox.Controls.Add(this.guestsCount_TB);
            this.resInformation_GroupBox.Controls.Add(this.room_Label);
            this.resInformation_GroupBox.Controls.Add(this.reservation_TB);
            this.resInformation_GroupBox.Location = new System.Drawing.Point(320, 12);
            this.resInformation_GroupBox.Name = "resInformation_GroupBox";
            this.resInformation_GroupBox.Size = new System.Drawing.Size(255, 229);
            this.resInformation_GroupBox.TabIndex = 19;
            this.resInformation_GroupBox.TabStop = false;
            this.resInformation_GroupBox.Text = "Информация за резервацията";
            // 
            // NewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Button;
            this.ClientSize = new System.Drawing.Size(590, 298);
            this.ControlBox = false;
            this.Controls.Add(this.resInformation_GroupBox);
            this.Controls.Add(this.guestInformation_GroupBox);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.addReservation_Button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(606, 337);
            this.MinimumSize = new System.Drawing.Size(606, 337);
            this.Name = "NewReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нова резервация";
            this.guestInformation_GroupBox.ResumeLayout(false);
            this.guestInformation_GroupBox.PerformLayout();
            this.resInformation_GroupBox.ResumeLayout(false);
            this.resInformation_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reservation_Label;
        private System.Windows.Forms.TextBox reservation_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_TB;
        private System.Windows.Forms.Label egn_Label;
        private System.Windows.Forms.TextBox egn_TB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateFrom_Label;
        private System.Windows.Forms.Label dateUntil_Label;
        private System.Windows.Forms.Label country_Label;
        private System.Windows.Forms.ComboBox country_ComboBox;
        private System.Windows.Forms.Label room_Label;
        private System.Windows.Forms.Button addReservation_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Label guestsCount_Label;
        private System.Windows.Forms.TextBox guestsCount_TB;
        private System.Windows.Forms.GroupBox guestInformation_GroupBox;
        private System.Windows.Forms.TextBox roomNumber_TB;
        private System.Windows.Forms.Label address_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox familyName_TB;
        private System.Windows.Forms.Label familyName_Label;
        private System.Windows.Forms.ComboBox sex_ComboBox;
        private System.Windows.Forms.TextBox address_TB;
        private System.Windows.Forms.GroupBox resInformation_GroupBox;
        private System.Windows.Forms.TextBox city_TextBox;
        private System.Windows.Forms.Label label3;
    }
}