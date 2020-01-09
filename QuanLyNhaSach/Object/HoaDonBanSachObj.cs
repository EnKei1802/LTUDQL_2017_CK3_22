using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class HoaDonBanSachObj
    {
        private string maHoaDon;
        private string maKhachHang;
        private DateTime ngayLapHoaDon;
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayLapHoaDon { get => ngayLapHoaDon; set => ngayLapHoaDon = value; }
    }
}
