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
    public partial class frmKhachHang : Form
    {

        KhachHangControl khControl = new KhachHangControl();
        int flag = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khControl.getDaTa();
            dgvDSKhachHang.DataSource = dtKhachHang;
            bingding();
        }
        void bingding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text",dgvDSKhachHang.DataSource,"MaKhachHang");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "HoTen");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "DiaChi");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "Email");
            txtTienNo.DataBindings.Clear();
            txtTienNo.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "TienNo");
            
        }
        void dis_en(bool e)
        {
            txtMaKH.Enabled = e;
            txtHoTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtDienThoai.Enabled = e;
            txtEmail.Enabled = e;
            txtTienNo.Enabled = e;
            bntLuu.Enabled = e;
            bntHuy.Enabled = e;
            bntThem.Enabled  =!e;
            bntSua.Enabled = !e;
            bntXoa.Enabled = !e;
        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            flag = 1;
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
            if(flag == 0 )
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

        private void dgvDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
