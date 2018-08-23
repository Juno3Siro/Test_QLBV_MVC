namespace QLBV
{
    partial class frmBacsy
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtTenbacsy = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtMaBacsy = new System.Windows.Forms.TextBox();
            this.lblMabacsy = new System.Windows.Forms.Label();
            this.mnuLammoi = new System.Windows.Forms.MenuStrip();
            this.mnuThemmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBacsy = new System.Windows.Forms.DataGridView();
            this.MaBacsy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBacsy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuyenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChuyenkhoa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.mnuLammoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacsy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(260, 19);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 132;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 50);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(75, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 22);
            this.txtSearch.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "Bác sỹ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Chuyên khoa";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(109, 158);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(167, 22);
            this.txtSoDT.TabIndex = 138;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(15, 161);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(86, 16);
            this.lblPhone.TabIndex = 137;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtTenbacsy
            // 
            this.txtTenbacsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenbacsy.Location = new System.Drawing.Point(109, 126);
            this.txtTenbacsy.Name = "txtTenbacsy";
            this.txtTenbacsy.Size = new System.Drawing.Size(251, 22);
            this.txtTenbacsy.TabIndex = 133;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.Color.Transparent;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.Black;
            this.lblHoten.Location = new System.Drawing.Point(15, 129);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(65, 16);
            this.lblHoten.TabIndex = 132;
            this.lblHoten.Text = "Họ và tên";
            // 
            // txtMaBacsy
            // 
            this.txtMaBacsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBacsy.Location = new System.Drawing.Point(109, 97);
            this.txtMaBacsy.Name = "txtMaBacsy";
            this.txtMaBacsy.Size = new System.Drawing.Size(100, 22);
            this.txtMaBacsy.TabIndex = 131;
            // 
            // lblMabacsy
            // 
            this.lblMabacsy.AutoSize = true;
            this.lblMabacsy.BackColor = System.Drawing.Color.Transparent;
            this.lblMabacsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMabacsy.ForeColor = System.Drawing.Color.Black;
            this.lblMabacsy.Location = new System.Drawing.Point(15, 100);
            this.lblMabacsy.Name = "lblMabacsy";
            this.lblMabacsy.Size = new System.Drawing.Size(70, 16);
            this.lblMabacsy.TabIndex = 130;
            this.lblMabacsy.Text = "Mã bác sỹ";
            // 
            // mnuLammoi
            // 
            this.mnuLammoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemmoi,
            this.mnuSua,
            this.mnuLuu,
            this.mnuHuy,
            this.mnuXoa,
            this.mnuThoat});
            this.mnuLammoi.Location = new System.Drawing.Point(0, 0);
            this.mnuLammoi.Name = "mnuLammoi";
            this.mnuLammoi.Size = new System.Drawing.Size(574, 24);
            this.mnuLammoi.TabIndex = 144;
            this.mnuLammoi.Text = "menuStrip1";
            // 
            // mnuThemmoi
            // 
            this.mnuThemmoi.Image = global::QLBV.Properties.Resources.add1;
            this.mnuThemmoi.Name = "mnuThemmoi";
            this.mnuThemmoi.Size = new System.Drawing.Size(90, 20);
            this.mnuThemmoi.Text = "Thêm mới";
            this.mnuThemmoi.Click += new System.EventHandler(this.mnuThemmoi_Click);
            // 
            // mnuSua
            // 
            this.mnuSua.Image = global::QLBV.Properties.Resources.edit;
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(54, 20);
            this.mnuSua.Text = "Sửa";
            this.mnuSua.Click += new System.EventHandler(this.mnuSua_Click);
            // 
            // mnuLuu
            // 
            this.mnuLuu.Image = global::QLBV.Properties.Resources.Save;
            this.mnuLuu.Name = "mnuLuu";
            this.mnuLuu.Size = new System.Drawing.Size(55, 20);
            this.mnuLuu.Text = "Lưu";
            this.mnuLuu.Click += new System.EventHandler(this.mnuLuu_Click);
            // 
            // mnuHuy
            // 
            this.mnuHuy.Image = global::QLBV.Properties.Resources.Refresh;
            this.mnuHuy.Name = "mnuHuy";
            this.mnuHuy.Size = new System.Drawing.Size(57, 20);
            this.mnuHuy.Text = "Hủy";
            this.mnuHuy.Click += new System.EventHandler(this.mnuHuy_Click);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = global::QLBV.Properties.Resources.Delete;
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(55, 20);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QLBV.Properties.Resources.Stop_2;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(66, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // dgvBacsy
            // 
            this.dgvBacsy.BackgroundColor = System.Drawing.Color.White;
            this.dgvBacsy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacsy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBacsy,
            this.TenBacsy,
            this.SoDT,
            this.Chuyenkhoa});
            this.dgvBacsy.Location = new System.Drawing.Point(14, 222);
            this.dgvBacsy.Name = "dgvBacsy";
            this.dgvBacsy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacsy.Size = new System.Drawing.Size(549, 255);
            this.dgvBacsy.TabIndex = 143;
            // 
            // MaBacsy
            // 
            this.MaBacsy.DataPropertyName = "Mabacsy";
            this.MaBacsy.HeaderText = "Mã bác sỹ";
            this.MaBacsy.Name = "MaBacsy";
            this.MaBacsy.Width = 70;
            // 
            // TenBacsy
            // 
            this.TenBacsy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBacsy.DataPropertyName = "Tenbacsy";
            this.TenBacsy.HeaderText = "Họ tên";
            this.TenBacsy.Name = "TenBacsy";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "SĐT";
            this.SoDT.Name = "SoDT";
            // 
            // Chuyenkhoa
            // 
            this.Chuyenkhoa.DataPropertyName = "Chuyenkhoa";
            this.Chuyenkhoa.HeaderText = "Chuyên khoa";
            this.Chuyenkhoa.Name = "Chuyenkhoa";
            // 
            // txtChuyenkhoa
            // 
            this.txtChuyenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenkhoa.Location = new System.Drawing.Point(109, 189);
            this.txtChuyenkhoa.Name = "txtChuyenkhoa";
            this.txtChuyenkhoa.Size = new System.Drawing.Size(419, 22);
            this.txtChuyenkhoa.TabIndex = 148;
            // 
            // frmBacsy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 487);
            this.Controls.Add(this.txtChuyenkhoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtTenbacsy);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.txtMaBacsy);
            this.Controls.Add(this.lblMabacsy);
            this.Controls.Add(this.mnuLammoi);
            this.Controls.Add(this.dgvBacsy);
            this.Name = "frmBacsy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBacsy";
            this.Load += new System.EventHandler(this.frmBacsy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuLammoi.ResumeLayout(false);
            this.mnuLammoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacsy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtTenbacsy;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtMaBacsy;
        private System.Windows.Forms.Label lblMabacsy;
        private System.Windows.Forms.ToolStripMenuItem mnuHuy;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuThemmoi;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.MenuStrip mnuLammoi;
        private System.Windows.Forms.DataGridView dgvBacsy;
        private System.Windows.Forms.TextBox txtChuyenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacsy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBacsy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuyenkhoa;
    }
}