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
    class KhachHangControl
    {
        KhachHangModel khModel = new KhachHangModel();
        public DataTable getDaTa()
        {
            return khModel.GetData();
        }
        public bool addData(KhachHangObj khObj)
        {
            return khModel.AddData(khObj);
        }
        public bool updateData(KhachHangObj khObj)
        {
            return khModel.UpdateData(khObj);
        }
        public bool deleteData(string ma)
        {
            return khModel.DeleteData(ma);
        }

    }
}
