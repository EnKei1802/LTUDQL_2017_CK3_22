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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNo pnt = new frmBaoCaoCongNo();
            pnt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBaoCaoTon pnt = new frmBaoCaoTon();
            pnt.Show();
        }
    }
}
