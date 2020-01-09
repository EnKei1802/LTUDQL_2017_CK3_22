using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class ChiTietBaoCaoTonObj
    {
        private string maCTBaoCaoTon;
        private string maSach;
        private string maBaoCaoTon;
        private float tonDau;
        private float phatSinh;
        private float tonCuoi;
        public string MaCTBaoCaoTon { get => maCTBaoCaoTon; set => maCTBaoCaoTon = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaBaoCaoTon { get => maBaoCaoTon; set => maBaoCaoTon = value; }
        public float TonDau { get => tonDau; set => tonDau = value; }
        public float PhatSinh { get => phatSinh; set => phatSinh = value; }
        public float TonCuoi { get => tonCuoi; set => tonCuoi = value; }
        public ChiTietBaoCaoTonObj() { }
        public ChiTietBaoCaoTonObj(string maCTBaoCaoTon,string maSach,string maBaoCaoTon,float tonDau,float phatSinh,float tonCuoi
)
        {
            this.maCTBaoCaoTon = maCTBaoCaoTon;
            this.maSach = maSach;
            this.maBaoCaoTon = maBaoCaoTon;
            this.tonDau = tonDau;
            this.phatSinh = phatSinh;
            this.tonCuoi = tonCuoi;
        }
    }
}
