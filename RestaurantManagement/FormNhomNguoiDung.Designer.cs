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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNhom = new System.Windows.Forms.TextBox();
            this.textBoxTenNhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxGhiChu = new System.Windows.Forms.RichTextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.groupBoxNhomNguoiDung = new System.Windows.Forms.GroupBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dataGridViewNhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.groupBoxNhomNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm";
            // 
            // textBoxMaNhom
            // 
            this.textBoxMaNhom.Location = new System.Drawing.Point(114, 55);
            this.textBoxMaNhom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaNhom.Name = "textBoxMaNhom";
            this.textBoxMaNhom.ReadOnly = true;
            this.textBoxMaNhom.Size = new System.Drawing.Size(279, 30);
            this.textBoxMaNhom.TabIndex = 2;
            this.textBoxMaNhom.TextChanged += new System.EventHandler(this.textBoxMaNhom_TextChanged);
            // 
            // textBoxTenNhom
            // 
            this.textBoxTenNhom.Location = new System.Drawing.Point(114, 113);
            this.textBoxTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenNhom.Name = "textBoxTenNhom";
            this.textBoxTenNhom.Size = new System.Drawing.Size(279, 30);
            this.textBoxTenNhom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú";
            // 
            // richTextBoxGhiChu
            // 
            this.richTextBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxGhiChu.Location = new System.Drawing.Point(114, 187);
            this.richTextBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxGhiChu.Name = "richTextBoxGhiChu";
            this.richTextBoxGhiChu.Size = new System.Drawing.Size(279, 106);
            this.richTextBoxGhiChu.TabIndex = 5;
            this.richTextBoxGhiChu.Text = "";
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.Teal;
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonThem.Location = new System.Drawing.Point(15, 611);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(114, 48);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            // 
            // groupBoxNhomNguoiDung
            // 
            this.groupBoxNhomNguoiDung.BackColor = System.Drawing.Color.White;
            this.groupBoxNhomNguoiDung.Controls.Add(this.textBoxMaNhom);
            this.groupBoxNhomNguoiDung.Controls.Add(this.buttonSua);
            this.groupBoxNhomNguoiDung.Controls.Add(this.buttonXoa);
            this.groupBoxNhomNguoiDung.Controls.Add(this.buttonThem);
            this.groupBoxNhomNguoiDung.Controls.Add(this.richTextBoxGhiChu);
            this.groupBoxNhomNguoiDung.Controls.Add(this.label3);
            this.groupBoxNhomNguoiDung.Controls.Add(this.textBoxTenNhom);
            this.groupBoxNhomNguoiDung.Controls.Add(this.label2);
            this.groupBoxNhomNguoiDung.Controls.Add(this.label1);
            this.groupBoxNhomNguoiDung.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxNhomNguoiDung.Location = new System.Drawing.Point(586, 2);
            this.groupBoxNhomNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNhomNguoiDung.Name = "groupBoxNhomNguoiDung";
            this.groupBoxNhomNguoiDung.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNhomNguoiDung.Size = new System.Drawing.Size(401, 667);
            this.groupBoxNhomNguoiDung.TabIndex = 1;
            this.groupBoxNhomNguoiDung.TabStop = false;
            this.groupBoxNhomNguoiDung.Text = "Nhóm người dùng";
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Teal;
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonSua.Location = new System.Drawing.Point(133, 611);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(114, 48);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.Teal;
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.buttonXoa.Location = new System.Drawing.Point(251, 611);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(114, 48);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // dataGridViewNhomNguoiDung
            // 
            this.dataGridViewNhomNguoiDung.AllowUserToAddRows = false;
            this.dataGridViewNhomNguoiDung.AllowUserToDeleteRows = false;
            this.dataGridViewNhomNguoiDung.AllowUserToResizeRows = false;
            this.dataGridViewNhomNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhomNguoiDung.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhomNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhomNguoiDung.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNhomNguoiDung.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewNhomNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNhomNguoiDung.MultiSelect = false;
            this.dataGridViewNhomNguoiDung.Name = "dataGridViewNhomNguoiDung";
            this.dataGridViewNhomNguoiDung.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhomNguoiDung.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNhomNguoiDung.RowHeadersVisible = false;
            this.dataGridViewNhomNguoiDung.RowHeadersWidth = 62;
            this.dataGridViewNhomNguoiDung.RowTemplate.Height = 28;
            this.dataGridViewNhomNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhomNguoiDung.Size = new System.Drawing.Size(569, 661);
            this.dataGridViewNhomNguoiDung.TabIndex = 8;
            // 
            // FormNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.dataGridViewNhomNguoiDung);
            this.Controls.Add(this.groupBoxNhomNguoiDung);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhomNguoiDung";
            this.Text = "FormNhomNguoiDung";
            this.groupBoxNhomNguoiDung.ResumeLayout(false);
            this.groupBoxNhomNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaNhom;
        private System.Windows.Forms.TextBox textBoxTenNhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxGhiChu;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.GroupBox groupBoxNhomNguoiDung;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView dataGridViewNhomNguoiDung;
    }
}