namespace QLBV
{
    partial class frmThuoc
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
            this.txtTacdung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblMBN = new System.Windows.Forms.Label();
            this.mnuLammoi = new System.Windows.Forms.MenuStrip();
            this.mnuThemmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLieudung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtLuuy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.mnuLammoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
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
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "Thuốc";
            // 
            // txtTacdung
            // 
            this.txtTacdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacdung.Location = new System.Drawing.Point(87, 201);
            this.txtTacdung.Multiline = true;
            this.txtTacdung.Name = "txtTacdung";
            this.txtTacdung.Size = new System.Drawing.Size(577, 39);
            this.txtTacdung.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Tác dụng";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioitinh.Location = new System.Drawing.Point(15, 175);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(68, 16);
            this.lblGioitinh.TabIndex = 134;
            this.lblGioitinh.Text = "Đơn vị tính";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenthuoc.Location = new System.Drawing.Point(87, 144);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(251, 22);
            this.txtTenthuoc.TabIndex = 133;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.Color.Transparent;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.Black;
            this.lblHoten.Location = new System.Drawing.Point(15, 147);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(67, 16);
            this.lblHoten.TabIndex = 132;
            this.lblHoten.Text = "Tên thuốc";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.Location = new System.Drawing.Point(87, 115);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(100, 22);
            this.txtMaThuoc.TabIndex = 131;
            // 
            // lblMBN
            // 
            this.lblMBN.AutoSize = true;
            this.lblMBN.BackColor = System.Drawing.Color.Transparent;
            this.lblMBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMBN.ForeColor = System.Drawing.Color.Black;
            this.lblMBN.Location = new System.Drawing.Point(15, 118);
            this.lblMBN.Name = "lblMBN";
            this.lblMBN.Size = new System.Drawing.Size(62, 16);
            this.lblMBN.TabIndex = 130;
            this.lblMBN.Text = "Mã thuốc";
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
            this.mnuLammoi.Size = new System.Drawing.Size(686, 24);
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
            // txtLieudung
            // 
            this.txtLieudung.Location = new System.Drawing.Point(87, 246);
            this.txtLieudung.Multiline = true;
            this.txtLieudung.Name = "txtLieudung";
            this.txtLieudung.Size = new System.Drawing.Size(578, 59);
            this.txtLieudung.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Liều dùng";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.Tenthuoc,
            this.DVT,
            this.Tacdung,
            this.Lieudung,
            this.Luuy});
            this.dgvThuoc.Location = new System.Drawing.Point(14, 351);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(662, 201);
            this.dgvThuoc.TabIndex = 143;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 70;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // Tacdung
            // 
            this.Tacdung.DataPropertyName = "Tacdung";
            this.Tacdung.HeaderText = "Tác dụng";
            this.Tacdung.Name = "Tacdung";
            // 
            // Lieudung
            // 
            this.Lieudung.DataPropertyName = "Lieudung";
            this.Lieudung.HeaderText = "Liều dùng";
            this.Lieudung.Name = "Lieudung";
            this.Lieudung.Width = 50;
            // 
            // Luuy
            // 
            this.Luuy.DataPropertyName = "Luuy";
            this.Luuy.HeaderText = "Lưu ý";
            this.Luuy.Name = "Luuy";
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(87, 172);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(100, 22);
            this.txtDVT.TabIndex = 148;
            // 
            // txtLuuy
            // 
            this.txtLuuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuuy.Location = new System.Drawing.Point(87, 311);
            this.txtLuuy.Name = "txtLuuy";
            this.txtLuuy.Size = new System.Drawing.Size(577, 22);
            this.txtLuuy.TabIndex = 150;
            this.txtLuuy.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 149;
            this.label4.Text = "Lưu ý";
            this.label4.UseWaitCursor = true;
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 563);
            this.Controls.Add(this.txtLuuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTacdung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.txtTenthuoc);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.lblMBN);
            this.Controls.Add(this.mnuLammoi);
            this.Controls.Add(this.txtLieudung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThuoc);
            this.Name = "frmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThuoc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuLammoi.ResumeLayout(false);
            this.mnuLammoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacdung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuThemmoi;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblMBN;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHuy;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.MenuStrip mnuLammoi;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.TextBox txtLieudung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtLuuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacdung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luuy;
    }
}