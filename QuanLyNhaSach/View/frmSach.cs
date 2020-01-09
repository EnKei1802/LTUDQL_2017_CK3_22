using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Control;

namespace QuanLyNhaSach.View
{
    public partial class frmSach : Form
    {
        SachControl sControl = new SachControl();
        int flag = 0;
        public frmSach()
        {
            InitializeComponent();
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = sControl.getDaTa();
            dgvDSSach.DataSource = dtKhachHang;
            bingding();
        }
        void bingding()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvDSSach.DataSource, "MaSach");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dgvDSSach.DataSource, "TenSach");
            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", dgvDSSach.DataSource, "TacGia");
            txtTheLoai.DataBindings.Clear();
            txtTheLoai.DataBindings.Add("Text", dgvDSSach.DataSource, "TheLoai");
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dgvDSSach.DataSource, "SoLuongTon");
            txtDonGiaBanCuaDauSach.DataBindings.Clear();
            txtDonGiaBanCuaDauSach.DataBindings.Add("Text", dgvDSSach.DataSource, "DonGiaBanCuaDauSach");

        }
        void dis_en(bool e)
        {
            txtMaSach.Enabled = e;
            txtTenSach.Enabled = e;
            txtTacGia.Enabled = e;
            txtTheLoai.Enabled = e;
            txtSoLuongTon.Enabled = e;
            txtDonGiaBanCuaDauSach.Enabled = e;
            bntLuu.Enabled = e;
            bntHuy.Enabled = e;
            bntThem.Enabled = !e;
            bntSua.Enabled = !e;
            bntXoa.Enabled = !e;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
            }
            else
                return;
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                //thêm mới
            }
            else
            {
                //Sua
            }
            dis_en(true);
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
        }

        private void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
