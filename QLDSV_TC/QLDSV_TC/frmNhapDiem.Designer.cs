namespace QLDSV_TC
{
    partial class frmNhapDiem
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
            DevExpress.XtraGrid.Columns.GridColumn colDIEM_HM;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnTaiLoptc = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.gcDKY = new DevExpress.XtraGrid.GridControl();
            this.bdsDSSVDKI = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new QLDSV_TC.DS1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDSLTC = new DevExpress.XtraGrid.GridControl();
            this.bdsDSLOPTC = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sp_ds_loptc_de_nhap_diemTableAdapter = new QLDSV_TC.DS1TableAdapters.sp_ds_loptc_de_nhap_diemTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.ds_sv_dki_loptc_de_nhapdiemTableAdapter = new QLDSV_TC.DS1TableAdapters.ds_sv_dki_loptc_de_nhapdiemTableAdapter();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            colDIEM_HM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSVDKI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLOPTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colDIEM_HM
            // 
            colDIEM_HM.Caption = "Điểm hết môn";
            colDIEM_HM.FieldName = "DIEM_HM";
            colDIEM_HM.MinWidth = 25;
            colDIEM_HM.Name = "colDIEM_HM";
            colDIEM_HM.Visible = true;
            colDIEM_HM.VisibleIndex = 5;
            colDIEM_HM.Width = 94;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(63, 25);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(332, 25);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(138, 24);
            this.cmbNienKhoa.TabIndex = 1;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(607, 25);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(110, 24);
            this.cmbHocKy.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Khoa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(246, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Niên khóa:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(541, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Học kỳ:";
            // 
            // btnTaiLoptc
            // 
            this.btnTaiLoptc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLoptc.ImageOptions.Image")));
            this.btnTaiLoptc.Location = new System.Drawing.Point(897, 20);
            this.btnTaiLoptc.Name = "btnTaiLoptc";
            this.btnTaiLoptc.Size = new System.Drawing.Size(188, 29);
            this.btnTaiLoptc.TabIndex = 6;
            this.btnTaiLoptc.Text = "Tải lớp tín chỉ";
            this.btnTaiLoptc.Click += new System.EventHandler(this.btnTaiLoptc_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.Image")));
            this.btnNhapDiem.Location = new System.Drawing.Point(1146, 20);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(118, 29);
            this.btnNhapDiem.TabIndex = 7;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Location = new System.Drawing.Point(1321, 20);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(106, 29);
            this.btnGhi.TabIndex = 8;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // gcDKY
            // 
            this.gcDKY.DataSource = this.bdsDSSVDKI;
            this.gcDKY.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDKY.Location = new System.Drawing.Point(2, 331);
            this.gcDKY.MainView = this.gridView1;
            this.gcDKY.Name = "gcDKY";
            this.gcDKY.Size = new System.Drawing.Size(1775, 351);
            this.gcDKY.TabIndex = 9;
            this.gcDKY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDSSVDKI
            // 
            this.bdsDSSVDKI.DataMember = "ds_sv_dki_loptc_de_nhapdiem";
            this.bdsDSSVDKI.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            colDIEM_HM});
            this.gridView1.GridControl = this.gcDKY;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHOTENSV
            // 
            this.colHOTENSV.Caption = "Họ tên";
            this.colHOTENSV.FieldName = "HOTENSV";
            this.colHOTENSV.MinWidth = 25;
            this.colHOTENSV.Name = "colHOTENSV";
            this.colHOTENSV.OptionsColumn.ReadOnly = true;
            this.colHOTENSV.Visible = true;
            this.colHOTENSV.VisibleIndex = 1;
            this.colHOTENSV.Width = 94;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.Caption = "Điểm chuyên cần";
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.MinWidth = 25;
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            this.colDIEM_CC.Width = 94;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.Caption = "Điểm giữa kì";
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.MinWidth = 25;
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            this.colDIEM_GK.Width = 94;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.Caption = "Điểm cuối kỳ";
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.MinWidth = 25;
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            this.colDIEM_CK.Width = 94;
            // 
            // gcDSLTC
            // 
            this.gcDSLTC.DataSource = this.bdsDSLOPTC;
            this.gcDSLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSLTC.Location = new System.Drawing.Point(2, 2);
            this.gcDSLTC.MainView = this.gridView2;
            this.gcDSLTC.Name = "gcDSLTC";
            this.gcDSLTC.Size = new System.Drawing.Size(1775, 329);
            this.gcDSLTC.TabIndex = 10;
            this.gcDSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsDSLOPTC
            // 
            this.bdsDSLOPTC.DataMember = "sp_ds_loptc_de_nhap_diem";
            this.bdsDSLOPTC.DataSource = this.dS1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colTENGV});
            this.gridView2.GridControl = this.gcDSLTC;
            this.gridView2.Name = "gridView2";
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colTENGV
            // 
            this.colTENGV.Caption = "Tên giàng viên";
            this.colTENGV.FieldName = "TENGV";
            this.colTENGV.MinWidth = 25;
            this.colTENGV.Name = "colTENGV";
            this.colTENGV.OptionsColumn.ReadOnly = true;
            this.colTENGV.Visible = true;
            this.colTENGV.VisibleIndex = 3;
            this.colTENGV.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.btnGhi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnNhapDiem);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnTaiLoptc);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1779, 69);
            this.panelControl1.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcDKY);
            this.panelControl2.Controls.Add(this.gcDSLTC);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 69);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1779, 671);
            this.panelControl2.TabIndex = 12;
            // 
            // sp_ds_loptc_de_nhap_diemTableAdapter
            // 
            this.sp_ds_loptc_de_nhap_diemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ds_sv_dki_loptc_de_nhapdiemTableAdapter
            // 
            this.ds_sv_dki_loptc_de_nhapdiemTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1524, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 740);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSVDKI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLOPTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTaiLoptc;
        private DevExpress.XtraEditors.SimpleButton btnNhapDiem;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraGrid.GridControl gcDKY;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcDSLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource bdsDSLOPTC;
        private DS1TableAdapters.sp_ds_loptc_de_nhap_diemTableAdapter sp_ds_loptc_de_nhap_diemTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colTENGV;
        private System.Windows.Forms.BindingSource bdsDSSVDKI;
        private DS1TableAdapters.ds_sv_dki_loptc_de_nhapdiemTableAdapter ds_sv_dki_loptc_de_nhapdiemTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}