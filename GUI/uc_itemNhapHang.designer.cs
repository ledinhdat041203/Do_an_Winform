namespace GUI
{
    partial class uc_itemNhapHang
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemVaoDon = new Guna.UI2.WinForms.Guna2Button();
            this.lbGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNCC = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.pbAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(670, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnThemVaoDon);
            this.guna2Panel3.Controls.Add(this.lbGia);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(359, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(311, 70);
            this.guna2Panel3.TabIndex = 13;
            // 
            // btnThemVaoDon
            // 
            this.btnThemVaoDon.BorderRadius = 6;
            this.btnThemVaoDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVaoDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVaoDon.FillColor = System.Drawing.Color.Salmon;
            this.btnThemVaoDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoDon.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoDon.Location = new System.Drawing.Point(149, 15);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(142, 40);
            this.btnThemVaoDon.TabIndex = 14;
            this.btnThemVaoDon.Text = "Thêm vào đơn";
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbGia.Location = new System.Drawing.Point(22, 38);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(79, 20);
            this.lbGia.TabIndex = 13;
            this.lbGia.Text = "10.000.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lbNCC);
            this.guna2Panel2.Controls.Add(this.lbTenHang);
            this.guna2Panel2.Controls.Add(this.pbAnh);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(359, 70);
            this.guna2Panel2.TabIndex = 12;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCC.Location = new System.Drawing.Point(89, 39);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(99, 20);
            this.lbNCC.TabIndex = 11;
            this.lbNCC.Text = "Nhà sản xuất";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.Location = new System.Drawing.Point(89, 10);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(103, 20);
            this.lbTenHang.TabIndex = 10;
            this.lbTenHang.Text = "Tên sản phẩm";
            // 
            // pbAnh
            // 
            this.pbAnh.BorderRadius = 6;
            this.pbAnh.FillColor = System.Drawing.Color.Salmon;
            this.pbAnh.ImageRotate = 0F;
            this.pbAnh.Location = new System.Drawing.Point(13, 5);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(60, 60);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 9;
            this.pbAnh.TabStop = false;
            // 
            // uc_itemNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Name = "uc_itemNhapHang";
            this.Size = new System.Drawing.Size(670, 70);
            this.Load += new System.EventHandler(this.uc_itemNhapHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnThemVaoDon;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.Label lbTenHang;
        private Guna.UI2.WinForms.Guna2PictureBox pbAnh;
    }
}
