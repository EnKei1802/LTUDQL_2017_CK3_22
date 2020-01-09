using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class ChiTietPhieuNhapObj
    {
        private string maChiTietPhieuNhap;
        private string maSach;
        private string maPhieuNhap;
        private int soLuongNhap;
        public string MaChiTietPhieuNhap { get => maChiTietPhieuNhap; set => maChiTietPhieuNhap = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
    }
}
