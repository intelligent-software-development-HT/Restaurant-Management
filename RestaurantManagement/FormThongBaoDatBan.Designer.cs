﻿namespace RestaurantManagement
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
            this.dataGridViewThongBao = new System.Windows.Forms.DataGridView();
            this.pictureBoxCloseModal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseModal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThongBao
            // 
            this.dataGridViewThongBao.AllowUserToAddRows = false;
            this.dataGridViewThongBao.AllowUserToDeleteRows = false;
            this.dataGridViewThongBao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongBao.Location = new System.Drawing.Point(13, 47);
            this.dataGridViewThongBao.Name = "dataGridViewThongBao";
            this.dataGridViewThongBao.ReadOnly = true;
            this.dataGridViewThongBao.RowHeadersWidth = 62;
            this.dataGridViewThongBao.RowTemplate.Height = 28;
            this.dataGridViewThongBao.Size = new System.Drawing.Size(556, 233);
            this.dataGridViewThongBao.TabIndex = 0;
            // 
            // pictureBoxCloseModal
            // 
            this.pictureBoxCloseModal.Image = global::RestaurantManagement.Properties.Resources.close_24;
            this.pictureBoxCloseModal.Location = new System.Drawing.Point(545, 12);
            this.pictureBoxCloseModal.Name = "pictureBoxCloseModal";
            this.pictureBoxCloseModal.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxCloseModal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseModal.TabIndex = 1;
            this.pictureBoxCloseModal.TabStop = false;
            // 
            // FormThongBaoDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 292);
            this.Controls.Add(this.pictureBoxCloseModal);
            this.Controls.Add(this.dataGridViewThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongBaoDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongBaoDatBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseModal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThongBao;
        private System.Windows.Forms.PictureBox pictureBoxCloseModal;
    }
}