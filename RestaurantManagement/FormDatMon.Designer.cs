using System.Drawing;

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
            this.tableLayoutPanelBan = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageThucDon = new System.Windows.Forms.TabPage();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.flowLayoutPanelLoaiMon = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMon = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDatMon = new System.Windows.Forms.GroupBox();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonInHoaDon = new System.Windows.Forms.Button();
            this.listViewDonMon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelThongTinDatMon = new System.Windows.Forms.Panel();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.buttonKiemTraDatBan = new System.Windows.Forms.Button();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.pictureBoxNotify = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBan.SuspendLayout();
            this.tabPageThucDon.SuspendLayout();
            this.groupBoxDatMon.SuspendLayout();
            this.panelThongTinDatMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBan);
            this.tabControl1.Controls.Add(this.tabPageThucDon);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 991);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBan
            // 
            this.tabPageBan.Controls.Add(this.tableLayoutPanelBan);
            this.tabPageBan.Location = new System.Drawing.Point(4, 44);
            this.tabPageBan.Name = "tabPageBan";
            this.tabPageBan.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageBan.Size = new System.Drawing.Size(738, 943);
            this.tabPageBan.TabIndex = 0;
            this.tabPageBan.Text = "Bàn";
            this.tabPageBan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBan
            // 
            this.tableLayoutPanelBan.AutoScroll = true;
            this.tableLayoutPanelBan.AutoSize = true;
            this.tableLayoutPanelBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelBan.ColumnCount = 4;
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBan.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBan.Name = "tableLayoutPanelBan";
            this.tableLayoutPanelBan.RowCount = 1;
            this.tableLayoutPanelBan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBan.Size = new System.Drawing.Size(732, 937);
            this.tableLayoutPanelBan.TabIndex = 0;
            // 
            // tabPageThucDon
            // 
            this.tabPageThucDon.Controls.Add(this.hScrollBar2);
            this.tabPageThucDon.Controls.Add(this.flowLayoutPanelLoaiMon);
            this.tabPageThucDon.Controls.Add(this.tableLayoutPanelMon);
            this.tabPageThucDon.Location = new System.Drawing.Point(4, 44);
            this.tabPageThucDon.Name = "tabPageThucDon";
            this.tabPageThucDon.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageThucDon.Size = new System.Drawing.Size(738, 943);
            this.tabPageThucDon.TabIndex = 1;
            this.tabPageThucDon.Text = "Thực đơn";
            this.tabPageThucDon.UseVisualStyleBackColor = true;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(9, 82);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(722, 16);
            this.hScrollBar2.TabIndex = 2;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // flowLayoutPanelLoaiMon
            // 
            this.flowLayoutPanelLoaiMon.AutoScroll = true;
            this.flowLayoutPanelLoaiMon.ForeColor = System.Drawing.Color.Teal;
            this.flowLayoutPanelLoaiMon.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanelLoaiMon.Name = "flowLayoutPanelLoaiMon";
            this.flowLayoutPanelLoaiMon.Size = new System.Drawing.Size(724, 65);
            this.flowLayoutPanelLoaiMon.TabIndex = 1;
            // 
            // tableLayoutPanelMon
            // 
            this.tableLayoutPanelMon.ColumnCount = 2;
            this.tableLayoutPanelMon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.ForeColor = System.Drawing.Color.Teal;
            this.tableLayoutPanelMon.Location = new System.Drawing.Point(8, 109);
            this.tableLayoutPanelMon.Name = "tableLayoutPanelMon";
            this.tableLayoutPanelMon.RowCount = 2;
            this.tableLayoutPanelMon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.Size = new System.Drawing.Size(724, 617);
            this.tableLayoutPanelMon.TabIndex = 0;
            // 
            // groupBoxDatMon
            // 
            this.groupBoxDatMon.Controls.Add(this.buttonThemMon);
            this.groupBoxDatMon.Controls.Add(this.textBoxTongTien);
            this.groupBoxDatMon.Controls.Add(this.label1);
            this.groupBoxDatMon.Controls.Add(this.buttonThanhToan);
            this.groupBoxDatMon.Controls.Add(this.buttonInHoaDon);
            this.groupBoxDatMon.Controls.Add(this.listViewDonMon);
            this.groupBoxDatMon.Controls.Add(this.panelThongTinDatMon);
            this.groupBoxDatMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatMon.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxDatMon.Location = new System.Drawing.Point(764, 78);
            this.groupBoxDatMon.Name = "groupBoxDatMon";
            this.groupBoxDatMon.Size = new System.Drawing.Size(722, 951);
            this.groupBoxDatMon.TabIndex = 1;
            this.groupBoxDatMon.TabStop = false;
            this.groupBoxDatMon.Text = "Đặt món";
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.BackColor = System.Drawing.Color.Teal;
            this.buttonThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemMon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonThemMon.Location = new System.Drawing.Point(465, 103);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(255, 58);
            this.buttonThemMon.TabIndex = 8;
            this.buttonThemMon.Text = "Thêm món";
            this.buttonThemMon.UseVisualStyleBackColor = false;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTongTien.Enabled = false;
            this.textBoxTongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.Location = new System.Drawing.Point(549, 838);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(166, 35);
            this.textBoxTongTien.TabIndex = 5;
            this.textBoxTongTien.Text = "0";
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 838);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền";
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.Teal;
            this.buttonThanhToan.Enabled = false;
            this.buttonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThanhToan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonThanhToan.Location = new System.Drawing.Point(450, 880);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(266, 62);
            this.buttonThanhToan.TabIndex = 6;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            // 
            // buttonInHoaDon
            // 
            this.buttonInHoaDon.BackColor = System.Drawing.Color.Teal;
            this.buttonInHoaDon.Enabled = false;
            this.buttonInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInHoaDon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonInHoaDon.Location = new System.Drawing.Point(174, 880);
            this.buttonInHoaDon.Name = "buttonInHoaDon";
            this.buttonInHoaDon.Size = new System.Drawing.Size(270, 62);
            this.buttonInHoaDon.TabIndex = 7;
            this.buttonInHoaDon.Text = "In hóa đơn";
            this.buttonInHoaDon.UseVisualStyleBackColor = false;
            // 
            // listViewDonMon
            // 
            this.listViewDonMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDonMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDonMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDonMon.ForeColor = System.Drawing.Color.Teal;
            this.listViewDonMon.GridLines = true;
            this.listViewDonMon.HideSelection = false;
            this.listViewDonMon.Location = new System.Drawing.Point(20, 178);
            this.listViewDonMon.Name = "listViewDonMon";
            this.listViewDonMon.Size = new System.Drawing.Size(682, 657);
            this.listViewDonMon.TabIndex = 2;
            this.listViewDonMon.UseCompatibleStateImageBehavior = false;
            this.listViewDonMon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // panelThongTinDatMon
            // 
            this.panelThongTinDatMon.Controls.Add(this.textBoxDonGia);
            this.panelThongTinDatMon.Controls.Add(this.nudSoLuong);
            this.panelThongTinDatMon.Controls.Add(this.lblThanhTien);
            this.panelThongTinDatMon.Controls.Add(this.lblTenMon);
            this.panelThongTinDatMon.Location = new System.Drawing.Point(6, 37);
            this.panelThongTinDatMon.Name = "panelThongTinDatMon";
            this.panelThongTinDatMon.Size = new System.Drawing.Size(710, 60);
            this.panelThongTinDatMon.TabIndex = 0;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDonGia.Enabled = false;
            this.textBoxDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonGia.ForeColor = System.Drawing.Color.Teal;
            this.textBoxDonGia.Location = new System.Drawing.Point(376, 15);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.ReadOnly = true;
            this.textBoxDonGia.Size = new System.Drawing.Size(110, 29);
            this.textBoxDonGia.TabIndex = 3;
            this.textBoxDonGia.Text = "0";
            this.textBoxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.nudSoLuong.Location = new System.Drawing.Point(207, 11);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(105, 32);
            this.nudSoLuong.TabIndex = 2;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.Teal;
            this.lblThanhTien.Location = new System.Drawing.Point(645, 17);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(50, 29);
            this.lblThanhTien.TabIndex = 1;
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.ForeColor = System.Drawing.Color.Teal;
            this.lblTenMon.Location = new System.Drawing.Point(9, 17);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(76, 29);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Pizza";
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDangNhap.ForeColor = System.Drawing.Color.Teal;
            this.labelTenDangNhap.Location = new System.Drawing.Point(1320, 38);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(74, 29);
            this.labelTenDangNhap.TabIndex = 3;
            this.labelTenDangNhap.Text = "Hello";
            // 
            // buttonKiemTraDatBan
            // 
            this.buttonKiemTraDatBan.BackColor = System.Drawing.Color.Teal;
            this.buttonKiemTraDatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKiemTraDatBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKiemTraDatBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonKiemTraDatBan.Location = new System.Drawing.Point(770, 17);
            this.buttonKiemTraDatBan.Name = "buttonKiemTraDatBan";
            this.buttonKiemTraDatBan.Size = new System.Drawing.Size(312, 42);
            this.buttonKiemTraDatBan.TabIndex = 4;
            this.buttonKiemTraDatBan.Text = "Kiểm tra đặt bàn";
            this.buttonKiemTraDatBan.UseVisualStyleBackColor = false;
            // 
            // labelThongBao
            // 
            this.labelThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Image = global::RestaurantManagement.Properties.Resources.circle__2_;
            this.labelThongBao.Location = new System.Drawing.Point(1158, 17);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(32, 32);
            this.labelThongBao.TabIndex = 6;
            this.labelThongBao.Text = "0";
            this.labelThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNotify
            // 
            this.pictureBoxNotify.Image = global::RestaurantManagement.Properties.Resources.notification;
            this.pictureBoxNotify.Location = new System.Drawing.Point(1146, 38);
            this.pictureBoxNotify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNotify.Name = "pictureBoxNotify";
            this.pictureBoxNotify.Size = new System.Drawing.Size(24, 25);
            this.pictureBoxNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotify.TabIndex = 2;
            this.pictureBoxNotify.TabStop = false;
            // 
            // FormDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1046);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.buttonKiemTraDatBan);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.pictureBoxNotify);
            this.Controls.Add(this.groupBoxDatMon);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(26)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatMon";
            this.Text = "FormDatMon";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBan.ResumeLayout(false);
            this.tabPageBan.PerformLayout();
            this.tabPageThucDon.ResumeLayout(false);
            this.groupBoxDatMon.ResumeLayout(false);
            this.groupBoxDatMon.PerformLayout();
            this.panelThongTinDatMon.ResumeLayout(false);
            this.panelThongTinDatMon.PerformLayout();
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
        private System.Windows.Forms.Panel panelThongTinDatMon;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.ListView listViewDonMon;
        private System.Windows.Forms.Button buttonInHoaDon;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.PictureBox pictureBoxNotify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLoaiMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMon;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        //private System.Windows.Forms.Button buttonInHoaDon;
        //private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button buttonKiemTraDatBan;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.HScrollBar hScrollBar2;
    }
}