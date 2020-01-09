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
    public partial class frmSach : Form
    {
        SachControl sControl = new SachControl();
        SachObject sObj = new SachObject();
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
        void GanDuLieu(SachObject sachObj)
        {
            sachObj.MaSach = txtMaSach.Text.Trim();
            sachObj.TenSach = txtTenSach.Text.Trim();
            sachObj.TacGia = txtTacGia.Text.Trim();
            sachObj.TheLoai = txtTheLoai.Text.Trim();
            sachObj.SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
            sachObj.DonGiaBanCuaDauSach = float.Parse(txtDonGiaBanCuaDauSach.Text.Trim());
        }


        private void bntThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            frmSach_Load(sender, e);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
                if (sControl.deleteData(txtMaSach.Text.Trim()))
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
            frmSach_Load(sender, e);
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(sObj);
            if (flag == 0)
            {
                //thêm mới
                if (sControl.addData(sObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Sua

                if (sControl.updateData(sObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            frmSach_Load(sender, e);
            dis_en(false);
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
            dis_en(false);
        }

        private void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            txtMaSach.Enabled = false;
            frmSach_Load(sender, e);
        }

        private void frmSach_Load_1(object sender, EventArgs e)
        {
            DataTable dtSach = new DataTable();
            dtSach = sControl.getDaTa();
            dgvDSSach.DataSource = dtSach;
            bingding();
        }
    }
}
