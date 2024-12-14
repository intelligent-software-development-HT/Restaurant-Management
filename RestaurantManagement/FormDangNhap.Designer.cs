namespace RestaurantManagement
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(24, 58);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(281, 26);
            this.textBoxTenDangNhap.TabIndex = 1;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(24, 133);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(281, 26);
            this.textBoxMatKhau.TabIndex = 2;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.textBoxTenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMatKhau);
            this.panel1.Location = new System.Drawing.Point(169, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 243);
            this.panel1.TabIndex = 4;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(24, 177);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(139, 38);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Đổi server";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 422);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDangNhap;
    }
}