namespace QLDSV_TC
{
    partial class frmDangKyLTC
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTTSV = new DevExpress.XtraEditors.SimpleButton();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlTAILTC = new DevExpress.XtraEditors.PanelControl();
            this.btnTaiLTC = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pnlTTSV = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.gcDangKy = new DevExpress.XtraGrid.GridControl();
            this.sp_lay_dsltc_de_dkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSdangKyLTC = new QLDSV_TC.DSdangKyLTC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDANGKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DANGKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_lay_dsltc_de_dkyTableAdapter = new QLDSV_TC.DSdangKyLTCTableAdapters.sp_lay_dsltc_de_dkyTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSdangKyLTCTableAdapters.TableAdapterManager();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTAILTC)).BeginInit();
            this.pnlTAILTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTTSV)).BeginInit();
            this.pnlTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_dsltc_de_dkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSdangKyLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTTSV);
            this.panelControl1.Controls.Add(this.txtMASV);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1379, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // btnTTSV
            // 
            this.btnTTSV.Location = new System.Drawing.Point(457, 38);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Size = new System.Drawing.Size(150, 29);
            this.btnTTSV.TabIndex = 6;
            this.btnTTSV.Text = "Xuất thông tin ";
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click);
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(199, 42);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(125, 22);
            this.txtMASV.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(110, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã sinh viên";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlTAILTC);
            this.panelControl2.Controls.Add(this.pnlTTSV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1379, 143);
            this.panelControl2.TabIndex = 1;
            // 
            // pnlTAILTC
            // 
            this.pnlTAILTC.Controls.Add(this.btnTaiLTC);
            this.pnlTAILTC.Controls.Add(this.cmbHocKy);
            this.pnlTAILTC.Controls.Add(this.cmbNienKhoa);
            this.pnlTAILTC.Controls.Add(this.labelControl7);
            this.pnlTAILTC.Controls.Add(this.labelControl6);
            this.pnlTAILTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTAILTC.Location = new System.Drawing.Point(754, 2);
            this.pnlTAILTC.Name = "pnlTAILTC";
            this.pnlTAILTC.Size = new System.Drawing.Size(623, 139);
            this.pnlTAILTC.TabIndex = 4;
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Location = new System.Drawing.Point(450, 70);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(94, 29);
            this.btnTaiLTC.TabIndex = 4;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(239, 91);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 24);
            this.cmbHocKy.TabIndex = 3;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(239, 44);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbNienKhoa.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(103, 91);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Học kỳ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(103, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Niên khóa";
            // 
            // pnlTTSV
            // 
            this.pnlTTSV.Controls.Add(this.labelControl5);
            this.pnlTTSV.Controls.Add(this.labelControl4);
            this.pnlTTSV.Controls.Add(this.labelControl3);
            this.pnlTTSV.Controls.Add(this.txtHO);
            this.pnlTTSV.Controls.Add(this.labelControl2);
            this.pnlTTSV.Controls.Add(this.txtMALOP);
            this.pnlTTSV.Controls.Add(this.txtTEN);
            this.pnlTTSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTTSV.Location = new System.Drawing.Point(2, 2);
            this.pnlTTSV.Name = "pnlTTSV";
            this.pnlTTSV.Size = new System.Drawing.Size(752, 139);
            this.pnlTTSV.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(236, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "THÔNG TIN SINH VIÊN";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(298, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Mã lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên";
            // 
            // txtHO
            // 
            this.txtHO.Location = new System.Drawing.Point(104, 46);
            this.txtHO.Name = "txtHO";
            this.txtHO.Properties.ReadOnly = true;
            this.txtHO.Size = new System.Drawing.Size(125, 22);
            this.txtHO.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Họ";
            // 
            // txtMALOP
            // 
            this.txtMALOP.Location = new System.Drawing.Point(397, 67);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.ReadOnly = true;
            this.txtMALOP.Size = new System.Drawing.Size(125, 22);
            this.txtMALOP.TabIndex = 6;
            // 
            // txtTEN
            // 
            this.txtTEN.Location = new System.Drawing.Point(104, 90);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.ReadOnly = true;
            this.txtTEN.Size = new System.Drawing.Size(125, 22);
            this.txtTEN.TabIndex = 7;
            // 
            // gcDangKy
            // 
            this.gcDangKy.DataSource = this.sp_lay_dsltc_de_dkyBindingSource;
            this.gcDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDangKy.Location = new System.Drawing.Point(0, 243);
            this.gcDangKy.MainView = this.gridView1;
            this.gcDangKy.Name = "gcDangKy";
            this.gcDangKy.Size = new System.Drawing.Size(1379, 212);
            this.gcDangKy.TabIndex = 2;
            this.gcDangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sp_lay_dsltc_de_dkyBindingSource
            // 
            this.sp_lay_dsltc_de_dkyBindingSource.DataMember = "sp_lay_dsltc_de_dky";
            this.sp_lay_dsltc_de_dkyBindingSource.DataSource = this.dSdangKyLTC;
            // 
            // dSdangKyLTC
            // 
            this.dSdangKyLTC.DataSetName = "DSdangKyLTC";
            this.dSdangKyLTC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV,
            this.colSOSVDANGKI,
            this.DANGKI});
            this.gridView1.GridControl = this.gcDangKy;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.MinWidth = 25;
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 3;
            this.colHOTENGV.Width = 94;
            // 
            // colSOSVDANGKI
            // 
            this.colSOSVDANGKI.FieldName = "SOSVDANGKI";
            this.colSOSVDANGKI.MinWidth = 25;
            this.colSOSVDANGKI.Name = "colSOSVDANGKI";
            this.colSOSVDANGKI.Visible = true;
            this.colSOSVDANGKI.VisibleIndex = 4;
            this.colSOSVDANGKI.Width = 94;
            // 
            // DANGKI
            // 
            this.DANGKI.Caption = "Đăng kí";
            this.DANGKI.FieldName = "DangKi";
            this.DANGKI.MinWidth = 25;
            this.DANGKI.Name = "DANGKI";
            this.DANGKI.UnboundDataType = typeof(bool);
            this.DANGKI.Visible = true;
            this.DANGKI.VisibleIndex = 5;
            this.DANGKI.Width = 94;
            // 
            // sp_lay_dsltc_de_dkyTableAdapter
            // 
            this.sp_lay_dsltc_de_dkyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSdangKyLTCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(882, 483);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu đăng kí";
            // 
            // frmDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 581);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gcDangKy);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKyLTC";
            this.Text = "frmDangKyLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTAILTC)).EndInit();
            this.pnlTAILTC.ResumeLayout(false);
            this.pnlTAILTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTTSV)).EndInit();
            this.pnlTTSV.ResumeLayout(false);
            this.pnlTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_dsltc_de_dkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSdangKyLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTTSV;
        private DevExpress.XtraEditors.PanelControl pnlTAILTC;
        private DevExpress.XtraEditors.PanelControl pnlTTSV;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnTaiLTC;
        private DevExpress.XtraGrid.GridControl gcDangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDANGKI;
        private DSdangKyLTC dSdangKyLTC;
        private System.Windows.Forms.BindingSource sp_lay_dsltc_de_dkyBindingSource;
        private DSdangKyLTCTableAdapters.sp_lay_dsltc_de_dkyTableAdapter sp_lay_dsltc_de_dkyTableAdapter;
        private DSdangKyLTCTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn DANGKI;
    }
}