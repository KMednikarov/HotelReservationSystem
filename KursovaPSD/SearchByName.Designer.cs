namespace KursovaPSD
{
    partial class SearchByName
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
            this.searchName_TB = new System.Windows.Forms.TextBox();
            this.guestName_Label = new System.Windows.Forms.Label();
            this.search_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.searchDGV = new System.Windows.Forms.DataGridView();
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
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchName_TB
            // 
            this.searchName_TB.Location = new System.Drawing.Point(56, 19);
            this.searchName_TB.Name = "searchName_TB";
            this.searchName_TB.Size = new System.Drawing.Size(123, 20);
            this.searchName_TB.TabIndex = 0;
            // 
            // guestName_Label
            // 
            this.guestName_Label.AutoSize = true;
            this.guestName_Label.Location = new System.Drawing.Point(12, 22);
            this.guestName_Label.Name = "guestName_Label";
            this.guestName_Label.Size = new System.Drawing.Size(29, 13);
            this.guestName_Label.TabIndex = 1;
            this.guestName_Label.Text = "Име";
            // 
            // search_Button
            // 
            this.search_Button.Location = new System.Drawing.Point(203, 17);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(75, 23);
            this.search_Button.TabIndex = 2;
            this.search_Button.Text = "Търси";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_Button.Location = new System.Drawing.Point(556, 17);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 3;
            this.close_Button.Text = "Затвори";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // searchDGV
            // 
            this.searchDGV.AllowUserToAddRows = false;
            this.searchDGV.AllowUserToDeleteRows = false;
            this.searchDGV.AllowUserToResizeColumns = false;
            this.searchDGV.AutoGenerateColumns = false;
            this.searchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNumberDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.egnDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.guestsCountDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateUntilDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.searchDGV.DataSource = this.reservationBindingSource;
            this.searchDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchDGV.Location = new System.Drawing.Point(0, 57);
            this.searchDGV.Name = "searchDGV";
            this.searchDGV.ReadOnly = true;
            this.searchDGV.Size = new System.Drawing.Size(643, 378);
            this.searchDGV.TabIndex = 4;
            this.searchDGV.Visible = false;
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
            // egnDataGridViewTextBoxColumn
            // 
            this.egnDataGridViewTextBoxColumn.DataPropertyName = "Egn";
            this.egnDataGridViewTextBoxColumn.HeaderText = "Egn";
            this.egnDataGridViewTextBoxColumn.Name = "egnDataGridViewTextBoxColumn";
            this.egnDataGridViewTextBoxColumn.ReadOnly = true;
            this.egnDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Visible = false;
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
            this.guestsCountDataGridViewTextBoxColumn.HeaderText = "Бр. гости";
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
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(KursovaPSD.Reservation);
            // 
            // SearchByName
            // 
            this.AcceptButton = this.search_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_Button;
            this.ClientSize = new System.Drawing.Size(643, 435);
            this.ControlBox = false;
            this.Controls.Add(this.searchDGV);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.guestName_Label);
            this.Controls.Add(this.searchName_TB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 474);
            this.MinimumSize = new System.Drawing.Size(659, 474);
            this.Name = "SearchByName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Търсене на гост";
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchName_TB;
        private System.Windows.Forms.Label guestName_Label;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.DataGridView searchDGV;
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
        private System.Windows.Forms.BindingSource reservationBindingSource;
    }
}