using QuanLyNhaSach.Model;
using QuanLyNhaSach.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Control
{
    class PhieuNhapControl
    {
        PhieuNhapModel hdModel = new PhieuNhapModel();

        public DataTable getDaTa()
        {

            return hdModel.GetData();
        }
        public bool addData(PhieuNhapObj hdObj)
        {

            return hdModel.AddData(hdObj);
        }

        public bool deleteData(string ma)
        {
            return hdModel.DeleteData(ma);
        }
    }
}
