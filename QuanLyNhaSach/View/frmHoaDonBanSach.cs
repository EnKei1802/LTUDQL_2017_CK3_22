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
        ChiTietHoaDonBSControl cthdControl = new ChiTietHoaDonBSControl();
        SachControl sachControl = new SachControl();
        DataTable dtCT = new System.Data.DataTable();
        int vitriclick = 0;
        public frmHoaDonBanSach()
        {
            InitializeComponent();
        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            Dis_enCTHD(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdControl.getDaTa();
            dtgvHoaDonBanSach.DataSource = dt;
            bingdingHoaDon();
            txtNgayLapHoaDon.Enabled = true;
        }
        private void bingdingHoaDon()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtMaHoaDon.DataBindings.Add("Text", dtgvHoaDonBanSach.DataSource, "MaHoaDon");
            cbMaKhachHang.DataBindings.Clear();
            cbMaKhachHang.DataBindings.Add("Text", dtgvHoaDonBanSach.DataSource, "HoTen");
            txtNgayLapHoaDon.DataBindings.Clear();
            txtNgayLapHoaDon.DataBindings.Add("Text", dtgvHoaDonBanSach.DataSource, "NgayLapHoaDon");

        }
        /* private void bingdingChiTietHoaDon()
         {
             cbMaCTHoaDon.DataBindings.Clear();
             cbMaCTHoaDon.DataBindings.Add("Text", dtgvCTHoaDonBS.DataSource, "MaCTHoaDon");
             cbMaHoaDon.DataBindings.Clear();
             cbMaHoaDon.DataBindings.Add("Text", dtgvCTHoaDonBS.DataSource, "MaHoaDon");
             cbTenSach.DataBindings.Clear();
             cbTenSach.DataBindings.Add("Text", dtgvCTHoaDonBS.DataSource, "TenSach");
             cbMaKhachHang.DataBindings.Clear();
             cbMaKhachHang.DataBindings.Add("Text", dtgvCTHoaDonBS.DataSource, "MaHoaDon");
             txtSoLuongBan.DataBindings.Clear();
             txtSoLuongBan.DataBindings.Add("Text",dtgvCTHoaDonBS.DataSource,"SoLuongBan");
             txtDonGia.DataBindings.Clear();
             txtDonGia.DataBindings.Add("Text", dtgvCTHoaDonBS.DataSource, "DonGiaBanCuaHoaDon");

         }*/

        private void Dis_enCTHD(bool e)
        {
            txtMaHoaDon.Enabled = e;
            cbMaCTHoaDon.Enabled = e;
            cbMaHoaDon.Enabled = e;
            bntTaoMoiHoaDon.Enabled = !e;
            bntXoaHoaDon.Enabled = !e;
            bntInHoaDon.Enabled = !e;
            bntLuuHoaDon.Enabled = e;
            bntHuyHoaDon.Enabled = e;
            bntCham.Enabled = e;
            bntThemCTHoaDon.Enabled = e;
            bntBotCTHoaDon.Enabled = e;
        }
        private void LoadcmdKhachHang()
        {
            KhachHangControl khControl = new KhachHangControl();
            cbMaKhachHang.DataSource = khControl.getDaTa();
            cbMaKhachHang.DisplayMember = "HoTen";
            cbMaKhachHang.ValueMember = "MaKhachHang";
        }
        private void LoadcmdTenSach()
        {
            SachControl khControl = new SachControl();
            cbTenSach.DataSource = khControl.getDaTa();
            cbTenSach.DisplayMember = "TenSach";
            cbMaKhachHang.ValueMember = "MaSach";
        }

        private void clearData()
        {
            txtMaHoaDon.Text = "";
            txtNgayLapHoaDon.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmdKhachHang();
        }

        private void addData(HoaDonBanSachObj hdObj)
        {
            hdObj.MaHoaDon = txtMaHoaDon.Text.Trim();
            hdObj.NgayLapHoaDon = Convert.ToDateTime(txtNgayLapHoaDon.Text.Trim());
            hdObj.MaKhachHang = cbMaKhachHang.SelectedValue.ToString();
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = cthdControl.getDaTa(txtMaHoaDon.Text.Trim());
                dtgvCTHoaDonBS.DataSource = dt;
            }
            catch
            {
                dtgvCTHoaDonBS.DataSource = null;
            }
            // bingdingChiTietHoaDon();
        }

        private bool checktrung(string masach)
        {
            for (int i = 0; i < dtgvCTHoaDonBS.Rows.Count; i++)
            {
                if (dtCT.Rows[i][1].ToString() == masach)
                {
                    return true;
                }
            }
            return false;
        }

        private void capnhatSL(string masach, int SL)
        {
            for (int i = 0; i < dtCT.Rows.Count; i++)
            {
                if (dtCT.Rows[i][1].ToString() == masach)
                {
                    int soluong = int.Parse(dtCT.Rows[i][3].ToString()) + SL;
                    dtCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtCT.Rows[i][4].ToString());
                    break;
                }
            }
        }
        private bool kiemtraSoLuong(string masach, int sl)
        {
            DataTable dt = new DataTable();
            dt = sachControl.GetData("where MaSach = '" + cbTenSach.SelectedValue.ToString() + "' and SoLuongTon >=" + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        private void dtgvCTHoaDonBS_DataSourceChanged(object sender, EventArgs e)
        {
            //bingdingChiTietHoaDon();
        }

        private void bntTaoMoiHoaDon_Click(object sender, EventArgs e)
        {
            Dis_enCTHD(true);
            clearData();
            LoadcmdTenSach();
            LoadcmdKhachHang();

            dtCT.Rows.Clear();
            dtCT.Columns.Add("MaHoaDon");
            dtCT.Columns.Add("TenSach");
            dtCT.Columns.Add("SoLuongBan");
            dtCT.Columns.Add("DonGiaBanCuaHoaDon");
        }

        private void bntCham_Click(object sender, EventArgs e)
        {
            txtNgayLapHoaDon.Enabled = true;
        }

        private void bntXoaHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
                if (hdControl.deleteData(txtMaHoaDon.Text.Trim()))
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
            frmHoaDonBanSach_Load(sender, e);
        }
        private void bntLuuHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonBanSachObj hd = new HoaDonBanSachObj();
            addData(hd);
            if (hdControl.addData(hd))
            {
                //theem chi tiet
                DataTable dt = new DataTable();
                dt = (DataTable)dtgvCTHoaDonBS.DataSource;
                if (cthdControl.addData(dt))
                {
                    MessageBox.Show("Thêm chi tiết thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiêt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmHoaDonBanSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmHoaDonBanSach_Load(sender, e);
        }

        private void bntHuyHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                frmHoaDonBanSach_Load(sender, e);
            }
            return;
        }

        private void bntInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nâng cấp");
        }

        private void bntThemCTHoaDon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                if (kiemtraSoLuong(cbTenSach.SelectedValue.ToString(), int.Parse(txtSoLuongBan.Text.Trim())))
                {
                    if (!checktrung(cbTenSach.SelectedValue.ToString()))
                    {
                        DataRow dr = dtCT.NewRow();
                        dr[0] = cbMaCTHoaDon.SelectedValue.ToString();
                        dr[1] = cbTenSach.SelectedValue.ToString();
                        dr[2] = txtDonGia.Text;
                        dr[3] = txtSoLuongBan.Text;
                        dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSoLuongBan.Text)).ToString();
                        dtCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(cbTenSach.SelectedValue.ToString(), int.Parse(txtSoLuongBan.Text));
                    }
                    dtgvCTHoaDonBS.DataSource = dtCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSoLuongBan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMaHoaDon.Focus();
            }
        }

        private void bntBotCTHoaDon_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtCT.Rows.Count)
            {
                dtCT.Rows.RemoveAt(vitriclick);
                dtgvCTHoaDonBS.DataSource = dtCT;
            }
        }
    }
}
