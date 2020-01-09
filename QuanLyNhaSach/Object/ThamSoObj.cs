using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class ThamSoObj
    {
        private int soLuongNhapItNhat;
        private int soLuongTonItNhatDeNhap;
        private int soTienKhachHangNoToiDa;
        private int soLuongTonToiDaDeBan;
        public int SoLuongNhapItNhat { get => soLuongNhapItNhat; set => soLuongNhapItNhat = value; }
        public int SoLuongTonItNhatDeNhap { get => soLuongTonItNhatDeNhap; set => soLuongTonItNhatDeNhap = value; }
        public int SoTienKhachHangNoToiDa { get => soTienKhachHangNoToiDa; set => soTienKhachHangNoToiDa = value; }
        public int SoLuongTonToiDaDeBan { get => soLuongTonToiDaDeBan; set => soLuongTonToiDaDeBan = value; }
        public ThamSoObj() { }
        public ThamSoObj(int soLuongNhapItNhat,int soLuongTonItNhatDeNhap,int soTienKhachHangNoToiDa,int soLuongTonToiDaDeBan)
        {
            this.soLuongNhapItNhat = soLuongNhapItNhat;
            this.soLuongTonItNhatDeNhap = soLuongTonItNhatDeNhap;
            this.soTienKhachHangNoToiDa = soTienKhachHangNoToiDa;
            this.soLuongTonToiDaDeBan = soLuongTonToiDaDeBan;
        }
    }
}
