namespace WinForm
{
    partial class Frm_baocao
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
            this.Crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv
            // 
            this.Crv.ActiveViewIndex = -1;
            this.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv.Location = new System.Drawing.Point(0, 0);
            this.Crv.Name = "Crv";
            this.Crv.Size = new System.Drawing.Size(666, 483);
            this.Crv.TabIndex = 0;
            // 
            // Frm_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.Crv);
            this.Name = "Frm_baocao";
            this.Text = "Frm_baocao";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer Crv;

    }
}