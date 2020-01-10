namespace QuanLyNhaSach.View
{
    partial class frmBaoCaoCongNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPhatSinh = new System.Windows.Forms.TextBox();
            this.txtNoCuoi = new System.Windows.Forms.TextBox();
            this.txtNoDau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBaoCaoChiTietCongNo = new System.Windows.Forms.TextBox();
            this.dgvDSCTBaoCaoCongNo = new System.Windows.Forms.DataGridView();
            this.bntHuyBaoCaoCTCongNo = new System.Windows.Forms.Button();
            this.bntThemBaoCaoCTCongNo = new System.Windows.Forms.Button();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cbMaBaoCaoCongNo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThang = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMaBaoCaoCongNo = new System.Windows.Forms.TextBox();
            this.NgayLap = new System.Windows.Forms.Label();
            this.MaPhieuNhap = new System.Windows.Forms.Label();
            this.btnTaoBCCongNo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTBaoCaoCongNo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPhatSinh);
            this.groupBox3.Controls.Add(this.txtNoCuoi);
            this.groupBox3.Controls.Add(this.txtNoDau);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMaBaoCaoChiTietCongNo);
            this.groupBox3.Controls.Add(this.dgvDSCTBaoCaoCongNo);
            this.groupBox3.Controls.Add(this.bntHuyBaoCaoCTCongNo);
            this.groupBox3.Controls.Add(this.bntThemBaoCaoCTCongNo);
            this.groupBox3.Controls.Add(this.cbMaKhachHang);
            this.groupBox3.Controls.Add(this.cbMaBaoCaoCongNo);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(643, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(563, 480);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết báo cáo công nợ";
            // 
            // txtPhatSinh
            // 
            this.txtPhatSinh.Location = new System.Drawing.Point(369, 158);
            this.txtPhatSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhatSinh.Name = "txtPhatSinh";
            this.txtPhatSinh.Size = new System.Drawing.Size(169, 22);
            this.txtPhatSinh.TabIndex = 32;
            // 
            // txtNoCuoi
            // 
            this.txtNoCuoi.Location = new System.Drawing.Point(264, 199);
            this.txtNoCuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoCuoi.Name = "txtNoCuoi";
            this.txtNoCuoi.Size = new System.Drawing.Size(169, 22);
            this.txtNoCuoi.TabIndex = 31;
            // 
            // txtNoDau
            // 
            this.txtNoDau.Location = new System.Drawing.Point(99, 155);
            this.txtNoDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoDau.Name = "txtNoDau";
            this.txtNoDau.Size = new System.Drawing.Size(169, 22);
            this.txtNoDau.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nợ cuối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phát sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nợ đầu";
            // 
            // txtMaBaoCaoChiTietCongNo
            // 
            this.txtMaBaoCaoChiTietCongNo.Location = new System.Drawing.Point(264, 116);
            this.txtMaBaoCaoChiTietCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBaoCaoChiTietCongNo.Name = "txtMaBaoCaoChiTietCongNo";
            this.txtMaBaoCaoChiTietCongNo.Size = new System.Drawing.Size(159, 22);
            this.txtMaBaoCaoChiTietCongNo.TabIndex = 25;
            // 
            // dgvDSCTBaoCaoCongNo
            // 
            this.dgvDSCTBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTBaoCaoCongNo.Location = new System.Drawing.Point(5, 346);
            this.dgvDSCTBaoCaoCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSCTBaoCaoCongNo.Name = "dgvDSCTBaoCaoCongNo";
            this.dgvDSCTBaoCaoCongNo.RowTemplate.Height = 24;
            this.dgvDSCTBaoCaoCongNo.Size = new System.Drawing.Size(551, 134);
            this.dgvDSCTBaoCaoCongNo.TabIndex = 9;
            // 
            // bntHuyBaoCaoCTCongNo
            // 
            this.bntHuyBaoCaoCTCongNo.Location = new System.Drawing.Point(331, 236);
            this.bntHuyBaoCaoCTCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHuyBaoCaoCTCongNo.Name = "bntHuyBaoCaoCTCongNo";
            this.bntHuyBaoCaoCTCongNo.Size = new System.Drawing.Size(79, 46);
            this.bntHuyBaoCaoCTCongNo.TabIndex = 24;
            this.bntHuyBaoCaoCTCongNo.Text = "Bớt";
            this.bntHuyBaoCaoCTCongNo.UseVisualStyleBackColor = true;
            // 
            // bntThemBaoCaoCTCongNo
            // 
            this.bntThemBaoCaoCTCongNo.Location = new System.Drawing.Point(189, 238);
            this.bntThemBaoCaoCTCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntThemBaoCaoCTCongNo.Name = "bntThemBaoCaoCTCongNo";
            this.bntThemBaoCaoCTCongNo.Size = new System.Drawing.Size(79, 46);
            this.bntThemBaoCaoCTCongNo.TabIndex = 23;
            this.bntThemBaoCaoCTCongNo.Text = "Thêm";
            this.bntThemBaoCaoCTCongNo.UseVisualStyleBackColor = true;
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(264, 76);
            this.cbMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(159, 24);
            this.cbMaKhachHang.TabIndex = 18;
            // 
            // cbMaBaoCaoCongNo
            // 
            this.cbMaBaoCaoCongNo.FormattingEnabled = true;
            this.cbMaBaoCaoCongNo.Location = new System.Drawing.Point(264, 30);
            this.cbMaBaoCaoCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaBaoCaoCongNo.Name = "cbMaBaoCaoCongNo";
            this.cbMaBaoCaoCongNo.Size = new System.Drawing.Size(159, 24);
            this.cbMaBaoCaoCongNo.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(425, 212);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 7);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Báo cáo công nợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã báo cáo chi tiết công nợ";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(5, 311);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(551, 165);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chi tiết báo cáo công nợ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(49, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(497, 169);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgvDSPhieuNhap
            // 
            this.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuNhap.Location = new System.Drawing.Point(0, 34);
            this.dgvDSPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap";
            this.dgvDSPhieuNhap.RowTemplate.Height = 24;
            this.dgvDSPhieuNhap.Size = new System.Drawing.Size(491, 134);
            this.dgvDSPhieuNhap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThang);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Controls.Add(this.txtMaBaoCaoCongNo);
            this.groupBox1.Controls.Add(this.NgayLap);
            this.groupBox1.Controls.Add(this.MaPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(49, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(497, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo công nợ";
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(433, 111);
            this.btnThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(28, 23);
            this.btnThang.TabIndex = 6;
            this.btnThang.Text = "...";
            this.btnThang.UseVisualStyleBackColor = true;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(225, 110);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(189, 22);
            this.txtThang.TabIndex = 5;
            // 
            // txtMaBaoCaoCongNo
            // 
            this.txtMaBaoCaoCongNo.Location = new System.Drawing.Point(225, 37);
            this.txtMaBaoCaoCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo";
            this.txtMaBaoCaoCongNo.Size = new System.Drawing.Size(189, 22);
            this.txtMaBaoCaoCongNo.TabIndex = 3;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSize = true;
            this.NgayLap.Location = new System.Drawing.Point(69, 113);
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Size = new System.Drawing.Size(127, 17);
            this.NgayLap.TabIndex = 2;
            this.NgayLap.Text = "Tháng lập công nợ";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.AutoSize = true;
            this.MaPhieuNhap.Location = new System.Drawing.Point(69, 42);
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.Size = new System.Drawing.Size(137, 17);
            this.MaPhieuNhap.TabIndex = 0;
            this.MaPhieuNhap.Text = "Mã báo cáo công nợ";
            // 
            // btnTaoBCCongNo
            // 
            this.btnTaoBCCongNo.Location = new System.Drawing.Point(21, 259);
            this.btnTaoBCCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoBCCongNo.Name = "btnTaoBCCongNo";
            this.btnTaoBCCongNo.Size = new System.Drawing.Size(79, 46);
            this.btnTaoBCCongNo.TabIndex = 24;
            this.btnTaoBCCongNo.Text = "Tạo báo cáo công nợ";
            this.btnTaoBCCongNo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 46);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 46);
            this.button3.TabIndex = 26;
            this.button3.Text = "In báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(384, 261);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 46);
            this.button5.TabIndex = 28;
            this.button5.Text = "Hủy báo cáo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 527);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTaoBCCongNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "Báo cáo công nợ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTBaoCaoCongNo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaBaoCaoChiTietCongNo;
        private System.Windows.Forms.DataGridView dgvDSCTBaoCaoCongNo;
        private System.Windows.Forms.Button bntHuyBaoCaoCTCongNo;
        private System.Windows.Forms.Button bntThemBaoCaoCTCongNo;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.ComboBox cbMaBaoCaoCongNo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMaBaoCaoCongNo;
        private System.Windows.Forms.Label NgayLap;
        private System.Windows.Forms.Label MaPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhatSinh;
        private System.Windows.Forms.TextBox txtNoCuoi;
        private System.Windows.Forms.Button btnTaoBCCongNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}