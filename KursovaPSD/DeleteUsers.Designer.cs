namespace KursovaPSD
{
    partial class DeleteUsers
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
            this.users_DGV = new System.Windows.Forms.DataGridView();
            this.delete_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessTokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.users_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // users_DGV
            // 
            this.users_DGV.AllowUserToAddRows = false;
            this.users_DGV.AllowUserToResizeColumns = false;
            this.users_DGV.AutoGenerateColumns = false;
            this.users_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.users_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.accessTokenDataGridViewTextBoxColumn});
            this.users_DGV.DataSource = this.userBindingSource;
            this.users_DGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.users_DGV.Location = new System.Drawing.Point(0, 0);
            this.users_DGV.Name = "users_DGV";
            this.users_DGV.ReadOnly = true;
            this.users_DGV.Size = new System.Drawing.Size(320, 153);
            this.users_DGV.TabIndex = 0;
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(29, 159);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(75, 23);
            this.delete_Button.TabIndex = 1;
            this.delete_Button.Text = "Изтрий";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(206, 159);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 2;
            this.close_Button.Text = "Затвори";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Потребител";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Парола";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // accessTokenDataGridViewTextBoxColumn
            // 
            this.accessTokenDataGridViewTextBoxColumn.DataPropertyName = "AccessToken";
            this.accessTokenDataGridViewTextBoxColumn.HeaderText = "Ниво на достъп";
            this.accessTokenDataGridViewTextBoxColumn.Name = "accessTokenDataGridViewTextBoxColumn";
            this.accessTokenDataGridViewTextBoxColumn.ReadOnly = true;
            this.accessTokenDataGridViewTextBoxColumn.Width = 98;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(KursovaPSD.User);
            // 
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(320, 191);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.users_DGV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 230);
            this.MinimumSize = new System.Drawing.Size(336, 230);
            this.Name = "DeleteUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUsers";
            ((System.ComponentModel.ISupportInitialize)(this.users_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView users_DGV;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessTokenDataGridViewTextBoxColumn;
    }
}