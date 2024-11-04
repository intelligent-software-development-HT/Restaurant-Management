namespace RestaurantManagement
{
    partial class FormNhomNguoiDung
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
            this.dataGridViewNhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNhom = new System.Windows.Forms.TextBox();
            this.textBoxTenNhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxGhiChu = new System.Windows.Forms.RichTextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomNguoiDung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNhomNguoiDung
            // 
            this.dataGridViewNhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhomNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNhomNguoiDung.Name = "dataGridViewNhomNguoiDung";
            this.dataGridViewNhomNguoiDung.RowHeadersWidth = 62;
            this.dataGridViewNhomNguoiDung.RowTemplate.Height = 28;
            this.dataGridViewNhomNguoiDung.Size = new System.Drawing.Size(512, 585);
            this.dataGridViewNhomNguoiDung.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.richTextBoxGhiChu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTenNhom);
            this.groupBox1.Controls.Add(this.textBoxMaNhom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(531, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 584);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm";
            // 
            // textBoxMaNhom
            // 
            this.textBoxMaNhom.Location = new System.Drawing.Point(28, 63);
            this.textBoxMaNhom.Name = "textBoxMaNhom";
            this.textBoxMaNhom.ReadOnly = true;
            this.textBoxMaNhom.Size = new System.Drawing.Size(248, 26);
            this.textBoxMaNhom.TabIndex = 2;
            // 
            // textBoxTenNhom
            // 
            this.textBoxTenNhom.Location = new System.Drawing.Point(28, 124);
            this.textBoxTenNhom.Name = "textBoxTenNhom";
            this.textBoxTenNhom.Size = new System.Drawing.Size(248, 26);
            this.textBoxTenNhom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú";
            // 
            // richTextBoxGhiChu
            // 
            this.richTextBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxGhiChu.Location = new System.Drawing.Point(28, 187);
            this.richTextBoxGhiChu.Name = "richTextBoxGhiChu";
            this.richTextBoxGhiChu.Size = new System.Drawing.Size(248, 155);
            this.richTextBoxGhiChu.TabIndex = 5;
            this.richTextBoxGhiChu.Text = "";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(28, 366);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(86, 41);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(28, 413);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(86, 41);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(28, 460);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(86, 41);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // FormNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewNhomNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhomNguoiDung";
            this.Text = "FormNhomNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomNguoiDung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhomNguoiDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTenNhom;
        private System.Windows.Forms.TextBox textBoxMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxGhiChu;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
    }
}