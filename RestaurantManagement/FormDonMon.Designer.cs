namespace RestaurantManagement
{
    partial class FormDonMon
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
            this.dataGridViewDonMon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDonMon = new System.Windows.Forms.ComboBox();
            this.buttonCapNhatTrangThai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDonMon
            // 
            this.dataGridViewDonMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonMon.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDonMon.Name = "dataGridViewDonMon";
            this.dataGridViewDonMon.RowHeadersWidth = 62;
            this.dataGridViewDonMon.RowTemplate.Height = 28;
            this.dataGridViewDonMon.Size = new System.Drawing.Size(765, 710);
            this.dataGridViewDonMon.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCapNhatTrangThai);
            this.groupBox1.Controls.Add(this.comboBoxDonMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(783, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái đơn món";
            // 
            // comboBoxDonMon
            // 
            this.comboBoxDonMon.FormattingEnabled = true;
            this.comboBoxDonMon.Location = new System.Drawing.Point(27, 61);
            this.comboBoxDonMon.Name = "comboBoxDonMon";
            this.comboBoxDonMon.Size = new System.Drawing.Size(266, 28);
            this.comboBoxDonMon.TabIndex = 1;
            // 
            // buttonCapNhatTrangThai
            // 
            this.buttonCapNhatTrangThai.Location = new System.Drawing.Point(27, 95);
            this.buttonCapNhatTrangThai.Name = "buttonCapNhatTrangThai";
            this.buttonCapNhatTrangThai.Size = new System.Drawing.Size(266, 39);
            this.buttonCapNhatTrangThai.TabIndex = 2;
            this.buttonCapNhatTrangThai.Text = "Cập nhật trạng thái";
            this.buttonCapNhatTrangThai.UseVisualStyleBackColor = true;
            // 
            // FormDonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 734);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDonMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonMon";
            this.Text = "FormDonMon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonMon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDonMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDonMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCapNhatTrangThai;
    }
}