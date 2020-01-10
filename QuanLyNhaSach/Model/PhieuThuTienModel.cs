using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Object;
namespace QuanLyNhaSach.Model
{
    class PhieuThuTienModel
    {
        ConnectToSQL conSql = new ConnectToSQL();

        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = @"select pt.MaPhieuThuTien , kh.HoTen ,kh.DienThoai , kh.Email , pt.NgayThuTien , pt.SoTienThu from PHIEUTHUTIEN pt , KHACHHANG kh where pt.MaKhachHang = kh.MaKhachHang";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmdSql);
                sqlAdapter.Fill(dt);
                conSql.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return dt;
        }

        public bool AddData(PhieuThuTienObj ptObj)
        {
            cmdSql.CommandText = @" insert into PHIEUTHUTIEN values('" + ptObj.MaPhieuThuTien + "','" + ptObj.MaKhachHang + "',CONVERT(date,'" + ptObj.NgayThuTien + "',103),'" + ptObj.SoTienThu + "')";

            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                cmdSql.ExecuteNonQuery();
                conSql.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return false;
        }

        public bool DeleteData(string maHD)
        {
            cmdSql.CommandText = @"delete PHIEUTHUTIEN where MaPhieuThu = '" + maHD + "'";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                cmdSql.ExecuteNonQuery();
                conSql.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return false;
        }
    }
}
