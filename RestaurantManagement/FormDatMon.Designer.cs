namespace RestaurantManagement
{
    partial class FormDatMon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBan = new System.Windows.Forms.TabPage();
            this.tabPageThucDon = new System.Windows.Forms.TabPage();
            this.groupBoxDatMon = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.listViewDonMon = new System.Windows.Forms.ListView();
            this.buttonInHoaDon = new System.Windows.Forms.Button();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonThongBao = new System.Windows.Forms.Button();
            this.tableLayoutPanelBan = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxNotify = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBan.SuspendLayout();
            this.groupBoxDatMon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBan);
            this.tabControl1.Controls.Add(this.tabPageThucDon);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBan
            // 
            this.tabPageBan.Controls.Add(this.tableLayoutPanelBan);
            this.tabPageBan.Location = new System.Drawing.Point(4, 29);
            this.tabPageBan.Name = "tabPageBan";
            this.tabPageBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBan.Size = new System.Drawing.Size(560, 567);
            this.tabPageBan.TabIndex = 0;
            this.tabPageBan.Text = "Bàn";
            this.tabPageBan.UseVisualStyleBackColor = true;
            // 
            // tabPageThucDon
            // 
            this.tabPageThucDon.Location = new System.Drawing.Point(4, 29);
            this.tabPageThucDon.Name = "tabPageThucDon";
            this.tabPageThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThucDon.Size = new System.Drawing.Size(815, 567);
            this.tabPageThucDon.TabIndex = 1;
            this.tabPageThucDon.Text = "Thực đơn";
            this.tabPageThucDon.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatMon
            // 
            this.groupBoxDatMon.Controls.Add(this.buttonThongBao);
            this.groupBoxDatMon.Controls.Add(this.buttonThanhToan);
            this.groupBoxDatMon.Controls.Add(this.buttonInHoaDon);
            this.groupBoxDatMon.Controls.Add(this.listViewDonMon);
            this.groupBoxDatMon.Controls.Add(this.buttonThemMon);
            this.groupBoxDatMon.Controls.Add(this.panel1);
            this.groupBoxDatMon.Location = new System.Drawing.Point(841, 75);
            this.groupBoxDatMon.Name = "groupBoxDatMon";
            this.groupBoxDatMon.Size = new System.Drawing.Size(616, 571);
            this.groupBoxDatMon.TabIndex = 1;
            this.groupBoxDatMon.TabStop = false;
            this.groupBoxDatMon.Text = "Đặt món";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDonGia);
            this.panel1.Controls.Add(this.nudSoLuong);
            this.panel1.Controls.Add(this.lblThanhTien);
            this.panel1.Controls.Add(this.lblTenMon);
            this.panel1.Location = new System.Drawing.Point(19, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(21, 29);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(47, 20);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Pizza";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(487, 29);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(31, 20);
            this.lblThanhTien.TabIndex = 1;
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuong.Location = new System.Drawing.Point(158, 27);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(77, 26);
            this.nudSoLuong.TabIndex = 2;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDonGia.Location = new System.Drawing.Point(254, 26);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.ReadOnly = true;
            this.textBoxDonGia.Size = new System.Drawing.Size(154, 26);
            this.textBoxDonGia.TabIndex = 3;
            this.textBoxDonGia.Text = "0";
            this.textBoxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.Location = new System.Drawing.Point(426, 135);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(155, 38);
            this.buttonThemMon.TabIndex = 1;
            this.buttonThemMon.Text = "Thêm món";
            this.buttonThemMon.UseVisualStyleBackColor = true;
            // 
            // listViewDonMon
            // 
            this.listViewDonMon.HideSelection = false;
            this.listViewDonMon.Location = new System.Drawing.Point(19, 179);
            this.listViewDonMon.Name = "listViewDonMon";
            this.listViewDonMon.Size = new System.Drawing.Size(562, 270);
            this.listViewDonMon.TabIndex = 2;
            this.listViewDonMon.UseCompatibleStateImageBehavior = false;
            // 
            // buttonInHoaDon
            // 
            this.buttonInHoaDon.Location = new System.Drawing.Point(19, 492);
            this.buttonInHoaDon.Name = "buttonInHoaDon";
            this.buttonInHoaDon.Size = new System.Drawing.Size(166, 64);
            this.buttonInHoaDon.TabIndex = 3;
            this.buttonInHoaDon.Text = "In hóa đơn";
            this.buttonInHoaDon.UseVisualStyleBackColor = true;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(220, 492);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(166, 64);
            this.buttonThanhToan.TabIndex = 3;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            // 
            // buttonThongBao
            // 
            this.buttonThongBao.Location = new System.Drawing.Point(415, 492);
            this.buttonThongBao.Name = "buttonThongBao";
            this.buttonThongBao.Size = new System.Drawing.Size(166, 64);
            this.buttonThongBao.TabIndex = 3;
            this.buttonThongBao.Text = "Thông báo";
            this.buttonThongBao.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBan
            // 
            this.tableLayoutPanelBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelBan.ColumnCount = 2;
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBan.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanelBan.Name = "tableLayoutPanelBan";
            this.tableLayoutPanelBan.RowCount = 2;
            this.tableLayoutPanelBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBan.Size = new System.Drawing.Size(547, 554);
            this.tableLayoutPanelBan.TabIndex = 0;
            // 
            // pictureBoxNotify
            // 
            this.pictureBoxNotify.Image = global::RestaurantManagement.Properties.Resources.notification;
            this.pictureBoxNotify.Location = new System.Drawing.Point(1390, 37);
            this.pictureBoxNotify.Name = "pictureBoxNotify";
            this.pictureBoxNotify.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNotify.TabIndex = 2;
            this.pictureBoxNotify.TabStop = false;
            // 
            // FormDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 684);
            this.Controls.Add(this.pictureBoxNotify);
            this.Controls.Add(this.groupBoxDatMon);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatMon";
            this.Text = "FormDatMon";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBan.ResumeLayout(false);
            this.groupBoxDatMon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBan;
        private System.Windows.Forms.TabPage tabPageThucDon;
        private System.Windows.Forms.GroupBox groupBoxDatMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.ListView listViewDonMon;
        private System.Windows.Forms.Button buttonInHoaDon;
        private System.Windows.Forms.Button buttonThongBao;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.PictureBox pictureBoxNotify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBan;
    }
}