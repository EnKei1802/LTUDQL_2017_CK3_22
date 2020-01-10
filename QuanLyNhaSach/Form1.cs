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
namespace QuanLyNhaSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSach pnt = new frmPhieuNhapSach();
            pnt.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmHoaDonBanSach pnt = new frmHoaDonBanSach();
            pnt.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmPhieuThuTien pnt = new frmPhieuThuTien();
            pnt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmTraCuu pnt = new frmTraCuu();
            pnt.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmThamSo pnt = new frmThamSo();
            pnt.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmBaoCao pnt = new frmBaoCao();
            pnt.Show();
        }
    }
}
