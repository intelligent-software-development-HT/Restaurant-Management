namespace RestaurantManagement
{
    partial class FormManHinh
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
            this.dataGridViewManHinh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaManHinh = new System.Windows.Forms.TextBox();
            this.textBoxTenManHinh = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManHinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewManHinh
            // 
            this.dataGridViewManHinh.AllowUserToAddRows = false;
            this.dataGridViewManHinh.AllowUserToDeleteRows = false;
            this.dataGridViewManHinh.AllowUserToResizeRows = false;
            this.dataGridViewManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManHinh.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewManHinh.MultiSelect = false;
            this.dataGridViewManHinh.Name = "dataGridViewManHinh";
            this.dataGridViewManHinh.ReadOnly = true;
            this.dataGridViewManHinh.RowHeadersVisible = false;
            this.dataGridViewManHinh.RowHeadersWidth = 62;
            this.dataGridViewManHinh.RowTemplate.Height = 28;
            this.dataGridViewManHinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManHinh.Size = new System.Drawing.Size(607, 628);
            this.dataGridViewManHinh.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHuy);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.textBoxTenManHinh);
            this.groupBox1.Controls.Add(this.textBoxMaManHinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(627, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màn hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã màn hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên màn hình";
            // 
            // textBoxMaManHinh
            // 
            this.textBoxMaManHinh.Location = new System.Drawing.Point(31, 67);
            this.textBoxMaManHinh.Name = "textBoxMaManHinh";
            this.textBoxMaManHinh.ReadOnly = true;
            this.textBoxMaManHinh.Size = new System.Drawing.Size(252, 26);
            this.textBoxMaManHinh.TabIndex = 2;
            // 
            // textBoxTenManHinh
            // 
            this.textBoxTenManHinh.Location = new System.Drawing.Point(31, 134);
            this.textBoxTenManHinh.Name = "textBoxTenManHinh";
            this.textBoxTenManHinh.Size = new System.Drawing.Size(252, 26);
            this.textBoxTenManHinh.TabIndex = 3;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(31, 228);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(124, 52);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(31, 286);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(124, 52);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(31, 344);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(124, 52);
            this.buttonSua.TabIndex = 4;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(31, 402);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(124, 52);
            this.buttonHuy.TabIndex = 4;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // FormManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewManHinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManHinh";
            this.Text = "FormManHinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManHinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTenManHinh;
        private System.Windows.Forms.TextBox textBoxMaManHinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
    }
}