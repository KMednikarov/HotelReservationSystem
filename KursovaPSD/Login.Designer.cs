namespace KursovaPSD
{
    partial class Login
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
            this.login_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.userName_Label = new System.Windows.Forms.Label();
            this.pwd_Label = new System.Windows.Forms.Label();
            this.userName_TB = new System.Windows.Forms.TextBox();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.invalidUserPwd_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(199, 32);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Вход";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(199, 81);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 3;
            this.cancel_Button.Text = "Отказ";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(18, 18);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(108, 13);
            this.userName_Label.TabIndex = 2;
            this.userName_Label.Text = "Потребителско име";
            // 
            // pwd_Label
            // 
            this.pwd_Label.AutoSize = true;
            this.pwd_Label.Location = new System.Drawing.Point(18, 67);
            this.pwd_Label.Name = "pwd_Label";
            this.pwd_Label.Size = new System.Drawing.Size(45, 13);
            this.pwd_Label.TabIndex = 3;
            this.pwd_Label.Text = "Парола";
            // 
            // userName_TB
            // 
            this.userName_TB.Location = new System.Drawing.Point(26, 34);
            this.userName_TB.Name = "userName_TB";
            this.userName_TB.Size = new System.Drawing.Size(100, 20);
            this.userName_TB.TabIndex = 0;
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(26, 83);
            this.password_TB.Name = "password_TB";
            this.password_TB.PasswordChar = '*';
            this.password_TB.Size = new System.Drawing.Size(100, 20);
            this.password_TB.TabIndex = 1;
            // 
            // invalidUserPwd_Label
            // 
            this.invalidUserPwd_Label.AutoSize = true;
            this.invalidUserPwd_Label.ForeColor = System.Drawing.Color.Red;
            this.invalidUserPwd_Label.Location = new System.Drawing.Point(12, 106);
            this.invalidUserPwd_Label.Name = "invalidUserPwd_Label";
            this.invalidUserPwd_Label.Size = new System.Drawing.Size(169, 13);
            this.invalidUserPwd_Label.TabIndex = 4;
            this.invalidUserPwd_Label.Text = "Грешен потребител или парола.";
            this.invalidUserPwd_Label.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Button;
            this.ClientSize = new System.Drawing.Size(297, 151);
            this.ControlBox = false;
            this.Controls.Add(this.invalidUserPwd_Label);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.userName_TB);
            this.Controls.Add(this.pwd_Label);
            this.Controls.Add(this.userName_Label);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.login_Button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 190);
            this.MinimumSize = new System.Drawing.Size(313, 190);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Влизане в системата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Label pwd_Label;
        private System.Windows.Forms.TextBox userName_TB;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label invalidUserPwd_Label;
    }
}