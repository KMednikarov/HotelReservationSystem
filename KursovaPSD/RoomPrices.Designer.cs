namespace KursovaPSD
{
    partial class RoomPrices
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
            this.label3 = new System.Windows.Forms.Label();
            this.appPrice_TB = new System.Windows.Forms.TextBox();
            this.dblPrice_TB = new System.Windows.Forms.TextBox();
            this.dbl2Price_TB = new System.Windows.Forms.TextBox();
            this.sglPrice_TB = new System.Windows.Forms.TextBox();
            this.pthPrice_TB = new System.Windows.Forms.TextBox();
            this.ok_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 117);
            this.label3.TabIndex = 17;
            this.label3.Text = "APP\r\n\r\nDBL\r\n\r\nDBL+ \r\n\r\nSGL\r\n\r\nPTH ";
            // 
            // appPrice_TB
            // 
            this.appPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appPrice_TB.Location = new System.Drawing.Point(49, 13);
            this.appPrice_TB.Name = "appPrice_TB";
            this.appPrice_TB.ReadOnly = true;
            this.appPrice_TB.Size = new System.Drawing.Size(44, 20);
            this.appPrice_TB.TabIndex = 18;
            this.appPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dblPrice_TB
            // 
            this.dblPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dblPrice_TB.Location = new System.Drawing.Point(49, 39);
            this.dblPrice_TB.Name = "dblPrice_TB";
            this.dblPrice_TB.ReadOnly = true;
            this.dblPrice_TB.Size = new System.Drawing.Size(44, 20);
            this.dblPrice_TB.TabIndex = 19;
            this.dblPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbl2Price_TB
            // 
            this.dbl2Price_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbl2Price_TB.Location = new System.Drawing.Point(49, 65);
            this.dbl2Price_TB.Name = "dbl2Price_TB";
            this.dbl2Price_TB.ReadOnly = true;
            this.dbl2Price_TB.Size = new System.Drawing.Size(44, 20);
            this.dbl2Price_TB.TabIndex = 20;
            this.dbl2Price_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sglPrice_TB
            // 
            this.sglPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sglPrice_TB.Location = new System.Drawing.Point(49, 91);
            this.sglPrice_TB.Name = "sglPrice_TB";
            this.sglPrice_TB.ReadOnly = true;
            this.sglPrice_TB.Size = new System.Drawing.Size(44, 20);
            this.sglPrice_TB.TabIndex = 21;
            this.sglPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pthPrice_TB
            // 
            this.pthPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pthPrice_TB.Location = new System.Drawing.Point(49, 117);
            this.pthPrice_TB.Name = "pthPrice_TB";
            this.pthPrice_TB.ReadOnly = true;
            this.pthPrice_TB.Size = new System.Drawing.Size(44, 20);
            this.pthPrice_TB.TabIndex = 22;
            this.pthPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ok_Button
            // 
            this.ok_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ok_Button.Location = new System.Drawing.Point(12, 160);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(139, 23);
            this.ok_Button.TabIndex = 23;
            this.ok_Button.Text = "Затвори";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.appPrice_TB);
            this.groupBox1.Controls.Add(this.pthPrice_TB);
            this.groupBox1.Controls.Add(this.dblPrice_TB);
            this.groupBox1.Controls.Add(this.sglPrice_TB);
            this.groupBox1.Controls.Add(this.dbl2Price_TB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 142);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ценоразпис";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 117);
            this.label1.TabIndex = 23;
            this.label1.Text = "лв.\r\n\r\nлв.\r\n\r\nлв.\r\n\r\nлв.\r\n\r\nлв.";
            // 
            // RoomPrices
            // 
            this.AcceptButton = this.ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ok_Button;
            this.ClientSize = new System.Drawing.Size(163, 191);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok_Button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(179, 230);
            this.MinimumSize = new System.Drawing.Size(179, 230);
            this.Name = "RoomPrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ценоразпис";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appPrice_TB;
        private System.Windows.Forms.TextBox dblPrice_TB;
        private System.Windows.Forms.TextBox dbl2Price_TB;
        private System.Windows.Forms.TextBox sglPrice_TB;
        private System.Windows.Forms.TextBox pthPrice_TB;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

    }
}