using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class KhachHangObj
    {
        private string maKH;
        private string hoTen;
        private string diaChi;
        private string dienThoai;
        private string email;
        private float tienNo;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public float TienNo { get => tienNo; set => tienNo = value; }

        public KhachHangObj() { }
        public KhachHangObj(string maKH , string hoTen , string diaChi , string dienThoai , string email, float tienNo)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
            this.tienNo = tienNo;
        }
    }
}
