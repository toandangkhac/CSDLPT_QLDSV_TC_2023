namespace QLDSV_TC
{
    partial class XfrmDSSVDkyLTC
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
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.dSXrpt_dssvDkyLTC = new QLDSV_TC.DSXrpt_dssvDkyLTC();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_TC.DSXrpt_dssvDkyLTCTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSXrpt_dssvDkyLTCTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dSXrpt_dssvDkyLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(516, 158);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 29);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "HỌC KỲ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "NIÊN KHÓA";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "KHOA";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(212, 168);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(184, 24);
            this.cmbHocKy.TabIndex = 9;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(212, 105);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(184, 24);
            this.cmbNienKhoa.TabIndex = 8;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(212, 30);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(184, 24);
            this.cmbKhoa.TabIndex = 7;
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 291);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "NHÓM";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(52, 228);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 16);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "MÔN HỌC";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbNhom.Location = new System.Drawing.Point(212, 288);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(184, 24);
            this.cmbNhom.TabIndex = 15;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(212, 225);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(184, 24);
            this.cmbMonHoc.TabIndex = 14;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // dSXrpt_dssvDkyLTC
            // 
            this.dSXrpt_dssvDkyLTC.DataSetName = "DSXrpt_dssvDkyLTC";
            this.dSXrpt_dssvDkyLTC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dSXrpt_dssvDkyLTC;
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
            // XfrmDSSVDkyLTC
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
            this.Name = "XfrmDSSVDkyLTC";
            this.Text = "XfrmDSSVDkyLTC";
            this.Load += new System.EventHandler(this.XfrmDSSVDkyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSXrpt_dssvDkyLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private DSXrpt_dssvDkyLTC dSXrpt_dssvDkyLTC;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSXrpt_dssvDkyLTCTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSXrpt_dssvDkyLTCTableAdapters.TableAdapterManager tableAdapterManager;
    }
}