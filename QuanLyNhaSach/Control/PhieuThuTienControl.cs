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
    class PhieuThuTienControl
    {
        PhieuThuTienModel hdModel = new PhieuThuTienModel();

        public DataTable getDaTa()
        {

            return hdModel.GetData();
        }
        public bool addData(PhieuThuTienObj hdObj)
        {

            return hdModel.AddData(hdObj);
        }

        public bool deleteData(string ma)
        {
            return hdModel.DeleteData(ma);
        }
    }
}
