namespace GUI
{
    partial class ucKhachHang
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
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.lbRank = new System.Windows.Forms.Label();
            this.pbRank = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.guna2Button7);
            this.guna2ShadowPanel2.Controls.Add(this.lbRank);
            this.guna2ShadowPanel2.Controls.Add(this.pbRank);
            this.guna2ShadowPanel2.Controls.Add(this.lbMaKH);
            this.guna2ShadowPanel2.Controls.Add(this.lbTenKH);
            this.guna2ShadowPanel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(336, 77);
            this.guna2ShadowPanel2.TabIndex = 4;
            this.guna2ShadowPanel2.Click += new System.EventHandler(this.guna2ShadowPanel2_Click);
            this.guna2ShadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel2_Paint);
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.White;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::GUI.Properties.Resources.icons8_vertical_ellipsis_menu_with_three_dots_expansion_15;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(0, 12);
            this.guna2Button7.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2Button7.Location = new System.Drawing.Point(302, 15);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(21, 37);
            this.guna2Button7.TabIndex = 7;
            this.guna2Button7.Text = "guna2Button7";
            // 
            // lbRank
            // 
            this.lbRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.lbRank.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRank.ForeColor = System.Drawing.Color.Sienna;
            this.lbRank.Location = new System.Drawing.Point(162, 37);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(143, 15);
            this.lbRank.TabIndex = 6;
            this.lbRank.Text = "Bronze";
            this.lbRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRank.Click += new System.EventHandler(this.lbRank_Click);
            // 
            // pbRank
            // 
            this.pbRank.BackColor = System.Drawing.SystemColors.Window;
            this.pbRank.FillColor = System.Drawing.Color.Transparent;
            this.pbRank.Image = global::GUI.Properties.Resources.Diamond;
            this.pbRank.ImageRotate = 0F;
            this.pbRank.Location = new System.Drawing.Point(216, 7);
            this.pbRank.Name = "pbRank";
            this.pbRank.Size = new System.Drawing.Size(30, 30);
            this.pbRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRank.TabIndex = 5;
            this.pbRank.TabStop = false;
            this.pbRank.Click += new System.EventHandler(this.pbRank_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMaKH.Location = new System.Drawing.Point(63, 37);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(63, 15);
            this.lbMaKH.TabIndex = 2;
            this.lbMaKH.Text = "#S0-1098";
            this.lbMaKH.Click += new System.EventHandler(this.lbTenKH_Click);
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(63, 10);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(107, 23);
            this.lbTenKH.TabIndex = 1;
            this.lbTenKH.Text = "Lionel Messi";
            this.lbTenKH.Click += new System.EventHandler(this.lbTenKH_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources.avt61;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(336, 77);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private System.Windows.Forms.Label lbRank;
        private Guna.UI2.WinForms.Guna2PictureBox pbRank;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbTenKH;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
