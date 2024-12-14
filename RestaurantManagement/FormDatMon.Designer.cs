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
            this.flowLayoutPanelLoaiMon = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMon = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDatMon = new System.Windows.Forms.GroupBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.buttonTachBan = new System.Windows.Forms.Button();
            this.buttonGopBan = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 775);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBan
            // 
            this.tabPageBan.Controls.Add(this.tableLayoutPanelBan);
            this.tabPageBan.Location = new System.Drawing.Point(4, 29);
            this.tabPageBan.Name = "tabPageBan";
            this.tabPageBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBan.Size = new System.Drawing.Size(737, 742);
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
            this.tableLayoutPanelBan.Size = new System.Drawing.Size(731, 736);
            this.tableLayoutPanelBan.TabIndex = 0;
            // 
            // tabPageThucDon
            // 
            this.tabPageThucDon.Controls.Add(this.flowLayoutPanelLoaiMon);
            this.tabPageThucDon.Controls.Add(this.tableLayoutPanelMon);
            this.tabPageThucDon.Location = new System.Drawing.Point(4, 29);
            this.tabPageThucDon.Name = "tabPageThucDon";
            this.tabPageThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThucDon.Size = new System.Drawing.Size(737, 742);
            this.tabPageThucDon.TabIndex = 1;
            this.tabPageThucDon.Text = "Thực đơn";
            this.tabPageThucDon.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelLoaiMon
            // 
            this.flowLayoutPanelLoaiMon.AutoScroll = true;
            this.flowLayoutPanelLoaiMon.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanelLoaiMon.Name = "flowLayoutPanelLoaiMon";
            this.flowLayoutPanelLoaiMon.Size = new System.Drawing.Size(724, 49);
            this.flowLayoutPanelLoaiMon.TabIndex = 1;
            // 
            // tableLayoutPanelMon
            // 
            this.tableLayoutPanelMon.ColumnCount = 2;
            this.tableLayoutPanelMon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.Location = new System.Drawing.Point(7, 62);
            this.tableLayoutPanelMon.Name = "tableLayoutPanelMon";
            this.tableLayoutPanelMon.RowCount = 2;
            this.tableLayoutPanelMon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMon.Size = new System.Drawing.Size(724, 664);
            this.tableLayoutPanelMon.TabIndex = 0;
            // 
            // groupBoxDatMon
            // 
            this.groupBoxDatMon.Controls.Add(this.textBoxTongTien);
            this.groupBoxDatMon.Controls.Add(this.label1);
            this.groupBoxDatMon.Controls.Add(this.buttonThemMon);
            this.groupBoxDatMon.Controls.Add(this.buttonTachBan);
            this.groupBoxDatMon.Controls.Add(this.buttonGopBan);
            this.groupBoxDatMon.Controls.Add(this.buttonThanhToan);
            this.groupBoxDatMon.Controls.Add(this.buttonInHoaDon);
            this.groupBoxDatMon.Controls.Add(this.listViewDonMon);
            this.groupBoxDatMon.Controls.Add(this.panelThongTinDatMon);
            this.groupBoxDatMon.Location = new System.Drawing.Point(763, 78);
            this.groupBoxDatMon.Name = "groupBoxDatMon";
            this.groupBoxDatMon.Size = new System.Drawing.Size(721, 736);
            this.groupBoxDatMon.TabIndex = 1;
            this.groupBoxDatMon.TabStop = false;
            this.groupBoxDatMon.Text = "Đặt món";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTongTien.Enabled = false;
            this.textBoxTongTien.Location = new System.Drawing.Point(535, 615);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(166, 19);
            this.textBoxTongTien.TabIndex = 5;
            this.textBoxTongTien.Text = "0";
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền";
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.Location = new System.Drawing.Point(535, 103);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(166, 64);
            this.buttonThemMon.TabIndex = 3;
            this.buttonThemMon.Text = "Thêm món";
            this.buttonThemMon.UseVisualStyleBackColor = true;
            // 
            // buttonTachBan
            // 
            this.buttonTachBan.Location = new System.Drawing.Point(19, 665);
            this.buttonTachBan.Name = "buttonTachBan";
            this.buttonTachBan.Size = new System.Drawing.Size(166, 64);
            this.buttonTachBan.TabIndex = 3;
            this.buttonTachBan.Text = "Tách bàn";
            this.buttonTachBan.UseVisualStyleBackColor = true;
            // 
            // buttonGopBan
            // 
            this.buttonGopBan.Location = new System.Drawing.Point(191, 665);
            this.buttonGopBan.Name = "buttonGopBan";
            this.buttonGopBan.Size = new System.Drawing.Size(166, 64);
            this.buttonGopBan.TabIndex = 3;
            this.buttonGopBan.Text = "Gộp bàn";
            this.buttonGopBan.UseVisualStyleBackColor = true;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(0, 0);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(75, 23);
            this.buttonThanhToan.TabIndex = 6;
            // 
            // buttonInHoaDon
            // 
            this.buttonInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.buttonInHoaDon.Name = "buttonInHoaDon";
            this.buttonInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.buttonInHoaDon.TabIndex = 7;
            // 
            // listViewDonMon
            // 
            this.listViewDonMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDonMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDonMon.GridLines = true;
            this.listViewDonMon.HideSelection = false;
            this.listViewDonMon.HoverSelection = true;
            this.listViewDonMon.Location = new System.Drawing.Point(19, 179);
            this.listViewDonMon.Name = "listViewDonMon";
            this.listViewDonMon.Size = new System.Drawing.Size(682, 416);
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
            this.panelThongTinDatMon.Location = new System.Drawing.Point(6, 47);
            this.panelThongTinDatMon.Name = "panelThongTinDatMon";
            this.panelThongTinDatMon.Size = new System.Drawing.Size(709, 50);
            this.panelThongTinDatMon.TabIndex = 0;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDonGia.Enabled = false;
            this.textBoxDonGia.Location = new System.Drawing.Point(436, 14);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.ReadOnly = true;
            this.textBoxDonGia.Size = new System.Drawing.Size(109, 19);
            this.textBoxDonGia.TabIndex = 3;
            this.textBoxDonGia.Text = "0";
            this.textBoxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSoLuong.Location = new System.Drawing.Point(265, 13);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(77, 22);
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
            this.lblThanhTien.Location = new System.Drawing.Point(651, 14);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(31, 20);
            this.lblThanhTien.TabIndex = 1;
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(9, 14);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(47, 20);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Pizza";
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Location = new System.Drawing.Point(1320, 38);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(45, 20);
            this.labelTenDangNhap.TabIndex = 3;
            this.labelTenDangNhap.Text = "Hello";
            // 
            // buttonKiemTraDatBan
            // 
            this.buttonKiemTraDatBan.Location = new System.Drawing.Point(954, 26);
            this.buttonKiemTraDatBan.Name = "buttonKiemTraDatBan";
            this.buttonKiemTraDatBan.Size = new System.Drawing.Size(167, 46);
            this.buttonKiemTraDatBan.TabIndex = 4;
            this.buttonKiemTraDatBan.Text = "Kiểm tra đặt bàn";
            this.buttonKiemTraDatBan.UseVisualStyleBackColor = true;
            // 
            // labelThongBao
            // 
            this.labelThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Image = global::RestaurantManagement.Properties.Resources.circle__2_;
            this.labelThongBao.Location = new System.Drawing.Point(1192, 9);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(32, 32);
            this.labelThongBao.TabIndex = 6;
            this.labelThongBao.Text = "0";
            this.labelThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNotify
            // 
            this.pictureBoxNotify.Image = global::RestaurantManagement.Properties.Resources.notification;
            this.pictureBoxNotify.Location = new System.Drawing.Point(852, 6);
            this.pictureBoxNotify.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNotify.Name = "pictureBoxNotify";
            this.pictureBoxNotify.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotify.TabIndex = 2;
            this.pictureBoxNotify.TabStop = false;
            // 
            // FormDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1610, 680);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.buttonKiemTraDatBan);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.pictureBoxNotify);
            this.Controls.Add(this.groupBoxDatMon);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button buttonGopBan;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.PictureBox pictureBoxNotify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLoaiMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMon;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTachBan;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonThemMon;
        //private System.Windows.Forms.Button buttonInHoaDon;
        //private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button buttonKiemTraDatBan;
        private System.Windows.Forms.Label labelThongBao;
    }
}