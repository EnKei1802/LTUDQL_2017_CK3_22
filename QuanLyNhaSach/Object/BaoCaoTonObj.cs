using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class BaoCaoTonObj
    {
        private string maBaoCaoTon;
        private DateTime thang;
        public string MaBaoCaoTon { get => maBaoCaoTon; set => maBaoCaoTon=value; }
        public DateTime Thang { get => thang; set => thang=value; }
        public BaoCaoTonObj() { }
        public BaoCaoTonObj(string maBaoCaoTon,DateTime thang)
        {
            this.maBaoCaoTon = maBaoCaoTon;
            this.thang = thang;
        }
    }
   
}
