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
  class ChiTietPhieuNhapControl
    {
        ChiTietPhieuNhapModel ctpnModel = new ChiTietPhieuNhapModel();

        public DataTable getDaTa(string ma)
        {

            return ctpnModel.GetData(ma);
        }
    
        public bool addData(DataTable dt)
        {

            return ctpnModel.AddData(dt);
        }
        public bool deleteData(string ma)
        {
            return ctpnModel.DeleteData(ma);
        }
    }
}
