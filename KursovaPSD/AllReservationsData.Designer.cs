namespace KursovaPSD
{
    partial class AllReservationsData
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
            this.allReservations_DataGridView = new System.Windows.Forms.DataGridView();
            this.reservationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUntilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataClose_Button = new System.Windows.Forms.Button();
            this.deleteReservations_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allReservations_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allReservations_DataGridView
            // 
            this.allReservations_DataGridView.AllowUserToAddRows = false;
            this.allReservations_DataGridView.AllowUserToResizeColumns = false;
            this.allReservations_DataGridView.AllowUserToResizeRows = false;
            this.allReservations_DataGridView.AutoGenerateColumns = false;
            this.allReservations_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allReservations_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNumberDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.egnDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.guestsCountDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateUntilDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.allReservations_DataGridView.DataSource = this.reservationBindingSource;
            this.allReservations_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.allReservations_DataGridView.Name = "allReservations_DataGridView";
            this.allReservations_DataGridView.ReadOnly = true;
            this.allReservations_DataGridView.Size = new System.Drawing.Size(844, 457);
            this.allReservations_DataGridView.TabIndex = 0;
            this.allReservations_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.allReservations_DataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allReservations_DataGridView_ColumnHeaderMouseClick);
            // 
            // reservationNumberDataGridViewTextBoxColumn
            // 
            this.reservationNumberDataGridViewTextBoxColumn.DataPropertyName = "ReservationNumber";
            this.reservationNumberDataGridViewTextBoxColumn.HeaderText = "Рез. №";
            this.reservationNumberDataGridViewTextBoxColumn.Name = "reservationNumberDataGridViewTextBoxColumn";
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Име на госта";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            // 
            // egnDataGridViewTextBoxColumn
            // 
            this.egnDataGridViewTextBoxColumn.DataPropertyName = "Egn";
            this.egnDataGridViewTextBoxColumn.HeaderText = "Egn";
            this.egnDataGridViewTextBoxColumn.Name = "egnDataGridViewTextBoxColumn";
            this.egnDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Държава";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Стая №";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // guestsCountDataGridViewTextBoxColumn
            // 
            this.guestsCountDataGridViewTextBoxColumn.DataPropertyName = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.HeaderText = "Бр. гости";
            this.guestsCountDataGridViewTextBoxColumn.Name = "guestsCountDataGridViewTextBoxColumn";
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Пристигане";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            // 
            // dateUntilDataGridViewTextBoxColumn
            // 
            this.dateUntilDataGridViewTextBoxColumn.DataPropertyName = "DateUntil";
            this.dateUntilDataGridViewTextBoxColumn.HeaderText = "Заминаване";
            this.dateUntilDataGridViewTextBoxColumn.Name = "dateUntilDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Дължима сума (в лв.)";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(KursovaPSD.Reservation);
            // 
            // allDataClose_Button
            // 
            this.allDataClose_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.allDataClose_Button.Location = new System.Drawing.Point(564, 457);
            this.allDataClose_Button.Name = "allDataClose_Button";
            this.allDataClose_Button.Size = new System.Drawing.Size(280, 48);
            this.allDataClose_Button.TabIndex = 1;
            this.allDataClose_Button.Text = "Затвори";
            this.allDataClose_Button.UseVisualStyleBackColor = true;
            this.allDataClose_Button.Click += new System.EventHandler(this.allDataClose_Button_Click);
            // 
            // deleteReservations_Button
            // 
            this.deleteReservations_Button.Enabled = false;
            this.deleteReservations_Button.Location = new System.Drawing.Point(0, 457);
            this.deleteReservations_Button.Name = "deleteReservations_Button";
            this.deleteReservations_Button.Size = new System.Drawing.Size(280, 48);
            this.deleteReservations_Button.TabIndex = 3;
            this.deleteReservations_Button.Text = "Изтрий";
            this.deleteReservations_Button.UseVisualStyleBackColor = true;
            this.deleteReservations_Button.Click += new System.EventHandler(this.deleteReservations_Button_Click);
            // 
            // AllReservationsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.allDataClose_Button;
            this.ClientSize = new System.Drawing.Size(843, 505);
            this.ControlBox = false;
            this.Controls.Add(this.deleteReservations_Button);
            this.Controls.Add(this.allDataClose_Button);
            this.Controls.Add(this.allReservations_DataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 544);
            this.MinimumSize = new System.Drawing.Size(859, 544);
            this.Name = "AllReservationsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справки";
            ((System.ComponentModel.ISupportInitialize)(this.allReservations_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allReservations_DataGridView;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Button allDataClose_Button;
        private System.Windows.Forms.Button deleteReservations_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUntilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}