using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class PhieuThuTienObj
    {
        private string maPhieuThuTien;
        private string maKhachHang;
        private DateTime ngayThuTien;
        private float soTienThu;

        public string MaPhieuThuTien { get => maPhieuThuTien; set => maPhieuThuTien = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayThuTien { get => ngayThuTien; set => ngayThuTien = value; }
        public float SoTienThu { get => soTienThu; set => soTienThu = value; }
    }
}
