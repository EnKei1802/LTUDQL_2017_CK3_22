using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.View;
using QuanLyNhaSach.Control;
using QuanLyNhaSach.Object;


namespace QuanLyNhaSach.View
{
    public partial class frmHoaDonBanSach : Form
    {
        HoaDonBanSachControl hdControl = new HoaDonBanSachControl();
        public frmHoaDonBanSach()
        {
            InitializeComponent();
        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = hdControl.getDaTa();
            dtgvHoaDonBanSach.DataSource = dt;
            bingding();
        }
        private void bingding()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtMaHoaDon.DataBindings.Add("Text",dtgvHoaDonBanSach.DataSource,"MaHoaDon");
            cbMaKhachHang.DataBindings.Clear();
            cbMaKhachHang.DataBindings.Add("Text", dtgvHoaDonBanSach.DataSource, "HoTen");
            txtNgayLapHoaDon.DataBindings.Clear();
            txtNgayLapHoaDon.DataBindings.Add("Text", dtgvHoaDonBanSach.DataSource, "NgayLapHoaDon");

        }
    }
}
