using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class FormPhanQuyen : Form
    {
        private readonly NhomNguoiDungBLL _nhomNguoiDungBLL = new NhomNguoiDungBLL();
        private readonly PhanQuyenBLL _phanQuyenBLL = new PhanQuyenBLL();

        public FormPhanQuyen()
        {
            InitializeComponent();
            this.Load += FormPhanQuyen_Load;
            this.buttonLuu.Click += ButtonLuu_Click;
            this.dataGridViewNhomQuyen.CellClick += DataGridViewNhomQuyen_CellClick;
        }

        private void DataGridViewNhomQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhomQuyen.CurrentRow == null)
            {
                return;
            }

            int maNhom = Convert.ToInt32(dataGridViewNhomQuyen.CurrentRow.Cells[0].Value);

            LoadDataQuyenTruyCap(maNhom);
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhomQuyen.CurrentRow == null)
            {
                return;
            }

            int maNhom = Convert.ToInt32(dataGridViewNhomQuyen.CurrentRow.Cells[0].Value);

            List<PhanQuyenDK> quyenTruyCapUpdated = GetQuyenTruyCapUpdated(maNhom);

            if (!_phanQuyenBLL.PhanQuyenTruyCap(maNhom, quyenTruyCapUpdated))
            {
                MessageBox.Show("Phân quyền thất bại.");
                return;
            }

            MessageBox.Show("Phân quyền thành công.");
            LoadDataQuyenTruyCap(maNhom);

            //Lấy mã nhóm đang được chọn và mã màn hình đã duyệt tới
            //Kiểm tra xem có tồn tại không
            //Nếu tồn tại - cập nhật cột CoQuyen
            //Nếu không tồn tại mà ô được tích chọn thì thêm mới 
        }

        private List<PhanQuyenDK> GetQuyenTruyCapUpdated(int maNhom)
        {
            List<PhanQuyenDK> quyenTruyCaps = new List<PhanQuyenDK>();

            int rows = dataGridViewQuyenTruyCap.Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                var quyenTruyCap = new PhanQuyenDK
                {
                    MaManHinh = Convert.ToInt32(dataGridViewQuyenTruyCap.Rows[i].Cells[0].Value),
                    TenManHinh = dataGridViewQuyenTruyCap.Rows[i].Cells[1].Value.ToString(),
                    CoQuyen = Convert.ToBoolean(dataGridViewQuyenTruyCap.Rows[i].Cells[2].Value)
                };

                if (quyenTruyCap == null || quyenTruyCap.MaManHinh == 0)
                {
                    continue;
                }

                quyenTruyCaps.Add(quyenTruyCap);
            }

            return quyenTruyCaps;
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDataNhomNguoiDung();
        }

        private void LoadDataQuyenTruyCap(int maNhom)
        {
            List<PhanQuyenDK> quyenTruyCap = _phanQuyenBLL.GetQuyenTruyCapTheoNhom(maNhom).ToList();

            dataGridViewQuyenTruyCap.DataSource = quyenTruyCap;
        }

        private void LoadDataNhomNguoiDung()
        {
            List<NhomNguoiDung> nhomNguoiDungs = _nhomNguoiDungBLL.ReadNhomNguoiDungs().ToList();

            dataGridViewNhomQuyen.DataSource = nhomNguoiDungs;
        }
    }
}
