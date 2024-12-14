namespace RestaurantManagement
{
    partial class FormCauHinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.comboBoxTenServer = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxTenServer);
            this.panel1.Controls.Add(this.comboBoxDatabase);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.textBoxMatKhau);
            this.panel1.Controls.Add(this.textBoxTaiKhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 337);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(178, 195);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(237, 28);
            this.comboBoxDatabase.TabIndex = 4;
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(178, 91);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(237, 26);
            this.textBoxTaiKhoan.TabIndex = 2;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(178, 143);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(237, 26);
            this.textBoxMatKhau.TabIndex = 3;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(178, 240);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(109, 51);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(306, 240);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(109, 51);
            this.buttonHuy.TabIndex = 6;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // comboBoxTenServer
            // 
            this.comboBoxTenServer.FormattingEnabled = true;
            this.comboBoxTenServer.Location = new System.Drawing.Point(178, 41);
            this.comboBoxTenServer.Name = "comboBoxTenServer";
            this.comboBoxTenServer.Size = new System.Drawing.Size(237, 28);
            this.comboBoxTenServer.TabIndex = 1;
            // 
            // FormCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCauHinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTenServer;
    }
}