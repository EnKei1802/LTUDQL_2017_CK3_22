using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class ChiTietBaoCaoCongNoObj
    {
        private string maBaoCaoCTCongNo;
        private string maBCCongNo;
        private string maKhachHang;
        private float noDau;
        private float phatSinh;
        private float noCuoi;
        public string MaBaoCaoCTCongNo { get => maBaoCaoCTCongNo; set => maBaoCaoCTCongNo = value; }
        public string MaBCCongNo { get => maBCCongNo; set => maBCCongNo = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public float NoDau { get => noDau; set => noDau = value; }
        public float PhatSinh { get => phatSinh; set => phatSinh = value; }
        public float NoCuoi { get => noCuoi; set => noCuoi = value; }

    }
}
