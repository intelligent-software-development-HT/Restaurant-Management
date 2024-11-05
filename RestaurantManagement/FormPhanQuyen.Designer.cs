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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNhomQuyen
            // 
            this.dataGridViewNhomQuyen.AllowUserToAddRows = false;
            this.dataGridViewNhomQuyen.AllowUserToDeleteRows = false;
            this.dataGridViewNhomQuyen.AllowUserToResizeRows = false;
            this.dataGridViewNhomQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhomQuyen.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewNhomQuyen.MultiSelect = false;
            this.dataGridViewNhomQuyen.Name = "dataGridViewNhomQuyen";
            this.dataGridViewNhomQuyen.ReadOnly = true;
            this.dataGridViewNhomQuyen.RowHeadersWidth = 62;
            this.dataGridViewNhomQuyen.RowTemplate.Height = 28;
            this.dataGridViewNhomQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhomQuyen.Size = new System.Drawing.Size(495, 545);
            this.dataGridViewNhomQuyen.TabIndex = 0;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 761);
            this.Controls.Add(this.dataGridViewNhomQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhanQuyen";
            this.Text = "FormPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhomQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhomQuyen;
    }
}