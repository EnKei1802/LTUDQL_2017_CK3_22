﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Object;

namespace QuanLyNhaSach.Model
{
    class SachModel
    {
        ConnectToSQL conSql = new ConnectToSQL();
        SqlCommand cmdSql = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmdSql.CommandText = "select * from SACH";
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

        public bool AddData(SachObject sObj)
        {
            cmdSql.CommandText = "insert into SACH values('" + sObj.MaSach + "','" + sObj.TenSach + "','" + sObj.TacGia + "','" + sObj.TheLoai + "','" + sObj.SoLuongTon + "','" + sObj.DonGiaBanCuaDauSach + "')";

            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                cmdSql.ExecuteNonQuery();
                conSql.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return false;
        }
        public bool UpdateData(SachObject sObj)
        {
            cmdSql.CommandText = "update  SACH set HoTen = '" + sObj.TenSach + "', DiaChi = '" + sObj.TacGia + "',DienTHoai = '" + sObj.TheLoai + "',Email = '" + sObj.SoLuongTon + "', TienNo = " + sObj.DonGiaBanCuaDauSach + "'where MaSach ='" + sObj.MaSach + "'";

            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                cmdSql.ExecuteNonQuery();
                conSql.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmdSql.Dispose();
                conSql.CloseConn();
            }
            return false;
        }
        public bool DeleteData(string maSach)
        {
            cmdSql.CommandText = "delete SACH where MaSach = '" + maSach + "'";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Connection = conSql.Connection;

            try
            {
                conSql.OpenConn();
                cmdSql.ExecuteNonQuery();
                conSql.CloseConn();
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