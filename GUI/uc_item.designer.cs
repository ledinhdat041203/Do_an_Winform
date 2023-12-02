namespace GUI
{
    partial class uc_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.btnChiTietSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemVaoGioHang = new Guna.UI2.WinForms.Guna2Button();
            this.pcAnh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.Location = new System.Drawing.Point(9, 152);
            this.lbTenHang.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(129, 25);
            this.lbTenHang.TabIndex = 1;
            this.lbTenHang.Text = "Tên sản phẩm";
            this.lbTenHang.Click += new System.EventHandler(this.lbTenHang_Click);
            this.lbTenHang.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lbTenHang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(10, 176);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(35, 23);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Giá";
            this.lbDonGia.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lbDonGia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // btnChiTietSanPham
            // 
            this.btnChiTietSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.btnChiTietSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietSanPham.ForeColor = System.Drawing.Color.White;
            this.btnChiTietSanPham.Location = new System.Drawing.Point(26, 206);
            this.btnChiTietSanPham.Name = "btnChiTietSanPham";
            this.btnChiTietSanPham.Size = new System.Drawing.Size(150, 32);
            this.btnChiTietSanPham.TabIndex = 5;
            this.btnChiTietSanPham.Text = "Chi tiết";
            this.btnChiTietSanPham.Visible = false;
            this.btnChiTietSanPham.Click += new System.EventHandler(this.btnChiTietSanPham_Click);
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoGioHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoGioHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVaoGioHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVaoGioHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.btnThemVaoGioHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGioHang.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(26, 244);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(150, 32);
            this.btnThemVaoGioHang.TabIndex = 6;
            this.btnThemVaoGioHang.Text = "Thêm vào giỏ";
            this.btnThemVaoGioHang.Visible = false;
            this.btnThemVaoGioHang.Click += new System.EventHandler(this.btnThemVaoGioHang_Click);
            // 
            // pcAnh
            // 
            this.pcAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcAnh.Image = global::GUI.Properties.Resources._360_F_496632203_ebd1fmChidWFuaYcoIKgRAAQqo00ReUC;
            this.pcAnh.Location = new System.Drawing.Point(0, 0);
            this.pcAnh.Name = "pcAnh";
            this.pcAnh.Size = new System.Drawing.Size(208, 150);
            this.pcAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAnh.TabIndex = 7;
            this.pcAnh.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThemVaoGioHang);
            this.panel1.Controls.Add(this.lbDonGia);
            this.panel1.Controls.Add(this.btnChiTietSanPham);
            this.panel1.Controls.Add(this.lbTenHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 288);
            this.panel1.TabIndex = 8;
            // 
            // uc_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pcAnh);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "uc_item";
            this.Size = new System.Drawing.Size(208, 288);
            this.Load += new System.EventHandler(this.uc_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbDonGia;
        private Guna.UI2.WinForms.Guna2Button btnChiTietSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemVaoGioHang;
        private System.Windows.Forms.PictureBox pcAnh;
        private System.Windows.Forms.Panel panel1;
    }
}
