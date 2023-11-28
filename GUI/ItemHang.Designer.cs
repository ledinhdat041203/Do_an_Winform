namespace GUI
{
    partial class ItemHang
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
            this.lbGia = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lbNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(151, 11);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(105, 19);
            this.lbTenHang.TabIndex = 1;
            this.lbTenHang.Text = "Tên sản phẩm:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(151, 52);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(38, 19);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá:";
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAnh.Image = global::GUI.Properties.Resources._360_F_496632203_ebd1fmChidWFuaYcoIKgRAAQqo00ReUC;
            this.picAnh.InitialImage = global::GUI.Properties.Resources.tiktok_5968812;
            this.picAnh.Location = new System.Drawing.Point(0, 0);
            this.picAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(145, 123);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Location = new System.Drawing.Point(151, 85);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(104, 19);
            this.lbNCC.TabIndex = 3;
            this.lbNCC.Text = "Nhà cung cấp:";
            // 
            // ItemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbNCC);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.picAnh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemHang";
            this.Size = new System.Drawing.Size(293, 123);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbNCC;
    }
}
