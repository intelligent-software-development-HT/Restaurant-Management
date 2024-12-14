namespace RestaurantManagement
{
    partial class FormPhanQuyen
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
            this.dataGridViewNhomQuyen = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuyenTruyCap = new System.Windows.Forms.DataGridView();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenTruyCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNhomQuyen
            // 
            this.dataGridViewNhomQuyen.AllowUserToAddRows = false;
            this.dataGridViewNhomQuyen.AllowUserToDeleteRows = false;
            this.dataGridViewNhomQuyen.AllowUserToResizeRows = false;
            this.dataGridViewNhomQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNhomQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhomQuyen.Location = new System.Drawing.Point(13, 97);
            this.dataGridViewNhomQuyen.MultiSelect = false;
            this.dataGridViewNhomQuyen.Name = "dataGridViewNhomQuyen";
            this.dataGridViewNhomQuyen.ReadOnly = true;
            this.dataGridViewNhomQuyen.RowHeadersWidth = 62;
            this.dataGridViewNhomQuyen.RowTemplate.Height = 28;
            this.dataGridViewNhomQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhomQuyen.Size = new System.Drawing.Size(577, 545);
            this.dataGridViewNhomQuyen.TabIndex = 0;
            // 
            // dataGridViewQuyenTruyCap
            // 
            this.dataGridViewQuyenTruyCap.AllowUserToAddRows = false;
            this.dataGridViewQuyenTruyCap.AllowUserToDeleteRows = false;
            this.dataGridViewQuyenTruyCap.AllowUserToResizeRows = false;
            this.dataGridViewQuyenTruyCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewQuyenTruyCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyenTruyCap.Location = new System.Drawing.Point(633, 97);
            this.dataGridViewQuyenTruyCap.MultiSelect = false;
            this.dataGridViewQuyenTruyCap.Name = "dataGridViewQuyenTruyCap";
            this.dataGridViewQuyenTruyCap.RowHeadersVisible = false;
            this.dataGridViewQuyenTruyCap.RowHeadersWidth = 62;
            this.dataGridViewQuyenTruyCap.RowTemplate.Height = 28;
            this.dataGridViewQuyenTruyCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuyenTruyCap.Size = new System.Drawing.Size(707, 545);
            this.dataGridViewQuyenTruyCap.TabIndex = 1;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(13, 22);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(142, 53);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 761);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewQuyenTruyCap);
            this.Controls.Add(this.dataGridViewNhomQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhanQuyen";
            this.Text = "FormPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenTruyCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhomQuyen;
        private System.Windows.Forms.DataGridView dataGridViewQuyenTruyCap;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenManHinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coQuyen;
    }
}