namespace QLBV
{
    partial class frmBenhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuandoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaykham = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtMaBA = new System.Windows.Forms.TextBox();
            this.lblMBN = new System.Windows.Forms.Label();
            this.mnuLammoi = new System.Windows.Forms.MenuStrip();
            this.mnuThemmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBenhan = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mabacsy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaBN = new System.Windows.Forms.ComboBox();
            this.cboMabacsy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.mnuLammoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 50);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(260, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 132;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "Bệnh án";
            // 
            // txtChuandoan
            // 
            this.txtChuandoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuandoan.Location = new System.Drawing.Point(93, 160);
            this.txtChuandoan.Multiline = true;
            this.txtChuandoan.Name = "txtChuandoan";
            this.txtChuandoan.Size = new System.Drawing.Size(577, 39);
            this.txtChuandoan.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Chuẩn đoán";
            // 
            // dtpNgaykham
            // 
            this.dtpNgaykham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaykham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykham.Location = new System.Drawing.Point(510, 96);
            this.dtpNgaykham.Name = "dtpNgaykham";
            this.dtpNgaykham.Size = new System.Drawing.Size(167, 22);
            this.dtpNgaykham.TabIndex = 136;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.BackColor = System.Drawing.Color.Transparent;
            this.lblTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuoi.ForeColor = System.Drawing.Color.Black;
            this.lblTuoi.Location = new System.Drawing.Point(416, 99);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(77, 16);
            this.lblTuoi.TabIndex = 135;
            this.lblTuoi.Text = "Ngày khám";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.Color.Transparent;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.Black;
            this.lblHoten.Location = new System.Drawing.Point(9, 134);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(71, 16);
            this.lblHoten.TabIndex = 132;
            this.lblHoten.Text = "Bệnh nhân";
            // 
            // txtMaBA
            // 
            this.txtMaBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBA.Location = new System.Drawing.Point(93, 102);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(100, 22);
            this.txtMaBA.TabIndex = 131;
            // 
            // lblMBN
            // 
            this.lblMBN.AutoSize = true;
            this.lblMBN.BackColor = System.Drawing.Color.Transparent;
            this.lblMBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMBN.ForeColor = System.Drawing.Color.Black;
            this.lblMBN.Location = new System.Drawing.Point(9, 105);
            this.lblMBN.Name = "lblMBN";
            this.lblMBN.Size = new System.Drawing.Size(78, 16);
            this.lblMBN.TabIndex = 130;
            this.lblMBN.Text = "Mã bệnh án";
            // 
            // mnuLammoi
            // 
            this.mnuLammoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemmoi,
            this.mnuSua,
            this.mnuLuu,
            this.mnuHuy,
            this.mnuXoa,
            this.mnuDonthuoc,
            this.mnuThoat});
            this.mnuLammoi.Location = new System.Drawing.Point(0, 0);
            this.mnuLammoi.Name = "mnuLammoi";
            this.mnuLammoi.Size = new System.Drawing.Size(695, 24);
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
            // mnuDonthuoc
            // 
            this.mnuDonthuoc.Name = "mnuDonthuoc";
            this.mnuDonthuoc.Size = new System.Drawing.Size(75, 20);
            this.mnuDonthuoc.Text = "Đơn thuốc";
            this.mnuDonthuoc.Click += new System.EventHandler(this.mnuDonthuoc_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QLBV.Properties.Resources.Stop_2;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(66, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Bác sỹ";
            // 
            // dgvBenhan
            // 
            this.dgvBenhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBenhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
            this.Ngaykham,
            this.Chuandoan,
            this.Mabacsy});
            this.dgvBenhan.Location = new System.Drawing.Point(14, 232);
            this.dgvBenhan.Name = "dgvBenhan";
            this.dgvBenhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhan.Size = new System.Drawing.Size(662, 285);
            this.dgvBenhan.TabIndex = 143;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã bệnh án";
            this.MaBA.Name = "MaBA";
            this.MaBA.Width = 70;
            // 
            // MaBN
            // 
            this.MaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Bệnh nhân";
            this.MaBN.Name = "MaBN";
            // 
            // Ngaykham
            // 
            this.Ngaykham.DataPropertyName = "Ngaykham";
            this.Ngaykham.HeaderText = "Ngày khám";
            this.Ngaykham.Name = "Ngaykham";
            // 
            // Chuandoan
            // 
            this.Chuandoan.DataPropertyName = "Chuandoan";
            this.Chuandoan.HeaderText = "Chuẩn đoán";
            this.Chuandoan.Name = "Chuandoan";
            // 
            // Mabacsy
            // 
            this.Mabacsy.DataPropertyName = "Mabacsy";
            this.Mabacsy.HeaderText = "Bác sỹ";
            this.Mabacsy.Name = "Mabacsy";
            this.Mabacsy.Width = 50;
            // 
            // cboMaBN
            // 
            this.cboMaBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(93, 133);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(205, 21);
            this.cboMaBN.TabIndex = 148;
            // 
            // cboMabacsy
            // 
            this.cboMabacsy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMabacsy.FormattingEnabled = true;
            this.cboMabacsy.Location = new System.Drawing.Point(93, 205);
            this.cboMabacsy.Name = "cboMabacsy";
            this.cboMabacsy.Size = new System.Drawing.Size(205, 21);
            this.cboMabacsy.TabIndex = 149;
            // 
            // frmBenhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 528);
            this.Controls.Add(this.cboMabacsy);
            this.Controls.Add(this.cboMaBN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChuandoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaykham);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.txtMaBA);
            this.Controls.Add(this.lblMBN);
            this.Controls.Add(this.mnuLammoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBenhan);
            this.Name = "frmBenhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBenhan";
            this.Load += new System.EventHandler(this.frmBenhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuLammoi.ResumeLayout(false);
            this.mnuLammoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuandoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuThemmoi;
        private System.Windows.Forms.DateTimePicker dtpNgaykham;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtMaBA;
        private System.Windows.Forms.Label lblMBN;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHuy;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.MenuStrip mnuLammoi;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBenhan;
        private System.Windows.Forms.ComboBox cboMaBN;
        private System.Windows.Forms.ComboBox cboMabacsy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mabacsy;
        private System.Windows.Forms.ToolStripMenuItem mnuDonthuoc;
    }
}