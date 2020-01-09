using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class ChiTietHoaDonBSObj
    {
       
        private string maCTHoaDon;
        private string maSach;
        private string maHoaDon;
        private int soLuongBan;
        private float donGiaBanCuaHoaDon;
        public string MaCTHoaDon { get => maCTHoaDon; set => maCTHoaDon = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int SoLuongBan { get => soLuongBan; set => soLuongBan = value; }
        public float DonGiaBanCuaHoaDon { get => donGiaBanCuaHoaDon; set => donGiaBanCuaHoaDon = value; }

        ChiTietHoaDonBSObj() { }
        ChiTietHoaDonBSObj(string maCT, string maSach , string maHoaDon , int soLuong, float donGia)
        {
            this.MaCTHoaDon = maCT;
            this.MaSach = maSach;
            this.MaHoaDon = maHoaDon;
            this.SoLuongBan = soLuong;
            this.DonGiaBanCuaHoaDon = donGia;
        }
    }

}
