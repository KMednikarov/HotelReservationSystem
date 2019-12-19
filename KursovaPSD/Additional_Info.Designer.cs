namespace KursovaPSD
{
    partial class Additional_Info
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
            System.Windows.Forms.Label guestNameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label egnLabel;
            System.Windows.Forms.Label sexLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additional_Info));
            this.reservationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reservationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.guestNameLabel1 = new System.Windows.Forms.Label();
            this.countryLabel1 = new System.Windows.Forms.Label();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.egnLabel1 = new System.Windows.Forms.Label();
            this.sexLabel1 = new System.Windows.Forms.Label();
            this.close_Button = new System.Windows.Forms.Button();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            guestNameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            egnLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingNavigator)).BeginInit();
            this.reservationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new System.Drawing.Point(18, 47);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new System.Drawing.Size(78, 13);
            guestNameLabel.TabIndex = 1;
            guestNameLabel.Text = "Име на госта:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(18, 91);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(58, 13);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Държава:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 139);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(41, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Адрес:";
            // 
            // egnLabel
            // 
            egnLabel.AutoSize = true;
            egnLabel.Location = new System.Drawing.Point(18, 189);
            egnLabel.Name = "egnLabel";
            egnLabel.Size = new System.Drawing.Size(31, 13);
            egnLabel.TabIndex = 7;
            egnLabel.Text = "ЕГН:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(18, 236);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(30, 13);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Пол:";
            // 
            // reservationBindingNavigator
            // 
            this.reservationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservationBindingNavigator.BindingSource = this.reservationBindingSource;
            this.reservationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservationBindingNavigator.Enabled = false;
            this.reservationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.reservationBindingNavigatorSaveItem});
            this.reservationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservationBindingNavigator.Name = "reservationBindingNavigator";
            this.reservationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservationBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.reservationBindingNavigator.TabIndex = 0;
            this.reservationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reservationBindingNavigatorSaveItem
            // 
            this.reservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservationBindingNavigatorSaveItem.Enabled = false;
            this.reservationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservationBindingNavigatorSaveItem.Image")));
            this.reservationBindingNavigatorSaveItem.Name = "reservationBindingNavigatorSaveItem";
            this.reservationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // guestNameLabel1
            // 
            this.guestNameLabel1.AutoSize = true;
            this.guestNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "GuestName", true));
            this.guestNameLabel1.Location = new System.Drawing.Point(156, 47);
            this.guestNameLabel1.Name = "guestNameLabel1";
            this.guestNameLabel1.Size = new System.Drawing.Size(35, 13);
            this.guestNameLabel1.TabIndex = 2;
            this.guestNameLabel1.Text = "label1";
            // 
            // countryLabel1
            // 
            this.countryLabel1.AutoSize = true;
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Country", true));
            this.countryLabel1.Location = new System.Drawing.Point(156, 91);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(35, 13);
            this.countryLabel1.TabIndex = 4;
            this.countryLabel1.Text = "label1";
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Address", true));
            this.addressLabel1.Location = new System.Drawing.Point(156, 139);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(35, 13);
            this.addressLabel1.TabIndex = 6;
            this.addressLabel1.Text = "label1";
            // 
            // egnLabel1
            // 
            this.egnLabel1.AutoSize = true;
            this.egnLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Egn", true));
            this.egnLabel1.Location = new System.Drawing.Point(156, 189);
            this.egnLabel1.Name = "egnLabel1";
            this.egnLabel1.Size = new System.Drawing.Size(35, 13);
            this.egnLabel1.TabIndex = 8;
            this.egnLabel1.Text = "label1";
            // 
            // sexLabel1
            // 
            this.sexLabel1.AutoSize = true;
            this.sexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "Sex", true));
            this.sexLabel1.Location = new System.Drawing.Point(156, 236);
            this.sexLabel1.Name = "sexLabel1";
            this.sexLabel1.Size = new System.Drawing.Size(35, 13);
            this.sexLabel1.TabIndex = 10;
            this.sexLabel1.Text = "label1";
            // 
            // close_Button
            // 
            this.close_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_Button.Location = new System.Drawing.Point(166, 262);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(90, 45);
            this.close_Button.TabIndex = 11;
            this.close_Button.Text = "Затвори";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(KursovaPSD.Reservation);
            // 
            // Additional_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.close_Button;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.ControlBox = false;
            this.Controls.Add(this.close_Button);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexLabel1);
            this.Controls.Add(egnLabel);
            this.Controls.Add(this.egnLabel1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryLabel1);
            this.Controls.Add(guestNameLabel);
            this.Controls.Add(this.guestNameLabel1);
            this.Controls.Add(this.reservationBindingNavigator);
            this.Name = "Additional_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Допълнителна информация";
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingNavigator)).EndInit();
            this.reservationBindingNavigator.ResumeLayout(false);
            this.reservationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.BindingNavigator reservationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton reservationBindingNavigatorSaveItem;
        private System.Windows.Forms.Label guestNameLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label egnLabel1;
        private System.Windows.Forms.Label sexLabel1;
        private System.Windows.Forms.Button close_Button;
    }
}