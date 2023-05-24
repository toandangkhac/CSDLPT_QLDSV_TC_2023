namespace QLDSV_TC
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radSinhVien = new System.Windows.Forms.RadioButton();
            this.radGiangVien = new System.Windows.Forms.RadioButton();
            this.btnQuenMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(161, 92);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(391, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.Text = "-- Chọn khoa --";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(80, 92);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(28, 16);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 143);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tài khoản";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.EditValue = "";
            this.txtLogin.Location = new System.Drawing.Point(161, 140);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(391, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(71, 194);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtPass
            // 
            this.txtPass.EditValue = "";
            this.txtPass.Location = new System.Drawing.Point(161, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(391, 22);
            this.txtPass.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(350, 269);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(94, 29);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(520, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radSinhVien);
            this.panelControl1.Controls.Add(this.radGiangVien);
            this.panelControl1.Controls.Add(this.btnQuenMK);
            this.panelControl1.Controls.Add(this.txtLogin);
            this.panelControl1.Controls.Add(this.btnLogin);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.lblKhoa);
            this.panelControl1.Controls.Add(this.txtPass);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(682, 353);
            this.panelControl1.TabIndex = 8;
            // 
            // radSinhVien
            // 
            this.radSinhVien.AutoSize = true;
            this.radSinhVien.Location = new System.Drawing.Point(376, 46);
            this.radSinhVien.Name = "radSinhVien";
            this.radSinhVien.Size = new System.Drawing.Size(82, 20);
            this.radSinhVien.TabIndex = 14;
            this.radSinhVien.TabStop = true;
            this.radSinhVien.Text = "Sinh Viên";
            this.radSinhVien.UseVisualStyleBackColor = true;
            this.radSinhVien.CheckedChanged += new System.EventHandler(this.radSinhVien_CheckedChanged);
            // 
            // radGiangVien
            // 
            this.radGiangVien.AutoSize = true;
            this.radGiangVien.Checked = true;
            this.radGiangVien.Location = new System.Drawing.Point(219, 46);
            this.radGiangVien.Name = "radGiangVien";
            this.radGiangVien.Size = new System.Drawing.Size(87, 20);
            this.radGiangVien.TabIndex = 13;
            this.radGiangVien.TabStop = true;
            this.radGiangVien.Text = "Giảng viên";
            this.radGiangVien.UseVisualStyleBackColor = true;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuenMK.Location = new System.Drawing.Point(397, 248);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(155, 29);
            this.btnQuenMK.TabIndex = 15;
            this.btnQuenMK.Text = "Quên mật khẩu";
            this.btnQuenMK.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(161, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 29);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "FormDangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.LabelControl lblKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnQuenMK;
        private System.Windows.Forms.RadioButton radSinhVien;
        private System.Windows.Forms.RadioButton radGiangVien;
    }
}