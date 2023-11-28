namespace GUI
{
    partial class uc_itemSummary
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
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.nudSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaCT = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSub = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaCT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.Location = new System.Drawing.Point(14, 17);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(94, 23);
            this.lbTenHang.TabIndex = 1;
            this.lbTenHang.Text = "Ghế sofa ...";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.Color.Gray;
            this.lbDonGia.Location = new System.Drawing.Point(14, 48);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(71, 20);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "2.000.000";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbThanhTien.Location = new System.Drawing.Point(174, 52);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(81, 23);
            this.lbThanhTien.TabIndex = 3;
            this.lbThanhTien.Text = "2.000.000";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nudSoLuong.BorderRadius = 5;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoLuong.Location = new System.Drawing.Point(106, 44);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(0, 0);
            this.nudSoLuong.TabIndex = 4;
            this.nudSoLuong.UpDownButtonFillColor = System.Drawing.Color.Tomato;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "1";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(178, 7);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(59, 33);
            this.txtSoLuong.TabIndex = 5;
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = global::GUI.Properties.Resources.cancel__1_1;
            this.btnXoaCT.ImageRotate = 0F;
            this.btnXoaCT.Location = new System.Drawing.Point(276, 9);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXoaCT.Size = new System.Drawing.Size(30, 30);
            this.btnXoaCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoaCT.TabIndex = 8;
            this.btnXoaCT.TabStop = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnSub
            // 
            this.btnSub.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSub.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSub.Image = global::GUI.Properties.Resources.downward_arrow;
            this.btnSub.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSub.ImageRotate = 0F;
            this.btnSub.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSub.Location = new System.Drawing.Point(241, 23);
            this.btnSub.Margin = new System.Windows.Forms.Padding(1);
            this.btnSub.Name = "btnSub";
            this.btnSub.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSub.Size = new System.Drawing.Size(25, 25);
            this.btnSub.TabIndex = 7;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageRotate = 180F;
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Image = global::GUI.Properties.Resources.downward_arrow;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 180F;
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(239, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageRotate = 180F;
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // uc_itemSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbTenHang);
            this.Name = "uc_itemSummary";
            this.Size = new System.Drawing.Size(320, 83);
            this.Load += new System.EventHandler(this.uc_itemSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbThanhTien;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Guna.UI2.WinForms.Guna2ImageButton btnSub;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnXoaCT;
    }
}
