using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.View
{
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void bntTraCuuSach_Click(object sender, EventArgs e)
        {
            frmSach pnt = new frmSach();
            pnt.Show();
        }

        private void bntTraCuuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang pnt = new frmKhachHang();
            pnt.Show();
        }
    }
}
