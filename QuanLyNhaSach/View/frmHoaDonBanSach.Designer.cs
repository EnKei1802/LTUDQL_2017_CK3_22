namespace QuanLyNhaSach.View
{
    partial class frmHoaDonBanSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.bntCham = new System.Windows.Forms.Button();
            this.txtNgayLapHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.NgayLapHoaDon = new System.Windows.Forms.Label();
            this.MaKhachHang = new System.Windows.Forms.Label();
            this.MaHoaDon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvHoaDonBanSach = new System.Windows.Forms.DataGridView();
            this.bntTaoMoiHoaDon = new System.Windows.Forms.Button();
            this.bntXoaHoaDon = new System.Windows.Forms.Button();
            this.bntInHoaDon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntBotCTHoaDon = new System.Windows.Forms.Button();
            this.bntThemCTHoaDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbMaHoaDon = new System.Windows.Forms.ComboBox();
            this.cbMaCTHoaDon = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvCTHoaDonBS = new System.Windows.Forms.DataGridView();
            this.bntLuuHoaDon = new System.Windows.Forms.Button();
            this.bntHuyHoaDon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonBanSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHoaDonBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbMaKhachHang);
            this.groupBox1.Controls.Add(this.bntCham);
            this.groupBox1.Controls.Add(this.txtNgayLapHoaDon);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.NgayLapHoaDon);
            this.groupBox1.Controls.Add(this.MaKhachHang);
            this.groupBox1.Controls.Add(this.MaHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(225, 94);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(189, 24);
            this.cbMaKhachHang.TabIndex = 7;
            // 
            // bntCham
            // 
            this.bntCham.Location = new System.Drawing.Point(420, 157);
            this.bntCham.Name = "bntCham";
            this.bntCham.Size = new System.Drawing.Size(28, 23);
            this.bntCham.TabIndex = 6;
            this.bntCham.Text = "...";
            this.bntCham.UseVisualStyleBackColor = true;
            this.bntCham.Click += new System.EventHandler(this.bntCham_Click);
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.Enabled = false;
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(225, 157);
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtNgayLapHoaDon.TabIndex = 5;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(225, 37);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtMaHoaDon.TabIndex = 3;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            // 
            // NgayLapHoaDon
            // 
            this.NgayLapHoaDon.AutoSize = true;
            this.NgayLapHoaDon.Location = new System.Drawing.Point(70, 160);
            this.NgayLapHoaDon.Name = "NgayLapHoaDon";
            this.NgayLapHoaDon.Size = new System.Drawing.Size(120, 17);
            this.NgayLapHoaDon.TabIndex = 2;
            this.NgayLapHoaDon.Text = "Ngày lập hóa đơn";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSize = true;
            this.MaKhachHang.Location = new System.Drawing.Point(70, 101);
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Size = new System.Drawing.Size(115, 17);
            this.MaKhachHang.TabIndex = 1;
            this.MaKhachHang.Text = " Tên khách hàng";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.AutoSize = true;
            this.MaHoaDon.Location = new System.Drawing.Point(70, 42);
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Size = new System.Drawing.Size(83, 17);
            this.MaHoaDon.TabIndex = 0;
            this.MaHoaDon.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvHoaDonBanSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dtgvHoaDonBanSach
            // 
            this.dtgvHoaDonBanSach.AllowUserToAddRows = false;
            this.dtgvHoaDonBanSach.AllowUserToDeleteRows = false;
            this.dtgvHoaDonBanSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHoaDonBanSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDonBanSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDonBanSach.Location = new System.Drawing.Point(0, 34);
            this.dtgvHoaDonBanSach.Name = "dtgvHoaDonBanSach";
            this.dtgvHoaDonBanSach.ReadOnly = true;
            this.dtgvHoaDonBanSach.RowTemplate.Height = 24;
            this.dtgvHoaDonBanSach.Size = new System.Drawing.Size(491, 232);
            this.dtgvHoaDonBanSach.TabIndex = 0;
            // 
            // bntTaoMoiHoaDon
            // 
            this.bntTaoMoiHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntTaoMoiHoaDon.Location = new System.Drawing.Point(30, 254);
            this.bntTaoMoiHoaDon.Name = "bntTaoMoiHoaDon";
            this.bntTaoMoiHoaDon.Size = new System.Drawing.Size(81, 45);
            this.bntTaoMoiHoaDon.TabIndex = 2;
            this.bntTaoMoiHoaDon.Text = "Tạo mới hóa đơn";
            this.bntTaoMoiHoaDon.UseVisualStyleBackColor = true;
            this.bntTaoMoiHoaDon.Click += new System.EventHandler(this.bntTaoMoiHoaDon_Click);
            // 
            // bntXoaHoaDon
            // 
            this.bntXoaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntXoaHoaDon.Location = new System.Drawing.Point(132, 254);
            this.bntXoaHoaDon.Name = "bntXoaHoaDon";
            this.bntXoaHoaDon.Size = new System.Drawing.Size(70, 45);
            this.bntXoaHoaDon.TabIndex = 3;
            this.bntXoaHoaDon.Text = "Xóa hóa đơn";
            this.bntXoaHoaDon.UseVisualStyleBackColor = true;
            this.bntXoaHoaDon.Click += new System.EventHandler(this.bntXoaHoaDon_Click);
            // 
            // bntInHoaDon
            // 
            this.bntInHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntInHoaDon.Location = new System.Drawing.Point(227, 254);
            this.bntInHoaDon.Name = "bntInHoaDon";
            this.bntInHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntInHoaDon.TabIndex = 4;
            this.bntInHoaDon.Text = "In hóa đơn";
            this.bntInHoaDon.UseVisualStyleBackColor = true;
            this.bntInHoaDon.Click += new System.EventHandler(this.bntInHoaDon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.bntBotCTHoaDon);
            this.groupBox3.Controls.Add(this.bntThemCTHoaDon);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSoLuongBan);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.cbTenSach);
            this.groupBox3.Controls.Add(this.cbMaHoaDon);
            this.groupBox3.Controls.Add(this.cbMaCTHoaDon);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(588, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 456);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // bntBotCTHoaDon
            // 
            this.bntBotCTHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntBotCTHoaDon.Location = new System.Drawing.Point(383, 237);
            this.bntBotCTHoaDon.Name = "bntBotCTHoaDon";
            this.bntBotCTHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntBotCTHoaDon.TabIndex = 24;
            this.bntBotCTHoaDon.Text = "Bớt";
            this.bntBotCTHoaDon.UseVisualStyleBackColor = true;
            this.bntBotCTHoaDon.Click += new System.EventHandler(this.bntBotCTHoaDon_Click);
            // 
            // bntThemCTHoaDon
            // 
            this.bntThemCTHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntThemCTHoaDon.Location = new System.Drawing.Point(144, 237);
            this.bntThemCTHoaDon.Name = "bntThemCTHoaDon";
            this.bntThemCTHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntThemCTHoaDon.TabIndex = 23;
            this.bntThemCTHoaDon.Text = "Thêm";
            this.bntThemCTHoaDon.UseVisualStyleBackColor = true;
            this.bntThemCTHoaDon.Click += new System.EventHandler(this.bntThemCTHoaDon_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "(VNĐ)";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuongBan.Location = new System.Drawing.Point(425, 201);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuongBan.TabIndex = 21;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(123, 198);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia.TabIndex = 20;
            // 
            // cbTenSach
            // 
            this.cbTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(213, 119);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(158, 24);
            this.cbTenSach.TabIndex = 19;
            // 
            // cbMaHoaDon
            // 
            this.cbMaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaHoaDon.FormattingEnabled = true;
            this.cbMaHoaDon.Location = new System.Drawing.Point(213, 76);
            this.cbMaHoaDon.Name = "cbMaHoaDon";
            this.cbMaHoaDon.Size = new System.Drawing.Size(158, 24);
            this.cbMaHoaDon.TabIndex = 18;
            // 
            // cbMaCTHoaDon
            // 
            this.cbMaCTHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaCTHoaDon.FormattingEnabled = true;
            this.cbMaCTHoaDon.Location = new System.Drawing.Point(213, 33);
            this.cbMaCTHoaDon.Name = "cbMaCTHoaDon";
            this.cbMaCTHoaDon.Size = new System.Drawing.Size(158, 24);
            this.cbMaCTHoaDon.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(425, 212);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá bán";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số lượng bán";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Sách";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã chi tiết hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvCTHoaDonBS);
            this.groupBox4.Location = new System.Drawing.Point(6, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 169);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sách bán";
            // 
            // dtgvCTHoaDonBS
            // 
            this.dtgvCTHoaDonBS.AllowUserToAddRows = false;
            this.dtgvCTHoaDonBS.AllowUserToDeleteRows = false;
            this.dtgvCTHoaDonBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvCTHoaDonBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCTHoaDonBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHoaDonBS.Location = new System.Drawing.Point(0, 34);
            this.dtgvCTHoaDonBS.Name = "dtgvCTHoaDonBS";
            this.dtgvCTHoaDonBS.ReadOnly = true;
            this.dtgvCTHoaDonBS.RowTemplate.Height = 24;
            this.dtgvCTHoaDonBS.Size = new System.Drawing.Size(551, 135);
            this.dtgvCTHoaDonBS.TabIndex = 9;
            this.dtgvCTHoaDonBS.DataSourceChanged += new System.EventHandler(this.dtgvCTHoaDonBS_DataSourceChanged);
            // 
            // bntLuuHoaDon
            // 
            this.bntLuuHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntLuuHoaDon.Location = new System.Drawing.Point(332, 254);
            this.bntLuuHoaDon.Name = "bntLuuHoaDon";
            this.bntLuuHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntLuuHoaDon.TabIndex = 9;
            this.bntLuuHoaDon.Text = "Lưu hóa đơn";
            this.bntLuuHoaDon.UseVisualStyleBackColor = true;
            this.bntLuuHoaDon.Click += new System.EventHandler(this.bntLuuHoaDon_Click);
            // 
            // bntHuyHoaDon
            // 
            this.bntHuyHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntHuyHoaDon.Location = new System.Drawing.Point(430, 251);
            this.bntHuyHoaDon.Name = "bntHuyHoaDon";
            this.bntHuyHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntHuyHoaDon.TabIndex = 10;
            this.bntHuyHoaDon.Text = "Hủy hóa đơn";
            this.bntHuyHoaDon.UseVisualStyleBackColor = true;
            this.bntHuyHoaDon.Click += new System.EventHandler(this.bntHuyHoaDon_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(154, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "0";
            // 
            // frmHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 507);
            this.Controls.Add(this.bntHuyHoaDon);
            this.Controls.Add(this.bntLuuHoaDon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bntInHoaDon);
            this.Controls.Add(this.bntXoaHoaDon);
            this.Controls.Add(this.bntTaoMoiHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDonBanSach";
            this.Text = "frmHoaDonBanSach";
            this.Load += new System.EventHandler(this.frmHoaDonBanSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonBanSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHoaDonBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvHoaDonBanSach;
        private System.Windows.Forms.TextBox txtNgayLapHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label NgayLapHoaDon;
        private System.Windows.Forms.Label MaKhachHang;
        private System.Windows.Forms.Label MaHoaDon;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.Button bntCham;
        private System.Windows.Forms.Button bntTaoMoiHoaDon;
        private System.Windows.Forms.Button bntXoaHoaDon;
        private System.Windows.Forms.Button bntInHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntBotCTHoaDon;
        private System.Windows.Forms.Button bntThemCTHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbMaHoaDon;
        private System.Windows.Forms.ComboBox cbMaCTHoaDon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvCTHoaDonBS;
        private System.Windows.Forms.Button bntLuuHoaDon;
        private System.Windows.Forms.Button bntHuyHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}