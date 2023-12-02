namespace GUI
{
    partial class frm_cpDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cpDonBan));
            this.rpvDonBan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpvDonBan
            // 
            this.rpvDonBan.ActiveViewIndex = -1;
            this.rpvDonBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvDonBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDonBan.Location = new System.Drawing.Point(0, 0);
            this.rpvDonBan.Name = "rpvDonBan";
            this.rpvDonBan.Size = new System.Drawing.Size(1282, 952);
            this.rpvDonBan.TabIndex = 0;
            // 
            // frm_cpDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 952);
            this.Controls.Add(this.rpvDonBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cpDonBan";
            this.Text = "frm_cpDonBan";
            this.ResumeLayout(false);

        }

        #endregion
        private rpDonBan rpDonBan1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpvDonBan;
    }
}