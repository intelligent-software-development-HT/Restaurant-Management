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
            this.buttonCapNhatTrangThai = new System.Windows.Forms.Button();
            this.comboBoxDonMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDonMon
            // 
            this.dataGridViewDonMon.AllowUserToAddRows = false;
            this.dataGridViewDonMon.AllowUserToDeleteRows = false;
            this.dataGridViewDonMon.AllowUserToResizeRows = false;
            this.dataGridViewDonMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDonMon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDonMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDonMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonMon.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDonMon.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewDonMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDonMon.MultiSelect = false;
            this.dataGridViewDonMon.Name = "dataGridViewDonMon";
            this.dataGridViewDonMon.ReadOnly = true;
            this.dataGridViewDonMon.RowHeadersVisible = false;
            this.dataGridViewDonMon.RowHeadersWidth = 62;
            this.dataGridViewDonMon.RowTemplate.Height = 28;
            this.dataGridViewDonMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDonMon.Size = new System.Drawing.Size(695, 461);
            this.dataGridViewDonMon.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCapNhatTrangThai);
            this.groupBox1.Controls.Add(this.comboBoxDonMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(707, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn món";
            // 
            // buttonCapNhatTrangThai
            // 
            this.buttonCapNhatTrangThai.Location = new System.Drawing.Point(18, 62);
            this.buttonCapNhatTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCapNhatTrangThai.Name = "buttonCapNhatTrangThai";
            this.buttonCapNhatTrangThai.Size = new System.Drawing.Size(177, 25);
            this.buttonCapNhatTrangThai.TabIndex = 2;
            this.buttonCapNhatTrangThai.Text = "Cập nhật trạng thái";
            this.buttonCapNhatTrangThai.UseVisualStyleBackColor = true;
            // 
            // comboBoxDonMon
            // 
            this.comboBoxDonMon.FormattingEnabled = true;
            this.comboBoxDonMon.Location = new System.Drawing.Point(18, 40);
            this.comboBoxDonMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDonMon.Name = "comboBoxDonMon";
            this.comboBoxDonMon.Size = new System.Drawing.Size(179, 21);
            this.comboBoxDonMon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái đơn món";
            // 
            // FormDonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDonMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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