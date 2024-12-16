namespace RestaurantManagement
{
    partial class FormThongBaoDatBan
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
            this.dataGridViewThongBao = new System.Windows.Forms.DataGridView();
            this.contextMenuStripTrangThaiDatMon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).BeginInit();
            this.contextMenuStripTrangThaiDatMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewThongBao
            // 
            this.dataGridViewThongBao.AllowUserToAddRows = false;
            this.dataGridViewThongBao.AllowUserToDeleteRows = false;
            this.dataGridViewThongBao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongBao.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewThongBao.Name = "dataGridViewThongBao";
            this.dataGridViewThongBao.ReadOnly = true;
            this.dataGridViewThongBao.RowHeadersWidth = 62;
            this.dataGridViewThongBao.RowTemplate.Height = 28;
            this.dataGridViewThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongBao.Size = new System.Drawing.Size(1302, 426);
            this.dataGridViewThongBao.TabIndex = 0;
            // 
            // contextMenuStripTrangThaiDatMon
            // 
            this.contextMenuStripTrangThaiDatMon.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTrangThaiDatMon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duyệtToolStripMenuItem,
            this.hủyToolStripMenuItem});
            this.contextMenuStripTrangThaiDatMon.Name = "contextMenuStripTrangThaiDatMon";
            this.contextMenuStripTrangThaiDatMon.Size = new System.Drawing.Size(132, 68);
            // 
            // duyệtToolStripMenuItem
            // 
            this.duyệtToolStripMenuItem.Name = "duyệtToolStripMenuItem";
            this.duyệtToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.duyệtToolStripMenuItem.Text = "Duyệt";
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.hủyToolStripMenuItem.Text = "Hủy";
            // 
            // FormThongBaoDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.Controls.Add(this.dataGridViewThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThongBaoDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongBaoDatBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).EndInit();
            this.contextMenuStripTrangThaiDatMon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThongBao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTrangThaiDatMon;
        private System.Windows.Forms.ToolStripMenuItem duyệtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;
    }
}