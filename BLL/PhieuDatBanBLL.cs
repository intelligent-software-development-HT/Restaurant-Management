﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDatBanBLL
    {
        private readonly PhieuDatBanDAL _phieuDatBanDAL = new PhieuDatBanDAL();
        public PhieuDatBanBLL()
        {
            
        }

        public List<DatBan> GetDanhSachDatBan()
        {
            return _phieuDatBanDAL.GetDanhSachDatBan();
        }

        public int KiemTraBanKhaDung()
        {
            return _phieuDatBanDAL.KiemTraBanKhaDung();
        }

        public void XuLyTrangThaiDatBan()
        {
            _phieuDatBanDAL.XuLyTrangThaiDatBan();
        }

        public bool DuyetTrangThaiDatBan(int maDatBan, string trangThai)
        {
            return _phieuDatBanDAL.DuyetTrangThaiDatBan(maDatBan, trangThai);
        }
    }
}
