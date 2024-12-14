using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public class BadgeThongBaoDatBan : Control
    {
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                this.Text = value > 99 ? "99+" : value.ToString();
                this.Invalidate(); // Vẽ lại control
            }
        }

        private ContentAlignment _textAlign = ContentAlignment.MiddleCenter;
        public ContentAlignment TextAlign
        {
            get => _textAlign;
            set
            {
                _textAlign = value;
                this.Invalidate(); // Vẽ lại control
            }
        }

        public BadgeThongBaoDatBan()
        {
            this.Size = new Size(30, 30); // Kích thước mặc định
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.Red; // Màu nền badge
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        // Hàm vẽ control
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var brush = new SolidBrush(this.BackColor))
            {
                // Vẽ hình tròn
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(brush, 0, 0, this.Width - 1, this.Height - 1);

                // Vẽ số lượng
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
            }
        }

        // Điều chỉnh kích thước khi thay đổi kích thước
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = this.Height; // Đảm bảo Badge luôn là hình tròn
        }
    }
}
