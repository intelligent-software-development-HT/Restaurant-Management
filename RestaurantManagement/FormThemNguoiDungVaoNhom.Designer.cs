namespace RestaurantManagement
{
    partial class FormThemNguoiDungVaoNhom
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
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewThemVaoNhom = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.comboBoxNhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemVaoNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.AllowUserToAddRows = false;
            this.dataGridViewNguoiDung.AllowUserToDeleteRows = false;
            this.dataGridViewNguoiDung.AllowUserToResizeRows = false;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewNguoiDung.MultiSelect = false;
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.ReadOnly = true;
            this.dataGridViewNguoiDung.RowHeadersVisible = false;
            this.dataGridViewNguoiDung.RowHeadersWidth = 62;
            this.dataGridViewNguoiDung.RowTemplate.Height = 28;
            this.dataGridViewNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(607, 568);
            this.dataGridViewNguoiDung.TabIndex = 0;
            // 
            // dataGridViewThemVaoNhom
            // 
            this.dataGridViewThemVaoNhom.AllowUserToAddRows = false;
            this.dataGridViewThemVaoNhom.AllowUserToDeleteRows = false;
            this.dataGridViewThemVaoNhom.AllowUserToResizeRows = false;
            this.dataGridViewThemVaoNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemVaoNhom.Location = new System.Drawing.Point(770, 141);
            this.dataGridViewThemVaoNhom.MultiSelect = false;
            this.dataGridViewThemVaoNhom.Name = "dataGridViewThemVaoNhom";
            this.dataGridViewThemVaoNhom.ReadOnly = true;
            this.dataGridViewThemVaoNhom.RowHeadersVisible = false;
            this.dataGridViewThemVaoNhom.RowHeadersWidth = 62;
            this.dataGridViewThemVaoNhom.RowTemplate.Height = 28;
            this.dataGridViewThemVaoNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThemVaoNhom.Size = new System.Drawing.Size(381, 568);
            this.dataGridViewThemVaoNhom.TabIndex = 1;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(638, 371);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(116, 54);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = ">>";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(638, 431);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(116, 54);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "<<";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // comboBoxNhomNguoiDung
            // 
            this.comboBoxNhomNguoiDung.FormattingEnabled = true;
            this.comboBoxNhomNguoiDung.Location = new System.Drawing.Point(770, 84);
            this.comboBoxNhomNguoiDung.Name = "comboBoxNhomNguoiDung";
            this.comboBoxNhomNguoiDung.Size = new System.Drawing.Size(260, 28);
            this.comboBoxNhomNguoiDung.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm người dùng";
            // 
            // FormThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 763);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNhomNguoiDung);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewThemVaoNhom);
            this.Controls.Add(this.dataGridViewNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNguoiDungVaoNhom";
            this.Text = "FormThemNguoiDungVaoNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemVaoNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.DataGridView dataGridViewThemVaoNhom;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.ComboBox comboBoxNhomNguoiDung;
        private System.Windows.Forms.Label label1;
    }
}