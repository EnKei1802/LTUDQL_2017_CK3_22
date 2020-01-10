namespace QuanLyNhaSach.View
{
    partial class frmTraCuu
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
            this.bntTraCuuSach = new System.Windows.Forms.Button();
            this.bntTraCuuKhachHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntTraCuuSach
            // 
            this.bntTraCuuSach.Location = new System.Drawing.Point(213, 197);
            this.bntTraCuuSach.Name = "bntTraCuuSach";
            this.bntTraCuuSach.Size = new System.Drawing.Size(137, 62);
            this.bntTraCuuSach.TabIndex = 0;
            this.bntTraCuuSach.Text = "Tra cứu sách";
            this.bntTraCuuSach.UseVisualStyleBackColor = true;
            this.bntTraCuuSach.Click += new System.EventHandler(this.bntTraCuuSach_Click);
            // 
            // bntTraCuuKhachHang
            // 
            this.bntTraCuuKhachHang.Location = new System.Drawing.Point(464, 197);
            this.bntTraCuuKhachHang.Name = "bntTraCuuKhachHang";
            this.bntTraCuuKhachHang.Size = new System.Drawing.Size(147, 62);
            this.bntTraCuuKhachHang.TabIndex = 1;
            this.bntTraCuuKhachHang.Text = "Tra cứu khách hàng";
            this.bntTraCuuKhachHang.UseVisualStyleBackColor = true;
            this.bntTraCuuKhachHang.Click += new System.EventHandler(this.bntTraCuuKhachHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin mời lựa chọn:";
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntTraCuuKhachHang);
            this.Controls.Add(this.bntTraCuuSach);
            this.Name = "frmTraCuu";
            this.Text = "frmTraCuu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntTraCuuSach;
        private System.Windows.Forms.Button bntTraCuuKhachHang;
        private System.Windows.Forms.Label label1;
    }
}