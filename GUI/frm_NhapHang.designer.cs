namespace GUI
{
    partial class frm_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhapHang));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtTenHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemDon = new Guna.UI2.WinForms.Guna2Button();
            this.pnDonNhap = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTongGT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpChiTietDon = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpHang = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnDonNhap.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.cbLoai);
            this.guna2Panel2.Controls.Add(this.txtTenHang);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1088, 72);
            this.guna2Panel2.TabIndex = 0;
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(50, 23);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(253, 36);
            this.cbLoai.TabIndex = 8;
            this.cbLoai.Text = "Danh mục sản phẩm";
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
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
            this.txtTenHang.Location = new System.Drawing.Point(329, 23);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenHang.PlaceholderText = "Tìm sản phẩm";
            this.txtTenHang.SelectedText = "";
            this.txtTenHang.Size = new System.Drawing.Size(289, 36);
            this.txtTenHang.TabIndex = 7;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btnThemhang);
            this.guna2Panel4.Controls.Add(this.btnThemDon);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(742, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(346, 72);
            this.guna2Panel4.TabIndex = 2;
            // 
            // btnThemhang
            // 
            this.btnThemhang.BackgroundImage = global::GUI.Properties.Resources.add__2_;
            this.btnThemhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemhang.FillColor = System.Drawing.Color.Empty;
            this.btnThemhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemhang.ForeColor = System.Drawing.Color.White;
            this.btnThemhang.Location = new System.Drawing.Point(31, 23);
            this.btnThemhang.Name = "btnThemhang";
            this.btnThemhang.Size = new System.Drawing.Size(32, 32);
            this.btnThemhang.TabIndex = 8;
            this.btnThemhang.Click += new System.EventHandler(this.btnThemhang_Click);
            // 
            // btnThemDon
            // 
            this.btnThemDon.BorderRadius = 6;
            this.btnThemDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.btnThemDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDon.ForeColor = System.Drawing.Color.White;
            this.btnThemDon.Location = new System.Drawing.Point(128, 16);
            this.btnThemDon.Name = "btnThemDon";
            this.btnThemDon.Size = new System.Drawing.Size(154, 43);
            this.btnThemDon.TabIndex = 15;
            this.btnThemDon.Text = "Thêm đơn nhập";
            this.btnThemDon.Click += new System.EventHandler(this.btnThemDon_Click);
            // 
            // pnDonNhap
            // 
            this.pnDonNhap.Controls.Add(this.guna2Panel6);
            this.pnDonNhap.Controls.Add(this.guna2Panel5);
            this.pnDonNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDonNhap.Location = new System.Drawing.Point(742, 72);
            this.pnDonNhap.Name = "pnDonNhap";
            this.pnDonNhap.Size = new System.Drawing.Size(346, 660);
            this.pnDonNhap.TabIndex = 1;
            this.pnDonNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 6;
            this.guna2Panel6.Controls.Add(this.lbTongGT);
            this.guna2Panel6.Controls.Add(this.label5);
            this.guna2Panel6.Controls.Add(this.guna2Button2);
            this.guna2Panel6.Controls.Add(this.guna2Button1);
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(3, 393);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(337, 136);
            this.guna2Panel6.TabIndex = 5;
            // 
            // lbTongGT
            // 
            this.lbTongGT.AutoSize = true;
            this.lbTongGT.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbTongGT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.lbTongGT.Location = new System.Drawing.Point(191, 15);
            this.lbTongGT.Name = "lbTongGT";
            this.lbTongGT.Size = new System.Drawing.Size(98, 23);
            this.lbTongGT.TabIndex = 8;
            this.lbTongGT.Text = "16.000.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(44, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng cộng";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(66)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(169, 70);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(141, 48);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Thanh toán";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.guna2Button1.Location = new System.Drawing.Point(47, 70);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(101, 48);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Lưu";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.flpChiTietDon);
            this.guna2Panel5.Controls.Add(this.guna2Panel7);
            this.guna2Panel5.Location = new System.Drawing.Point(2, 30);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(337, 329);
            this.guna2Panel5.TabIndex = 4;
            // 
            // flpChiTietDon
            // 
            this.flpChiTietDon.AutoScroll = true;
            this.flpChiTietDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChiTietDon.Location = new System.Drawing.Point(0, 53);
            this.flpChiTietDon.Name = "flpChiTietDon";
            this.flpChiTietDon.Size = new System.Drawing.Size(337, 276);
            this.flpChiTietDon.TabIndex = 1;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 6;
            this.guna2Panel7.Controls.Add(this.label2);
            this.guna2Panel7.CustomizableEdges.BottomLeft = false;
            this.guna2Panel7.CustomizableEdges.BottomRight = false;
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(226)))));
            this.guna2Panel7.ForeColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(337, 53);
            this.guna2Panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn nhập";
            // 
            // flpHang
            // 
            this.flpHang.AutoScroll = true;
            this.flpHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHang.Location = new System.Drawing.Point(0, 0);
            this.flpHang.Name = "flpHang";
            this.flpHang.Padding = new System.Windows.Forms.Padding(40, 10, 0, 0);
            this.flpHang.Size = new System.Drawing.Size(742, 660);
            this.flpHang.TabIndex = 1;
            this.flpHang.Paint += new System.Windows.Forms.PaintEventHandler(this.flpHang_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1088, 72);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.flpHang);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 72);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(742, 660);
            this.guna2Panel3.TabIndex = 2;
            // 
            // frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 732);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.pnDonNhap);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NhapHang";
            this.Text = "frm_NhapHang";
            this.Load += new System.EventHandler(this.frm_NhapHang_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.pnDonNhap.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ComboBox cbLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnThemDon;
        private Guna.UI2.WinForms.Guna2Panel pnDonNhap;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.FlowLayoutPanel flpChiTietDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnThemhang;
        private System.Windows.Forms.Label lbTongGT;
    }
}