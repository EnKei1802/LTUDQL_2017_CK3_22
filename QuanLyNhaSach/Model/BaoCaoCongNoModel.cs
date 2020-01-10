using QuanLyNhaSach.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class BaoCaoCongNoModel
    {
        ConnectToSQL conSql = new ConnectToSQL();

        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = @"select hd.MaHoaDon , kh.HoTen , hd.NgayLapHoaDon from HOADONBANSACH hd , KHACHHANG kh where hd.MaKhachHang = kh.MaKhachHang";
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

        public bool AddData(HoaDonBanSachObj hdObj)
        {
            cmdSql.CommandText = @" insert into HOADONBANSACH values('" + hdObj.MaHoaDon + "','" + hdObj.MaKhachHang + "',CONVERT(date,'" + hdObj.NgayLapHoaDon + "',103))";

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
            cmdSql.CommandText = @"delete HOADONBANSACH where MaHoaDon = '" + maHD + "'";
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
