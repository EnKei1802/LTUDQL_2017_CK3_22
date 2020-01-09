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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvHoaDonBanSach = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.Label();
            this.MaKhachHang = new System.Windows.Forms.Label();
            this.NgayLapHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtNgayLapHoaDon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.bntTaoMoiHoaDon = new System.Windows.Forms.Button();
            this.bntXoaHoaDon = new System.Windows.Forms.Button();
            this.bntInHoaDon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bntLuuHoaDon = new System.Windows.Forms.Button();
            this.bntHuyHoaDon = new System.Windows.Forms.Button();
            this.bntThemCTHoaDon = new System.Windows.Forms.Button();
            this.bntHuyCTHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonBanSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaKhachHang);
            this.groupBox1.Controls.Add(this.button1);
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
            // groupBox2
            // 
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
            this.dtgvHoaDonBanSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDonBanSach.Location = new System.Drawing.Point(0, 34);
            this.dtgvHoaDonBanSach.Name = "dtgvHoaDonBanSach";
            this.dtgvHoaDonBanSach.RowTemplate.Height = 24;
            this.dtgvHoaDonBanSach.Size = new System.Drawing.Size(491, 232);
            this.dtgvHoaDonBanSach.TabIndex = 0;
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
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSize = true;
            this.MaKhachHang.Location = new System.Drawing.Point(70, 101);
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Size = new System.Drawing.Size(105, 17);
            this.MaKhachHang.TabIndex = 1;
            this.MaKhachHang.Text = "Mã khách hàng";
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
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(225, 37);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtMaHoaDon.TabIndex = 3;
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(225, 157);
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtNgayLapHoaDon.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(225, 94);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(189, 24);
            this.cbMaKhachHang.TabIndex = 7;
            // 
            // bntTaoMoiHoaDon
            // 
            this.bntTaoMoiHoaDon.Location = new System.Drawing.Point(30, 254);
            this.bntTaoMoiHoaDon.Name = "bntTaoMoiHoaDon";
            this.bntTaoMoiHoaDon.Size = new System.Drawing.Size(81, 45);
            this.bntTaoMoiHoaDon.TabIndex = 2;
            this.bntTaoMoiHoaDon.Text = "Tạo mới hóa đơn";
            this.bntTaoMoiHoaDon.UseVisualStyleBackColor = true;
            // 
            // bntXoaHoaDon
            // 
            this.bntXoaHoaDon.Location = new System.Drawing.Point(132, 254);
            this.bntXoaHoaDon.Name = "bntXoaHoaDon";
            this.bntXoaHoaDon.Size = new System.Drawing.Size(70, 45);
            this.bntXoaHoaDon.TabIndex = 3;
            this.bntXoaHoaDon.Text = "Xóa hóa đơn";
            this.bntXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // bntInHoaDon
            // 
            this.bntInHoaDon.Location = new System.Drawing.Point(227, 254);
            this.bntInHoaDon.Name = "bntInHoaDon";
            this.bntInHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntInHoaDon.TabIndex = 4;
            this.bntInHoaDon.Text = "In hóa đơn";
            this.bntInHoaDon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntHuyCTHoaDon);
            this.groupBox3.Controls.Add(this.bntThemCTHoaDon);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(586, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 456);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 135);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(6, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 169);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sách bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã chi tiết hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số lượng bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá bán";
            // 
            // tabControl1
            // 
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(213, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 24);
            this.comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(213, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 24);
            this.comboBox3.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "(VNĐ)";
            // 
            // bntLuuHoaDon
            // 
            this.bntLuuHoaDon.Location = new System.Drawing.Point(332, 254);
            this.bntLuuHoaDon.Name = "bntLuuHoaDon";
            this.bntLuuHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntLuuHoaDon.TabIndex = 9;
            this.bntLuuHoaDon.Text = "Lưu hóa đơn";
            this.bntLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // bntHuyHoaDon
            // 
            this.bntHuyHoaDon.Location = new System.Drawing.Point(430, 251);
            this.bntHuyHoaDon.Name = "bntHuyHoaDon";
            this.bntHuyHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntHuyHoaDon.TabIndex = 10;
            this.bntHuyHoaDon.Text = "Hủy hóa đơn";
            this.bntHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // bntThemCTHoaDon
            // 
            this.bntThemCTHoaDon.Location = new System.Drawing.Point(190, 237);
            this.bntThemCTHoaDon.Name = "bntThemCTHoaDon";
            this.bntThemCTHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntThemCTHoaDon.TabIndex = 23;
            this.bntThemCTHoaDon.Text = "Thêm";
            this.bntThemCTHoaDon.UseVisualStyleBackColor = true;
            // 
            // bntHuyCTHoaDon
            // 
            this.bntHuyCTHoaDon.Location = new System.Drawing.Point(331, 236);
            this.bntHuyCTHoaDon.Name = "bntHuyCTHoaDon";
            this.bntHuyCTHoaDon.Size = new System.Drawing.Size(79, 45);
            this.bntHuyCTHoaDon.TabIndex = 24;
            this.bntHuyCTHoaDon.Text = "Bớt";
            this.bntHuyCTHoaDon.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonBanSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntTaoMoiHoaDon;
        private System.Windows.Forms.Button bntXoaHoaDon;
        private System.Windows.Forms.Button bntInHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntHuyCTHoaDon;
        private System.Windows.Forms.Button bntThemCTHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntLuuHoaDon;
        private System.Windows.Forms.Button bntHuyHoaDon;
    }
}