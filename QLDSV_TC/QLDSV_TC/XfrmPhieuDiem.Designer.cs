namespace QLDSV_TC
{
    partial class XfrmPhieuDiem
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
            this.cmbMASV = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmbMASV
            // 
            this.cmbMASV.FormattingEnabled = true;
            this.cmbMASV.Location = new System.Drawing.Point(275, 110);
            this.cmbMASV.Name = "cmbMASV";
            this.cmbMASV.Size = new System.Drawing.Size(121, 24);
            this.cmbMASV.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn mã sinh viên";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(516, 106);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 29);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Prevew";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // XfrmPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbMASV);
            this.Name = "XfrmPhieuDiem";
            this.Text = "XfrmPhieuDiem";
            this.Load += new System.EventHandler(this.XfrmPhieuDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMASV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}