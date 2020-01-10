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
    class PhieuNhapModel
    {
        ConnectToSQL conSql = new ConnectToSQL();

        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = @"select pn.MaPhieuNhap , pn.NgayNhap from PHIEUNHAP pn";
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

        public bool AddData(PhieuNhapObj pnObj)
        {
            cmdSql.CommandText = @" insert into PHIEUNHAP values('" + pnObj.MaPhieuNhap + "',CONVERT(date,'" + pnObj.NgayNhap + "',103))";

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

        public bool DeleteData(string maPN)
        {
            cmdSql.CommandText = @"delete PHIEUNHAP where MaHoaDon = '" + maPN + "'";
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
