using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.Model;
using QuanLyNhaSach.Object;

namespace QuanLyNhaSach.Control
{
    class SachControl
    {
        SachModel sModel = new SachModel();

        public DataTable getDaTa()
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return sModel.GetData();
        }
        public bool addData(SachObject sObj)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return sModel.AddData(sObj);
        }
        public bool updateData(SachObject sObj)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return sModel.UpdateData(sObj);
        }
        public bool deleteData(string ma)
        {
            //code ở đây
            //giống KhachHangControl.cs nhưng thay bằng SACH
            return sModel.DeleteData(ma);
        }
    }
}
