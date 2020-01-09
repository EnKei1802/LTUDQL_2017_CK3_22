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
    class ChiTietHoaDonBSModel
    {

        ConnectToSQL conSql = new ConnectToSQL();
        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = @"select cthd.MaCTHoaDon , s.MaSach , hd.MaHoaDon , cthd.SoLuongBan , cthd.DonGiaBanCuaHoaDon from CHITIETHOADONBS cthd , SACH s , HOADONBANSACH hd where cthd.MaSach = s.MaSach and cthd.MaHoaDon = hd.MaHoaDon";
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

        public bool AddData(ChiTietHoaDonBSObj hdObj)
        {
            cmdSql.CommandText = @" insert into CHITIETHOADONBS values('" + hdObj.MaCTHoaDon + "','" + hdObj.MaSach + "','" + hdObj.MaHoaDon + "','" + hdObj.SoLuongBan + "','" + hdObj.DonGiaBanCuaHoaDon + "')";

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
            cmdSql.CommandText = @"delete CHITIETHOADONBS where MaHoaDon = '" + maHD + "'";
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
