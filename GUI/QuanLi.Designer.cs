namespace GUI
{
    partial class frmQuanLi
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
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLHH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(58, 104);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(75, 45);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản lí nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLHH
            // 
            this.btnQLHH.Location = new System.Drawing.Point(568, 104);
            this.btnQLHH.Name = "btnQLHH";
            this.btnQLHH.Size = new System.Drawing.Size(75, 45);
            this.btnQLHH.TabIndex = 1;
            this.btnQLHH.Text = "Quản lí Hàng hóa";
            this.btnQLHH.UseVisualStyleBackColor = true;
            this.btnQLHH.Click += new System.EventHandler(this.btnQLHH_Click);
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLHH);
            this.Controls.Add(this.btnQLNV);
            this.Name = "frmQuanLi";
            this.Text = "QuanLi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLHH;
    }
}