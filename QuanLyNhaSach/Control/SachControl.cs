using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Model;
using QuanLyNhaSach.Object;

namespace QuanLyNhaSach.Control
{
    class SachControl
    {
        SachModel khModel = new SachModel();

        public DataTable getDaTa()
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            DataTable dt = new DataTable();
            return dt;
            
        }
        public bool addData(SachObject khObj)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return false; 
        }
        public bool updateData(SachObject khObj)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return false;
        }
        public bool deleteData(string ma)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return false;
        }
    }
}
