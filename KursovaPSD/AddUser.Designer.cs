namespace KursovaPSD
{
    partial class AddUser
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
            this.addUser_Label = new System.Windows.Forms.Label();
            this.userName_TB = new System.Windows.Forms.TextBox();
            this.newPassword_TB = new System.Windows.Forms.TextBox();
            this.newPassword_Label = new System.Windows.Forms.Label();
            this.addNewUser_Button = new System.Windows.Forms.Button();
            this.addUserCancel_Button = new System.Windows.Forms.Button();
            this.accessToken_Label = new System.Windows.Forms.Label();
            this.accessToken_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addUser_Label
            // 
            this.addUser_Label.AutoSize = true;
            this.addUser_Label.Location = new System.Drawing.Point(13, 13);
            this.addUser_Label.Name = "addUser_Label";
            this.addUser_Label.Size = new System.Drawing.Size(111, 13);
            this.addUser_Label.TabIndex = 0;
            this.addUser_Label.Text = "Потребителско име:";
            // 
            // userName_TB
            // 
            this.userName_TB.Location = new System.Drawing.Point(16, 30);
            this.userName_TB.Name = "userName_TB";
            this.userName_TB.Size = new System.Drawing.Size(108, 20);
            this.userName_TB.TabIndex = 1;
            // 
            // newPassword_TB
            // 
            this.newPassword_TB.Location = new System.Drawing.Point(16, 80);
            this.newPassword_TB.Name = "newPassword_TB";
            this.newPassword_TB.PasswordChar = '*';
            this.newPassword_TB.Size = new System.Drawing.Size(108, 20);
            this.newPassword_TB.TabIndex = 2;
            // 
            // newPassword_Label
            // 
            this.newPassword_Label.AutoSize = true;
            this.newPassword_Label.Location = new System.Drawing.Point(13, 63);
            this.newPassword_Label.Name = "newPassword_Label";
            this.newPassword_Label.Size = new System.Drawing.Size(48, 13);
            this.newPassword_Label.TabIndex = 3;
            this.newPassword_Label.Text = "Парола:";
            // 
            // addNewUser_Button
            // 
            this.addNewUser_Button.Location = new System.Drawing.Point(258, 27);
            this.addNewUser_Button.Name = "addNewUser_Button";
            this.addNewUser_Button.Size = new System.Drawing.Size(75, 23);
            this.addNewUser_Button.TabIndex = 4;
            this.addNewUser_Button.Text = "Добави";
            this.addNewUser_Button.UseVisualStyleBackColor = true;
            this.addNewUser_Button.Click += new System.EventHandler(this.addNewUser_Button_Click);
            // 
            // addUserCancel_Button
            // 
            this.addUserCancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addUserCancel_Button.Location = new System.Drawing.Point(258, 77);
            this.addUserCancel_Button.Name = "addUserCancel_Button";
            this.addUserCancel_Button.Size = new System.Drawing.Size(75, 23);
            this.addUserCancel_Button.TabIndex = 5;
            this.addUserCancel_Button.Text = "Затвори";
            this.addUserCancel_Button.UseVisualStyleBackColor = true;
            this.addUserCancel_Button.Click += new System.EventHandler(this.addUserCancel_Button_Click);
            // 
            // accessToken_Label
            // 
            this.accessToken_Label.AutoSize = true;
            this.accessToken_Label.Location = new System.Drawing.Point(13, 111);
            this.accessToken_Label.Name = "accessToken_Label";
            this.accessToken_Label.Size = new System.Drawing.Size(90, 13);
            this.accessToken_Label.TabIndex = 6;
            this.accessToken_Label.Text = "Ниво на достъп:";
            // 
            // accessToken_ComboBox
            // 
            this.accessToken_ComboBox.FormattingEnabled = true;
            this.accessToken_ComboBox.Items.AddRange(new object[] {
            "Собственик",
            "Администратор",
            "Потребител"});
            this.accessToken_ComboBox.Location = new System.Drawing.Point(16, 128);
            this.accessToken_ComboBox.Name = "accessToken_ComboBox";
            this.accessToken_ComboBox.Size = new System.Drawing.Size(108, 21);
            this.accessToken_ComboBox.TabIndex = 7;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addUserCancel_Button;
            this.ClientSize = new System.Drawing.Size(353, 167);
            this.ControlBox = false;
            this.Controls.Add(this.accessToken_ComboBox);
            this.Controls.Add(this.accessToken_Label);
            this.Controls.Add(this.addUserCancel_Button);
            this.Controls.Add(this.addNewUser_Button);
            this.Controls.Add(this.newPassword_Label);
            this.Controls.Add(this.newPassword_TB);
            this.Controls.Add(this.userName_TB);
            this.Controls.Add(this.addUser_Label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 206);
            this.MinimumSize = new System.Drawing.Size(369, 206);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Създаване на нов потребител";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addUser_Label;
        private System.Windows.Forms.TextBox userName_TB;
        private System.Windows.Forms.TextBox newPassword_TB;
        private System.Windows.Forms.Label newPassword_Label;
        private System.Windows.Forms.Button addNewUser_Button;
        private System.Windows.Forms.Button addUserCancel_Button;
        private System.Windows.Forms.Label accessToken_Label;
        private System.Windows.Forms.ComboBox accessToken_ComboBox;
    }
}