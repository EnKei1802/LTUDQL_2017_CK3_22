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
    public partial class frmPhieuThuTien : Form
    {
        PhieuThuTienControl ptControl = new PhieuThuTienControl();
        KhachHangControl khControl = new KhachHangControl();

        public frmPhieuThuTien()
        {
            InitializeComponent();
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            Dis_enCTHD(false);
            DataTable dt = new System.Data.DataTable();
            dt = ptControl.getDaTa();
            dtgvPhieuThu.DataSource = dt;
            bingdingHoaDon();
            txtNgayThu.Enabled = true;
        }
        private void bingdingHoaDon()
        {
            txtMaPhieuThu.DataBindings.Clear();
            txtMaPhieuThu.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "MaPhieuThuTien");

            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "HoTen");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "DienThoai");

            txtSoTienThu.DataBindings.Clear();
            txtSoTienThu.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "SoTienThu");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "Email");

            txtNgayThu.DataBindings.Clear();
            txtNgayThu.DataBindings.Add("Text", dtgvPhieuThu.DataSource, "NgayThuTien");
        }
        private void Dis_enCTHD(bool e)
        {
            txtMaPhieuThu.Enabled = e;

            bntTaoMoiPhieuThu.Enabled = !e;
            bntInPhieuThu.Enabled = !e;
            bntXoaPhieuThu.Enabled = !e;
            bntLuuPhieuThu.Enabled = e;
            bntHuyPhieuThu.Enabled = e;
        }
        private void LoadcmdKhachHang()
        {
            KhachHangControl khControl = new KhachHangControl();
            txtTenKhachHang.DataSource = khControl.getDaTa();
            txtTenKhachHang.DisplayMember = "HoTen";
            txtTenKhachHang.ValueMember = "MaKhachHang";
        }
        private void clearData()
        {
            txtMaPhieuThu.Text = "";
            txtNgayThu.Text = DateTime.Now.Date.ToShortDateString();
            txtSoTienThu.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            LoadcmdKhachHang();
        }
        private void addData(PhieuThuTienObj hdObj)
        {
            hdObj.MaPhieuThuTien = txtMaPhieuThu.Text.Trim();
            hdObj.NgayThuTien = Convert.ToDateTime(txtNgayThu.Text.Trim());
            hdObj.MaKhachHang = txtTenKhachHang.SelectedValue.ToString();
            hdObj.SoTienThu = float.Parse(txtSoTienThu.Text.Trim());
            hdObj.MaPhieuThuTien = txtMaPhieuThu.Text.Trim();
            hdObj.MaPhieuThuTien = txtMaPhieuThu.Text.Trim();
            hdObj.MaPhieuThuTien = txtMaPhieuThu.Text.Trim();
        }

        private void bntTaoMoiPhieuThu_Click(object sender, EventArgs e)
        {
            Dis_enCTHD(true);
            clearData();
            LoadcmdKhachHang();
        }

        private void bntXoaPhieuThu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
                if (ptControl.deleteData(txtMaPhieuThu.Text.Trim()))
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
            frmPhieuThuTien_Load(sender, e);
        }

        private void bntInPhieuThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nâng cấp");
        }

        private void bntLuuPhieuThu_Click(object sender, EventArgs e)
        {
            PhieuThuTienObj hd = new PhieuThuTienObj();
            addData(hd);
            if (ptControl.addData(hd))
            {
                MessageBox.Show("Thêm phiếu thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phiếu thu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmPhieuThuTien_Load(sender, e);
        }

        private void bntHuyPhieuThu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                frmPhieuThuTien_Load(sender, e);
            }
            return;
        }
    }
}
