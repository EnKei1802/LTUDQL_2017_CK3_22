using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class SachObject
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private string theLoai;
        private int soLuongTon;
        private float donGiaBanCuaDauSach;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public float DonGiaBanCuaDauSach { get => donGiaBanCuaDauSach; set => donGiaBanCuaDauSach = value; }

        public SachObject() { }
        public SachObject(string maSach, string tenSach, string tacGia, string theLoai, int soLuongTon, float donGiaBanCuaDauSach)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.soLuongTon = soLuongTon;
            this.donGiaBanCuaDauSach = donGiaBanCuaDauSach;
        }
    }
    //dựa vào KhachHangObj.cs
    //giống hệt
}
