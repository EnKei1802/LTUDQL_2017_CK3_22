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

            return sModel.GetData();
        }
        public bool addData(SachObject sObj)
        {

            return sModel.AddData(sObj);
        }
        public bool updateData(SachObject sObj)
        {

            return sModel.UpdateData(sObj);
        }
        public bool deleteData(string ma)
        {
            return sModel.DeleteData(ma);
        }
    }
}
