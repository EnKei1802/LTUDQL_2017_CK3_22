using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Object;

namespace QuanLyNhaSach.Model
{
    class KhachHangModel
    {
        ConnectToSQL conSql = new ConnectToSQL();
        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = "select * from KHACHHANG";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmdSql);
                sqlAdapter.Fill(dt);
                conSql.CloseConn();
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return dt;
        }

        public bool AddData(KhachHangObj khObj)
        {
            cmdSql.CommandText = "insert into KHACHHANG values('"+ khObj.MaKH + "',N'" + khObj.HoTen + "',N'" + khObj.DiaChi + "','" + khObj.DienThoai + "','" + khObj.Email + "','" + khObj.TienNo + "')";

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
        public bool UpdateData(KhachHangObj khObj)
        {
            cmdSql.CommandText = "update  KHACHHANG set HoTen = N'" + khObj.HoTen + "', DiaChi = N'" + khObj.DiaChi + "',DienTHoai = '" + khObj.DienThoai + "',Email = '" + khObj.Email + "', TienNo = '" + khObj.TienNo + "'where MaKhachHang ='" + khObj.MaKH + "'";

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
        public bool DeleteData(string maKH)
        {
            cmdSql.CommandText = "delete KHACHHANG where MaKhachHang = '"+maKH+"'";
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
