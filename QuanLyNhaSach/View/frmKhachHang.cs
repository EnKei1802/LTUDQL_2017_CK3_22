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
using QuanLyNhaSach.Object;


namespace QuanLyNhaSach.View
{
    public partial class frmKhachHang : Form
    {

        KhachHangControl khControl = new KhachHangControl();
        KhachHangObj khObj = new KhachHangObj();
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
        void GanDuLieu(KhachHangObj khObj)
        {
            khObj.MaKH = txtMaKH.Text.Trim();
            khObj.HoTen = txtHoTen.Text.Trim();
            khObj.DiaChi = txtDiaChi.Text.Trim();
            khObj.DienThoai = txtDienThoai.Text.Trim();
            khObj.Email = txtEmail.Text.Trim();
            khObj.TienNo = float.Parse(txtTienNo.Text.Trim());
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            frmKhachHang_Load(sender, e);
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            txtMaKH.Enabled =false;
            frmKhachHang_Load(sender, e);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
                if (khControl.deleteData(txtMaKH.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                return;
            frmKhachHang_Load(sender, e);
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(khObj);
            if(flag == 0 )
            {
                //thêm mới
                if(khControl.addData(khObj))
                {
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Sua
                
                if (khControl.updateData(khObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            frmKhachHang_Load(sender, e);
            dis_en(false);
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender,e);
            dis_en(false);
        }

        private void dgvDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
