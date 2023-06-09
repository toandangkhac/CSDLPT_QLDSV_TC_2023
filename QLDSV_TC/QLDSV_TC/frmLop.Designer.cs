namespace QLDSV_TC
{
    partial class frmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new QLDSV_TC.DS1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvSINHVIEN = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dANGHIHOCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLOP = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMAKHOA = new DevExpress.XtraEditors.TextEdit();
            this.txtKHOAHOC = new DevExpress.XtraEditors.TextEdit();
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.pnlSINHVIEN = new DevExpress.XtraEditors.PanelControl();
            this.btnPHUCHOISV = new DevExpress.XtraEditors.SimpleButton();
            this.btnGHISV = new DevExpress.XtraEditors.SimpleButton();
            this.txtPASS = new DevExpress.XtraEditors.TextEdit();
            this.chkNGHIHOC = new DevExpress.XtraEditors.CheckEdit();
            this.txtMALOPSV = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.chkPHAI = new DevExpress.XtraEditors.CheckEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDSGV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsTHEMSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHIEUCHINHSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXOASV = new System.Windows.Forms.ToolStripMenuItem();
            this.lOPTableAdapter1 = new QLDSV_TC.DS1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager1 = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.dANGKYTableAdapter1 = new QLDSV_TC.DS1TableAdapters.DANGKYTableAdapter();
            this.sINHVIENTableAdapter1 = new QLDSV_TC.DS1TableAdapters.SINHVIENTableAdapter();
            this.bdsDANGKI = new System.Windows.Forms.BindingSource(this.components);
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLOP)).BeginInit();
            this.pnlLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHOAHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSINHVIEN)).BeginInit();
            this.pnlSINHVIEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNGHIHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOPSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPHAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKI)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(23, 31);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(87, 19);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp (*):";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(18, 83);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(90, 19);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp (*):";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Location = new System.Drawing.Point(544, 83);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(104, 19);
            kHOAHOCLabel.TabIndex = 4;
            kHOAHOCLabel.Text = "Khóa học (*):";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(551, 31);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(97, 19);
            mAKHOALabel.TabIndex = 6;
            mAKHOALabel.Text = "Mã khoa (*):";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(32, 28);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(125, 19);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên (*):";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(49, 80);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(60, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ (*):";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(488, 79);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(64, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên (*):";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(482, 126);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(69, 19);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "Phái (*):";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(26, 175);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(63, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(7, 128);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(81, 19);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(471, 28);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(87, 19);
            mALOPLabel1.TabIndex = 12;
            mALOPLabel1.Text = "Mã lớp (*):";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Location = new System.Drawing.Point(8, 249);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(136, 19);
            dANGHIHOCLabel.TabIndex = 14;
            dANGHIHOCLabel.Text = "Đang nghỉ học (*):";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(366, 249);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(102, 19);
            pASSWORDLabel.TabIndex = 16;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLOP;
            this.gcLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcLOP.Location = new System.Drawing.Point(0, 167);
            this.gcLOP.MainView = this.gridView1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(889, 255);
            this.gcLOP.TabIndex = 4;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.GridControl = this.gcLOP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 53;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 150;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.OptionsColumn.ReadOnly = true;
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 34;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.OptionsColumn.ReadOnly = true;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 33;
            // 
            // dgvSINHVIEN
            // 
            this.dgvSINHVIEN.AutoGenerateColumns = false;
            this.dgvSINHVIEN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSINHVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSINHVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.pHAIDataGridViewCheckBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn,
            this.dANGHIHOCDataGridViewCheckBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn});
            this.dgvSINHVIEN.DataSource = this.bdsSINHVIEN;
            this.dgvSINHVIEN.Location = new System.Drawing.Point(885, 167);
            this.dgvSINHVIEN.Name = "dgvSINHVIEN";
            this.dgvSINHVIEN.RowHeadersWidth = 51;
            this.dgvSINHVIEN.RowTemplate.Height = 24;
            this.dgvSINHVIEN.Size = new System.Drawing.Size(1220, 255);
            this.dgvSINHVIEN.TabIndex = 9;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.ReadOnly = true;
            this.mASVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            this.hODataGridViewTextBoxColumn.ReadOnly = true;
            this.hODataGridViewTextBoxColumn.Width = 125;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.ReadOnly = true;
            this.tENDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHAIDataGridViewCheckBoxColumn
            // 
            this.pHAIDataGridViewCheckBoxColumn.DataPropertyName = "PHAI";
            this.pHAIDataGridViewCheckBoxColumn.HeaderText = "PHAI";
            this.pHAIDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.pHAIDataGridViewCheckBoxColumn.Name = "pHAIDataGridViewCheckBoxColumn";
            this.pHAIDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pHAIDataGridViewCheckBoxColumn.Width = 125;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIACHIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            this.mALOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mALOPDataGridViewTextBoxColumn.Width = 125;
            // 
            // dANGHIHOCDataGridViewCheckBoxColumn
            // 
            this.dANGHIHOCDataGridViewCheckBoxColumn.DataPropertyName = "DANGHIHOC";
            this.dANGHIHOCDataGridViewCheckBoxColumn.HeaderText = "DANGHIHOC";
            this.dANGHIHOCDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dANGHIHOCDataGridViewCheckBoxColumn.Name = "dANGHIHOCDataGridViewCheckBoxColumn";
            this.dANGHIHOCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dANGHIHOCDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSINHVIEN.DataSource = this.bdsLOP;
            // 
            // pnlLOP
            // 
            this.pnlLOP.Controls.Add(this.labelControl4);
            this.pnlLOP.Controls.Add(mAKHOALabel);
            this.pnlLOP.Controls.Add(this.txtMAKHOA);
            this.pnlLOP.Controls.Add(kHOAHOCLabel);
            this.pnlLOP.Controls.Add(this.txtKHOAHOC);
            this.pnlLOP.Controls.Add(tENLOPLabel);
            this.pnlLOP.Controls.Add(this.txtTENLOP);
            this.pnlLOP.Controls.Add(mALOPLabel);
            this.pnlLOP.Controls.Add(this.txtMALOP);
            this.pnlLOP.Location = new System.Drawing.Point(0, 419);
            this.pnlLOP.Name = "pnlLOP";
            this.pnlLOP.Size = new System.Drawing.Size(887, 281);
            this.pnlLOP.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(100, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(609, 28);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "CHÚ Ý: Các mục có (*) là quan trọng, không để trống ô này";
            // 
            // txtMAKHOA
            // 
            this.txtMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKHOA", true));
            this.txtMAKHOA.Location = new System.Drawing.Point(760, 26);
            this.txtMAKHOA.Name = "txtMAKHOA";
            this.txtMAKHOA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHOA.Properties.Appearance.Options.UseFont = true;
            this.txtMAKHOA.Properties.ReadOnly = true;
            this.txtMAKHOA.Size = new System.Drawing.Size(123, 22);
            this.txtMAKHOA.TabIndex = 7;
            // 
            // txtKHOAHOC
            // 
            this.txtKHOAHOC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "KHOAHOC", true));
            this.txtKHOAHOC.Location = new System.Drawing.Point(761, 78);
            this.txtKHOAHOC.Name = "txtKHOAHOC";
            this.txtKHOAHOC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHOAHOC.Properties.Appearance.Options.UseFont = true;
            this.txtKHOAHOC.Size = new System.Drawing.Size(122, 26);
            this.txtKHOAHOC.TabIndex = 5;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(209, 80);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENLOP.Properties.Appearance.Options.UseFont = true;
            this.txtTENLOP.Size = new System.Drawing.Size(274, 26);
            this.txtTENLOP.TabIndex = 3;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(209, 28);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALOP.Properties.Appearance.Options.UseFont = true;
            this.txtMALOP.Size = new System.Drawing.Size(274, 26);
            this.txtMALOP.TabIndex = 1;
            // 
            // pnlSINHVIEN
            // 
            this.pnlSINHVIEN.Controls.Add(this.btnPHUCHOISV);
            this.pnlSINHVIEN.Controls.Add(this.btnGHISV);
            this.pnlSINHVIEN.Controls.Add(pASSWORDLabel);
            this.pnlSINHVIEN.Controls.Add(this.txtPASS);
            this.pnlSINHVIEN.Controls.Add(dANGHIHOCLabel);
            this.pnlSINHVIEN.Controls.Add(this.chkNGHIHOC);
            this.pnlSINHVIEN.Controls.Add(mALOPLabel1);
            this.pnlSINHVIEN.Controls.Add(this.txtMALOPSV);
            this.pnlSINHVIEN.Controls.Add(nGAYSINHLabel);
            this.pnlSINHVIEN.Controls.Add(this.dateNGAYSINH);
            this.pnlSINHVIEN.Controls.Add(dIACHILabel);
            this.pnlSINHVIEN.Controls.Add(this.txtDIACHI);
            this.pnlSINHVIEN.Controls.Add(pHAILabel);
            this.pnlSINHVIEN.Controls.Add(this.chkPHAI);
            this.pnlSINHVIEN.Controls.Add(tENLabel);
            this.pnlSINHVIEN.Controls.Add(this.txtTEN);
            this.pnlSINHVIEN.Controls.Add(hOLabel);
            this.pnlSINHVIEN.Controls.Add(this.txtHO);
            this.pnlSINHVIEN.Controls.Add(mASVLabel);
            this.pnlSINHVIEN.Controls.Add(this.txtMASV);
            this.pnlSINHVIEN.Location = new System.Drawing.Point(885, 419);
            this.pnlSINHVIEN.Name = "pnlSINHVIEN";
            this.pnlSINHVIEN.Size = new System.Drawing.Size(1220, 281);
            this.pnlSINHVIEN.TabIndex = 15;
            // 
            // btnPHUCHOISV
            // 
            this.btnPHUCHOISV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPHUCHOISV.ImageOptions.Image")));
            this.btnPHUCHOISV.Location = new System.Drawing.Point(890, 96);
            this.btnPHUCHOISV.Name = "btnPHUCHOISV";
            this.btnPHUCHOISV.Size = new System.Drawing.Size(145, 29);
            this.btnPHUCHOISV.TabIndex = 19;
            this.btnPHUCHOISV.Text = "Phục hồi";
            this.btnPHUCHOISV.Click += new System.EventHandler(this.btnPHUCHOISV_Click);
            // 
            // btnGHISV
            // 
            this.btnGHISV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGHISV.ImageOptions.Image")));
            this.btnGHISV.Location = new System.Drawing.Point(890, 31);
            this.btnGHISV.Name = "btnGHISV";
            this.btnGHISV.Size = new System.Drawing.Size(145, 29);
            this.btnGHISV.TabIndex = 18;
            this.btnGHISV.Text = "Ghi";
            this.btnGHISV.Click += new System.EventHandler(this.btnGHISV_Click);
            // 
            // txtPASS
            // 
            this.txtPASS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "PASSWORD", true));
            this.txtPASS.Location = new System.Drawing.Point(535, 246);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(269, 26);
            this.txtPASS.TabIndex = 17;
            // 
            // chkNGHIHOC
            // 
            this.chkNGHIHOC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "DANGHIHOC", true));
            this.chkNGHIHOC.Location = new System.Drawing.Point(213, 246);
            this.chkNGHIHOC.Name = "chkNGHIHOC";
            this.chkNGHIHOC.Properties.Caption = "";
            this.chkNGHIHOC.Size = new System.Drawing.Size(94, 24);
            this.chkNGHIHOC.TabIndex = 15;
            // 
            // txtMALOPSV
            // 
            this.txtMALOPSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "MALOP", true));
            this.txtMALOPSV.Location = new System.Drawing.Point(605, 25);
            this.txtMALOPSV.Name = "txtMALOPSV";
            this.txtMALOPSV.Properties.ReadOnly = true;
            this.txtMALOPSV.Size = new System.Drawing.Size(233, 26);
            this.txtMALOPSV.TabIndex = 13;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "NGAYSINH", true));
            this.dateNGAYSINH.EditValue = null;
            this.dateNGAYSINH.Location = new System.Drawing.Point(194, 128);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Size = new System.Drawing.Size(243, 26);
            this.dateNGAYSINH.TabIndex = 11;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(194, 175);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(243, 26);
            this.txtDIACHI.TabIndex = 9;
            // 
            // chkPHAI
            // 
            this.chkPHAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "PHAI", true));
            this.chkPHAI.Location = new System.Drawing.Point(605, 123);
            this.chkPHAI.Name = "chkPHAI";
            this.chkPHAI.Properties.Caption = "Chọn: Nữ, Không chọn: Nam";
            this.chkPHAI.Size = new System.Drawing.Size(208, 24);
            this.chkPHAI.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(605, 77);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(233, 26);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(194, 80);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(243, 26);
            this.txtHO.TabIndex = 3;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(194, 28);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(243, 26);
            this.txtMASV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(336, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 28);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "BẢNG LỚP";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1337, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(176, 28);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "BẢNG SINH VIÊN";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnDSGV,
            this.barButtonItem8,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DƯỚI ĐÂY LÀ CÁC NÚT LỆNH THAO TÁC VỚI BẢNG LỚP, ĐỂ THAO TÁC VỚI BẢNG SINH VIÊN CL" +
    "ICK CHUỘT PHẢI LÊN BẢNG SINH VIÊN";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(2105, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 833);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2105, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 774);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2105, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 774);
            // 
            // btnDSGV
            // 
            this.btnDSGV.Caption = "In danh sách Giảng viên";
            this.btnDSGV.Id = 7;
            this.btnDSGV.Name = "btnDSGV";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "In danh sách sinh viên";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 19);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(58, 86);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(251, 24);
            this.cmbKhoa.TabIndex = 33;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTHEMSV,
            this.tsHIEUCHINHSV,
            this.tsXOASV});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(210, 76);
            // 
            // tsTHEMSV
            // 
            this.tsTHEMSV.Name = "tsTHEMSV";
            this.tsTHEMSV.Size = new System.Drawing.Size(209, 24);
            this.tsTHEMSV.Text = "Thêm sinh viên";
            this.tsTHEMSV.Click += new System.EventHandler(this.tsTHEMSV_Click);
            // 
            // tsHIEUCHINHSV
            // 
            this.tsHIEUCHINHSV.Name = "tsHIEUCHINHSV";
            this.tsHIEUCHINHSV.Size = new System.Drawing.Size(209, 24);
            this.tsHIEUCHINHSV.Text = "Hiệu chỉnh sinh viên";
            this.tsHIEUCHINHSV.Click += new System.EventHandler(this.tsHIEUCHINHSV_Click);
            // 
            // tsXOASV
            // 
            this.tsXOASV.Name = "tsXOASV";
            this.tsXOASV.Size = new System.Drawing.Size(209, 24);
            this.tsXOASV.Text = "Xóa sinh viên";
            this.tsXOASV.Click += new System.EventHandler(this.tsXOASV_Click);
            // 
            // lOPTableAdapter1
            // 
            this.lOPTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DANGKYTableAdapter = this.dANGKYTableAdapter1;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lOPTableAdapter1;
            this.tableAdapterManager1.LOPTINCHITableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = this.sINHVIENTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dANGKYTableAdapter1
            // 
            this.dANGKYTableAdapter1.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter1
            // 
            this.sINHVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // bdsDANGKI
            // 
            this.bdsDANGKI.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDANGKI.DataSource = this.bdsSINHVIEN;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 874);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pnlSINHVIEN);
            this.Controls.Add(this.pnlLOP);
            this.Controls.Add(this.dgvSINHVIEN);
            this.Controls.Add(this.gcLOP);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLOP)).EndInit();
            this.pnlLOP.ResumeLayout(false);
            this.pnlLOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHOAHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSINHVIEN)).EndInit();
            this.pnlSINHVIEN.ResumeLayout(false);
            this.pnlSINHVIEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNGHIHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOPSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPHAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridView dgvSINHVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.PanelControl pnlSINHVIEN;
        private DevExpress.XtraEditors.PanelControl pnlLOP;
        private DevExpress.XtraEditors.TextEdit txtPASS;
        private DevExpress.XtraEditors.CheckEdit chkNGHIHOC;
        private DevExpress.XtraEditors.TextEdit txtMALOPSV;
        private DevExpress.XtraEditors.DateEdit dateNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.CheckEdit chkPHAI;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private DevExpress.XtraEditors.TextEdit txtMAKHOA;
        private DevExpress.XtraEditors.TextEdit txtKHOAHOC;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDSGV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsTHEMSV;
        private System.Windows.Forms.ToolStripMenuItem tsHIEUCHINHSV;
        private System.Windows.Forms.ToolStripMenuItem tsXOASV;
        private DevExpress.XtraEditors.SimpleButton btnPHUCHOISV;
        private DevExpress.XtraEditors.SimpleButton btnGHISV;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DS1TableAdapters.LOPTableAdapter lOPTableAdapter1;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DS1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter1;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DS1TableAdapters.DANGKYTableAdapter dANGKYTableAdapter1;
        private System.Windows.Forms.BindingSource bdsDANGKI;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pHAIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dANGHIHOCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}