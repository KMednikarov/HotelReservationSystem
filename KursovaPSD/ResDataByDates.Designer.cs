namespace KursovaPSD
{
    partial class ResDataByDates
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUntilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.until_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showReservations_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearData_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNumberDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.guestsCountDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateUntilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // reservationNumberDataGridViewTextBoxColumn
            // 
            this.reservationNumberDataGridViewTextBoxColumn.DataPropertyName = "ReservationNumber";
            this.reservationNumberDataGridViewTextBoxColumn.HeaderText = "Рез. №";
            this.reservationNumberDataGridViewTextBoxColumn.Name = "reservationNumberDataGridViewTextBoxColumn";
            this.reservationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Име на госта";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Държава";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Стая №";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestsCountDataGridViewTextBoxColumn
            // 
            this.guestsCountDataGridViewTextBoxColumn.DataPropertyName = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.HeaderText = "Брой гости";
            this.guestsCountDataGridViewTextBoxColumn.Name = "guestsCountDataGridViewTextBoxColumn";
            this.guestsCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Пристигане";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUntilDataGridViewTextBoxColumn
            // 
            this.dateUntilDataGridViewTextBoxColumn.DataPropertyName = "DateUntil";
            this.dateUntilDataGridViewTextBoxColumn.HeaderText = "Заминаване";
            this.dateUntilDataGridViewTextBoxColumn.Name = "dateUntilDataGridViewTextBoxColumn";
            this.dateUntilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(KursovaPSD.Reservation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До:";
            // 
            // from_DateTimePicker
            // 
            this.from_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_DateTimePicker.Location = new System.Drawing.Point(38, 12);
            this.from_DateTimePicker.Name = "from_DateTimePicker";
            this.from_DateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.from_DateTimePicker.TabIndex = 3;
            // 
            // until_DateTimePicker
            // 
            this.until_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.until_DateTimePicker.Location = new System.Drawing.Point(219, 12);
            this.until_DateTimePicker.Name = "until_DateTimePicker";
            this.until_DateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.until_DateTimePicker.TabIndex = 4;
            // 
            // showReservations_Button
            // 
            this.showReservations_Button.Location = new System.Drawing.Point(375, 6);
            this.showReservations_Button.Name = "showReservations_Button";
            this.showReservations_Button.Size = new System.Drawing.Size(84, 29);
            this.showReservations_Button.TabIndex = 5;
            this.showReservations_Button.Text = "Покажи";
            this.showReservations_Button.UseVisualStyleBackColor = true;
            this.showReservations_Button.Click += new System.EventHandler(this.showReservations_Button_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(660, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Затвори";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearData_Button
            // 
            this.clearData_Button.Location = new System.Drawing.Point(475, 6);
            this.clearData_Button.Name = "clearData_Button";
            this.clearData_Button.Size = new System.Drawing.Size(84, 29);
            this.clearData_Button.TabIndex = 7;
            this.clearData_Button.Text = "Изчисти";
            this.clearData_Button.UseVisualStyleBackColor = true;
            this.clearData_Button.Click += new System.EventHandler(this.clearData_Button_Click);
            // 
            // ResDataByDates
            // 
            this.AcceptButton = this.showReservations_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(742, 487);
            this.ControlBox = false;
            this.Controls.Add(this.clearData_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showReservations_Button);
            this.Controls.Add(this.until_DateTimePicker);
            this.Controls.Add(this.from_DateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 526);
            this.MinimumSize = new System.Drawing.Size(758, 526);
            this.Name = "ResDataByDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справки по дата";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUntilDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker from_DateTimePicker;
        private System.Windows.Forms.DateTimePicker until_DateTimePicker;
        private System.Windows.Forms.Button showReservations_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearData_Button;
    }
}