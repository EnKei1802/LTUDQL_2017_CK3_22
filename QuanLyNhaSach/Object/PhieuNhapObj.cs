using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class PhieuNhapObj
    {
        private string maPhieuNhap;
        private DateTime ngayNhap;
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public PhieuNhapObj() { }
        public PhieuNhapObj(string maPhieuNhap, DateTime ngayNhap)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.ngayNhap = ngayNhap;
        }
    }
}
