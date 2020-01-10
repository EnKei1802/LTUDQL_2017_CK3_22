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
    class ChiTietHoaDonBSControl
    {
        ChiTietHoaDonBSModel cthdModel = new ChiTietHoaDonBSModel();

        public DataTable getDaTa(string ma)
        {

            return cthdModel.GetData(ma);
        }
        public bool addData(DataTable dt)
        {

            return cthdModel.AddData( dt);
        }
        public bool deleteData(string ma)
        {
            return cthdModel.DeleteData(ma);

        }
    }
}
