using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class ChiTietPhieuNhapModel
    {
        ConnectToSQL conSql = new ConnectToSQL();
        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = @"select cthd.MaCTHoaDon , s.TenSach , hd.MaHoaDon , cthd.SoLuongBan , cthd.DonGiaBanCuaHoaDon from CHITIETPHIEUNHAP ctpn , SACH s , PHIEUNHAP pn  where ctpn.MaSach = s.MaSach and ctpn.MaPhieuNhap = pn.MaPhieuNhap and ctpn.MaHoaDon = '" + ma + "'";
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

        public bool AddData(DataTable dt)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmdSql.CommandText = @" insert into CHITIETPHIEUNHAP values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "')";

                    cmdSql.CommandType = CommandType.Text;
                    cmdSql.Connection = conSql.Connection;
                    conSql.OpenConn();
                    cmdSql.ExecuteNonQuery();
                    conSql.CloseConn();
                }
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
            cmdSql.CommandText = @"delete CHITIETPHIEUNHAP where MaPhieuNhap = '" + maHD + "'";
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
