namespace QLDSV_TC
{
    partial class Xfrm_BangDiemTongKet
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
            this.gcBangDiemTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiemTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBangDiemTK
            // 
            this.gcBangDiemTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBangDiemTK.Location = new System.Drawing.Point(0, 0);
            this.gcBangDiemTK.MainView = this.gridView1;
            this.gcBangDiemTK.Name = "gcBangDiemTK";
            this.gcBangDiemTK.Size = new System.Drawing.Size(800, 200);
            this.gcBangDiemTK.TabIndex = 0;
            this.gcBangDiemTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcBangDiemTK;
            this.gridView1.Name = "gridView1";
            // 
            // Xfrm_BangDiemTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcBangDiemTK);
            this.Name = "Xfrm_BangDiemTongKet";
            this.Text = "Xfrm_BangDiemTongKet";
            this.Load += new System.EventHandler(this.Xfrm_BangDiemTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiemTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBangDiemTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}