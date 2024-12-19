namespace RestaurantManagement
{
    partial class FormGopBan
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
            this.checkedListBoxBanGop = new System.Windows.Forms.CheckedListBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.buttonBoQua = new System.Windows.Forms.Button();
            this.buttonThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxBanGop
            // 
            this.checkedListBoxBanGop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxBanGop.FormattingEnabled = true;
            this.checkedListBoxBanGop.Location = new System.Drawing.Point(12, 70);
            this.checkedListBoxBanGop.Name = "checkedListBoxBanGop";
            this.checkedListBoxBanGop.Size = new System.Drawing.Size(771, 186);
            this.checkedListBoxBanGop.TabIndex = 0;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(12, 9);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(51, 20);
            this.lblTenBan.TabIndex = 1;
            this.lblTenBan.Text = "label1";
            // 
            // buttonBoQua
            // 
            this.buttonBoQua.Location = new System.Drawing.Point(600, 262);
            this.buttonBoQua.Name = "buttonBoQua";
            this.buttonBoQua.Size = new System.Drawing.Size(183, 54);
            this.buttonBoQua.TabIndex = 2;
            this.buttonBoQua.Text = "Bỏ qua";
            this.buttonBoQua.UseVisualStyleBackColor = true;
            // 
            // buttonThucHien
            // 
            this.buttonThucHien.Location = new System.Drawing.Point(411, 262);
            this.buttonThucHien.Name = "buttonThucHien";
            this.buttonThucHien.Size = new System.Drawing.Size(183, 54);
            this.buttonThucHien.TabIndex = 2;
            this.buttonThucHien.Text = "Thực hiện";
            this.buttonThucHien.UseVisualStyleBackColor = true;
            // 
            // FormGopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 332);
            this.Controls.Add(this.buttonThucHien);
            this.Controls.Add(this.buttonBoQua);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.checkedListBoxBanGop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormGopBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGopBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxBanGop;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Button buttonBoQua;
        private System.Windows.Forms.Button buttonThucHien;
    }
}