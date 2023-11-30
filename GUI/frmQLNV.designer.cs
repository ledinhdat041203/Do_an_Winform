namespace GUI
{
    partial class frmQLNV
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
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpQuanLi = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpNhanVien = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.guna2Button22);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtTen);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1088, 80);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button22
            // 
            this.guna2Button22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button22.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button22.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button22.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button22.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button22.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button22.ForeColor = System.Drawing.Color.Black;
            this.guna2Button22.Image = global::GUI.Properties.Resources.add;
            this.guna2Button22.Location = new System.Drawing.Point(614, 35);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(163, 33);
            this.guna2Button22.TabIndex = 5;
            this.guna2Button22.Text = "Thêm nhân viên";
            this.guna2Button22.Click += new System.EventHandler(this.guna2Button22_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 30);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 34);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FillColor = System.Drawing.Color.Gainsboro;
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(60, 35);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTen.PlaceholderText = "Search for employee";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(283, 26);
            this.txtTen.TabIndex = 0;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flpQuanLi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(831, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 520);
            this.panel1.TabIndex = 1;
            // 
            // flpQuanLi
            // 
            this.flpQuanLi.AutoScroll = true;
            this.flpQuanLi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpQuanLi.Location = new System.Drawing.Point(33, 8);
            this.flpQuanLi.Name = "flpQuanLi";
            this.flpQuanLi.Size = new System.Drawing.Size(192, 433);
            this.flpQuanLi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.flpNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 520);
            this.panel2.TabIndex = 2;
            // 
            // flpNhanVien
            // 
            this.flpNhanVien.AutoScroll = true;
            this.flpNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNhanVien.Location = new System.Drawing.Point(0, 0);
            this.flpNhanVien.Name = "flpNhanVien";
            this.flpNhanVien.Size = new System.Drawing.Size(831, 520);
            this.flpNhanVien.TabIndex = 0;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLNV";
            this.Text = "frmQLNV";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;

        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        //private uc_NhanVien uc_NhanVien1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flpQuanLi;
    }
}