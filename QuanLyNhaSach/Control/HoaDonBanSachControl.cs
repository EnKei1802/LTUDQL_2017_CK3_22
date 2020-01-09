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
    class HoaDonBanSachControl
    {
        HoaDonBanSachModel hdModel = new HoaDonBanSachModel();

        public DataTable getDaTa()
        {

            return hdModel.GetData();
        }
        public bool addData(HoaDonBanSachObj hdObj)
        {

            return hdModel.AddData(hdObj);
        }
       
        public bool deleteData(string ma)
        {
            return hdModel.DeleteData(ma);
        }
    }
}
