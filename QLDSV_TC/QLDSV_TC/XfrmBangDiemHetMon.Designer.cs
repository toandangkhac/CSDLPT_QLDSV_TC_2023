namespace QLDSV_TC
{
    partial class XfrmBangDiemHetMon
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSXrpt_dssvDkyLTC = new QLDSV_TC.DSXrpt_dssvDkyLTC();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.mONHOCTableAdapter = new QLDSV_TC.DSXrpt_dssvDkyLTCTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSXrpt_dssvDkyLTCTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSXrpt_dssvDkyLTC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(121, 345);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 19);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "NHÓM";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(121, 282);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 19);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "MÔN HỌC";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbNhom.Location = new System.Drawing.Point(281, 342);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(184, 24);
            this.cmbNhom.TabIndex = 26;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(281, 279);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(184, 24);
            this.cmbMonHoc.TabIndex = 25;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dSXrpt_dssvDkyLTC;
            // 
            // dSXrpt_dssvDkyLTC
            // 
            this.dSXrpt_dssvDkyLTC.DataSetName = "DSXrpt_dssvDkyLTC";
            this.dSXrpt_dssvDkyLTC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(585, 212);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 29);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(121, 225);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 19);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "HỌC KỲ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(121, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 19);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "NIÊN KHÓA";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(121, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 19);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "KHOA";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(281, 222);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(184, 24);
            this.cmbHocKy.TabIndex = 20;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(281, 159);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(184, 24);
            this.cmbNienKhoa.TabIndex = 19;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(281, 84);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(184, 24);
            this.cmbKhoa.TabIndex = 18;
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSXrpt_dssvDkyLTCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // XfrmBangDiemHetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Name = "XfrmBangDiemHetMon";
            this.Text = "XfrmBangDiemHetMon";
            this.Load += new System.EventHandler(this.XfrmBangDiemHetMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSXrpt_dssvDkyLTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DSXrpt_dssvDkyLTC dSXrpt_dssvDkyLTC;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSXrpt_dssvDkyLTCTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSXrpt_dssvDkyLTCTableAdapters.TableAdapterManager tableAdapterManager;
    }
}