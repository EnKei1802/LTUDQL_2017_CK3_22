using QuanLyNhaSach.Control;
using QuanLyNhaSach.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Object;
using QuanLyNhaSach.Control;


namespace QuanLyNhaSach.View
{
    public partial class frmPhieuNhapSach : Form
    {
        PhieuNhapControl pnControl = new PhieuNhapControl();
        ChiTietPhieuNhapControl ctpnControl = new ChiTietPhieuNhapControl();
        DataTable dtCT = new System.Data.DataTable();
        SachControl sachControl = new SachControl();
        int vitriclick = 0;
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = pnControl.getDaTa();
            dgvDSPhieuNhap.DataSource = dt;
            bingdingPhieuNhap();
            txtNgayLap.Enabled = true;
        }
        private void bingdingPhieuNhap()
        {
            txtMaPhieuNhap.DataBindings.Clear();
            txtMaPhieuNhap.DataBindings.Add("Text", dgvDSPhieuNhap.DataSource, "MaPhieuNhap");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dgvDSPhieuNhap.DataSource, "NgayNhap");

        }
        private void Dis_enCTHD(bool e)
        {
            cbMaCTPhieuNhap.Enabled = e;
            cbMaPhieuNhap.Enabled = e;
            txtMaPhieuNhap.Enabled = e;
            bntTaoMoiPhieuNhap.Enabled = !e;
            bntXoaPhieuNhap.Enabled = !e;
            bntInPhieuNhap.Enabled = !e;
            bntLuuPhieuNhap.Enabled = e;
            bntHuyPhieuNhap.Enabled = e;           
            bntThemCTPhieuNhapSach.Enabled = e;
            bntHuyCTPhieuNhapSach.Enabled = e;
        }
        private void clearData()
        {
            txtMaPhieuNhap.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
        }
        private void addData(PhieuNhapObj hdObj)
        {
            hdObj.MaPhieuNhap = txtMaPhieuNhap.Text.Trim();
            hdObj.NgayNhap = Convert.ToDateTime(txtNgayLap.Text.Trim());

        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt =ctpnControl.getDaTa(txtMaPhieuNhap.Text.Trim());
                dgvDSCTPhieuNhap.DataSource = dt;
            }
            catch
            {
                dgvDSCTPhieuNhap.DataSource = null;
            }
        }
        private bool checktrung(string masach)
        {
            for (int i = 0; i < dgvDSCTPhieuNhap.Rows.Count; i++)
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

        private void bntTaoMoiPhieuNhap_Click(object sender, EventArgs e)
        {
            Dis_enCTHD(true);
            clearData();
            dtCT.Rows.Clear();
            dtCT.Columns.Add("MaPhieuNhap");
            dtCT.Columns.Add("TenSach");
            dtCT.Columns.Add("SoLuongNhap");
        }

        private void bntInPhieuNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được nâng cấp");
        }

        private void bntXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắn chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xóa
                if (pnControl.deleteData(txtMaPhieuNhap.Text.Trim()))
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
            frmPhieuNhapSach_Load(sender, e);
        }
       
        private void bntLuuPhieuNhap_Click(object sender, EventArgs e)
        {
           PhieuNhapObj pn = new PhieuNhapObj();
            addData(pn);
            if (pnControl.addData(pn))
            {
                //theem chi tiet
                DataTable dt = new DataTable();
                dt = (DataTable)dgvDSCTPhieuNhap.DataSource;
                if (ctpnControl.addData(dt))
                {
                    MessageBox.Show("Thêm chi tiết thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiêt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmPhieuNhapSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmPhieuNhapSach_Load(sender, e);
        }

        private void bntHuyPhieuNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                frmPhieuNhapSach_Load(sender, e);
            }
            return;
        }
        private bool kiemtraSoLuong(string masach, int sl)
        {
            DataTable dt = new DataTable();
            dt = sachControl.GetData("where MaSach = '" + txtTenSach.Text + "' and SoLuongTon >=" + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        private void bntThemCTPhieuNhapSach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                if (kiemtraSoLuong(txtTenSach.Text, int.Parse(txtSoLuongNhap.Text.Trim())))
                {
                    if (!checktrung(txtTenSach.Text))
                    {
                        DataRow dr = dtCT.NewRow();
                        dr[0] = cbMaCTPhieuNhap.SelectedValue.ToString();
                        dr[1] = cbMaPhieuNhap.SelectedValue.ToString();
                        dr[2] = txtTenSach.Text;
                        dr[3] = txtSoLuongNhap.Text;
                        dtCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(txtTenSach.Text, int.Parse(txtSoLuongNhap.Text));
                    }
                    dgvDSCTPhieuNhap.DataSource = dtCT;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMaPhieuNhap.Focus();
            }
        }

        private void bntHuyCTPhieuNhapSach_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtCT.Rows.Count)
            {
                dtCT.Rows.RemoveAt(vitriclick);
                dgvDSCTPhieuNhap.DataSource = dtCT;
            }
        }
    }
}
