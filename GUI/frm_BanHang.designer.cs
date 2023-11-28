namespace GUI
{
    partial class frm_BanHang
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.btnKhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpHang = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbVoucher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbTongGT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVoucher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpChiTietDonBan = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAll);
            this.guna2Panel1.Controls.Add(this.cbLoai);
            this.guna2Panel1.Controls.Add(this.btnKhachhang);
            this.guna2Panel1.Controls.Add(this.txtTenHang);
            this.guna2Panel1.Controls.Add(this.lbTenKH);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1051, 70);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnAll
            // 
            this.btnAll.BorderColor = System.Drawing.Color.Silver;
            this.btnAll.BorderRadius = 5;
            this.btnAll.BorderThickness = 1;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::GUI.Properties.Resources.all__1_;
            this.btnAll.Location = new System.Drawing.Point(576, 23);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(35, 35);
            this.btnAll.TabIndex = 10;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(35, 23);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(253, 36);
            this.cbLoai.TabIndex = 9;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackgroundImage = global::GUI.Properties.Resources.icons8_pencil_50;
            this.btnKhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachhang.FillColor = System.Drawing.Color.Empty;
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Location = new System.Drawing.Point(1003, 19);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(32, 32);
            this.btnKhachhang.TabIndex = 7;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.AutoRoundedCorners = true;
            this.txtTenHang.BackColor = System.Drawing.Color.Transparent;
            this.txtTenHang.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTenHang.BorderRadius = 17;
            this.txtTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHang.DefaultText = "";
            this.txtTenHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHang.IconLeft = global::GUI.Properties.Resources.icons8_search_30;
            this.txtTenHang.Location = new System.Drawing.Point(321, 23);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenHang.PlaceholderText = "Tìm sản phẩm";
            this.txtTenHang.SelectedText = "";
            this.txtTenHang.Size = new System.Drawing.Size(236, 36);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(703, 23);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(119, 28);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Khách hàng";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 70);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1051, 662);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.flpHang);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(705, 662);
            this.guna2Panel4.TabIndex = 1;
            // 
            // flpHang
            // 
            this.flpHang.AutoScroll = true;
            this.flpHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHang.Location = new System.Drawing.Point(0, 0);
            this.flpHang.Name = "flpHang";
            this.flpHang.Padding = new System.Windows.Forms.Padding(25, 20, 0, 0);
            this.flpHang.Size = new System.Drawing.Size(705, 662);
            this.flpHang.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Panel6);
            this.guna2Panel3.Controls.Add(this.guna2Panel5);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(705, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(346, 662);
            this.guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 6;
            this.guna2Panel6.Controls.Add(this.cbVoucher);
            this.guna2Panel6.Controls.Add(this.lbThanhTien);
            this.guna2Panel6.Controls.Add(this.lbTongGT);
            this.guna2Panel6.Controls.Add(this.label5);
            this.guna2Panel6.Controls.Add(this.lbVoucher);
            this.guna2Panel6.Controls.Add(this.label3);
            this.guna2Panel6.Controls.Add(this.btnThanhToan);
            this.guna2Panel6.Controls.Add(this.guna2Button1);
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(18, 381);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(312, 226);
            this.guna2Panel6.TabIndex = 1;
            // 
            // cbVoucher
            // 
            this.cbVoucher.BackColor = System.Drawing.Color.Transparent;
            this.cbVoucher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoucher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVoucher.ItemHeight = 30;
            this.cbVoucher.Location = new System.Drawing.Point(113, 61);
            this.cbVoucher.Name = "cbVoucher";
            this.cbVoucher.Size = new System.Drawing.Size(182, 36);
            this.cbVoucher.TabIndex = 9;
            this.cbVoucher.SelectedIndexChanged += new System.EventHandler(this.cbVoucher_SelectedIndexChanged);
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbThanhTien.Location = new System.Drawing.Point(185, 112);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(19, 23);
            this.lbThanhTien.TabIndex = 8;
            this.lbThanhTien.Text = "0";
            // 
            // lbTongGT
            // 
            this.lbTongGT.AutoSize = true;
            this.lbTongGT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongGT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTongGT.Location = new System.Drawing.Point(185, 22);
            this.lbTongGT.Name = "lbTongGT";
            this.lbTongGT.Size = new System.Drawing.Size(19, 23);
            this.lbTongGT.TabIndex = 6;
            this.lbTongGT.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thành tiền";
            // 
            // lbVoucher
            // 
            this.lbVoucher.AutoSize = true;
            this.lbVoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoucher.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbVoucher.Location = new System.Drawing.Point(21, 66);
            this.lbVoucher.Name = "lbVoucher";
            this.lbVoucher.Size = new System.Drawing.Size(72, 23);
            this.lbVoucher.TabIndex = 4;
            this.lbVoucher.Text = "voucher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng cộng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 8;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(66)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(146, 166);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(141, 48);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Tomato;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Tomato;
            this.guna2Button1.Location = new System.Drawing.Point(24, 166);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(101, 48);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Lưu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel5.Controls.Add(this.flpChiTietDonBan);
            this.guna2Panel5.Controls.Add(this.guna2Panel7);
            this.guna2Panel5.Location = new System.Drawing.Point(6, 19);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(328, 329);
            this.guna2Panel5.TabIndex = 0;
            // 
            // flpChiTietDonBan
            // 
            this.flpChiTietDonBan.AutoScroll = true;
            this.flpChiTietDonBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpChiTietDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChiTietDonBan.Location = new System.Drawing.Point(0, 53);
            this.flpChiTietDonBan.Name = "flpChiTietDonBan";
            this.flpChiTietDonBan.Size = new System.Drawing.Size(328, 276);
            this.flpChiTietDonBan.TabIndex = 1;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 6;
            this.guna2Panel7.Controls.Add(this.label2);
            this.guna2Panel7.CustomizableEdges.BottomLeft = false;
            this.guna2Panel7.CustomizableEdges.BottomRight = false;
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.FillColor = System.Drawing.Color.Tomato;
            this.guna2Panel7.ForeColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(328, 53);
            this.guna2Panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn mới";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnKhachhang;
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 732);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbTenKH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpHang;
        //private uc_item uc_item1;
        //private uc_item uc_item2;
        //private uc_item uc_item3;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbTongGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbVoucher;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnKhachhang;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.FlowLayoutPanel flpChiTietDonBan;
        private Guna.UI2.WinForms.Guna2ComboBox cbVoucher;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        //private uc_item uc_item4;
        //private uc_item uc_item5;
        //private uc_item uc_item6;
        //private uc_item uc_item7;
        //private uc_item uc_item8;
        //private uc_item uc_item9;
    }
}