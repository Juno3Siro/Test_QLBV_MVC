namespace QLBV
{
    partial class frmDonthuoc
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
            this.mnuLammoi = new System.Windows.Forms.MenuStrip();
            this.mnuInDonthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLieudung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaykedon = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblBenhnha = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.lblMBN = new System.Windows.Forms.Label();
            this.txtBenhnhan = new System.Windows.Forms.TextBox();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchThuoc = new System.Windows.Forms.Button();
            this.dgvDonthuoc = new System.Windows.Forms.DataGridView();
            this.txtBacsy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChuandoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaBA = new System.Windows.Forms.Label();
            this.mnuThemmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLammoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuLammoi
            // 
            this.mnuLammoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemmoi,
            this.mnuSua,
            this.mnuLuu,
            this.mnuHuy,
            this.mnuXoa,
            this.mnuInDonthuoc,
            this.mnuThoat});
            this.mnuLammoi.Location = new System.Drawing.Point(0, 0);
            this.mnuLammoi.Name = "mnuLammoi";
            this.mnuLammoi.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuLammoi.Size = new System.Drawing.Size(888, 24);
            this.mnuLammoi.TabIndex = 159;
            this.mnuLammoi.Text = "menuStrip1";
            // 
            // mnuInDonthuoc
            // 
            this.mnuInDonthuoc.Name = "mnuInDonthuoc";
            this.mnuInDonthuoc.Size = new System.Drawing.Size(87, 20);
            this.mnuInDonthuoc.Text = "In đơn thuốc";
            // 
            // txtLieudung
            // 
            this.txtLieudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieudung.Location = new System.Drawing.Point(128, 249);
            this.txtLieudung.Margin = new System.Windows.Forms.Padding(4);
            this.txtLieudung.Name = "txtLieudung";
            this.txtLieudung.Size = new System.Drawing.Size(747, 21);
            this.txtLieudung.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "Liều dùng";
            // 
            // dtpNgaykedon
            // 
            this.dtpNgaykedon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaykedon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykedon.Location = new System.Drawing.Point(711, 24);
            this.dtpNgaykedon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaykedon.Name = "dtpNgaykedon";
            this.dtpNgaykedon.Size = new System.Drawing.Size(135, 21);
            this.dtpNgaykedon.TabIndex = 2;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.BackColor = System.Drawing.Color.Transparent;
            this.lblTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuoi.ForeColor = System.Drawing.Color.Black;
            this.lblTuoi.Location = new System.Drawing.Point(615, 27);
            this.lblTuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(88, 17);
            this.lblTuoi.TabIndex = 153;
            this.lblTuoi.Text = "Ngày kê đơn";
            // 
            // lblBenhnha
            // 
            this.lblBenhnha.AutoSize = true;
            this.lblBenhnha.BackColor = System.Drawing.Color.Transparent;
            this.lblBenhnha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenhnha.ForeColor = System.Drawing.Color.Black;
            this.lblBenhnha.Location = new System.Drawing.Point(13, 27);
            this.lblBenhnha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenhnha.Name = "lblBenhnha";
            this.lblBenhnha.Size = new System.Drawing.Size(71, 16);
            this.lblBenhnha.TabIndex = 152;
            this.lblBenhnha.Text = "Bệnh nhân";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDT.Location = new System.Drawing.Point(128, 144);
            this.txtMaDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(132, 21);
            this.txtMaDT.TabIndex = 0;
            // 
            // lblMBN
            // 
            this.lblMBN.AutoSize = true;
            this.lblMBN.BackColor = System.Drawing.Color.Transparent;
            this.lblMBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMBN.ForeColor = System.Drawing.Color.Black;
            this.lblMBN.Location = new System.Drawing.Point(16, 148);
            this.lblMBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMBN.Name = "lblMBN";
            this.lblMBN.Size = new System.Drawing.Size(94, 17);
            this.lblMBN.TabIndex = 150;
            this.lblMBN.Text = "Mã đơn thuốc";
            // 
            // txtBenhnhan
            // 
            this.txtBenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenhnhan.Location = new System.Drawing.Point(112, 23);
            this.txtBenhnhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtBenhnhan.Name = "txtBenhnhan";
            this.txtBenhnhan.Size = new System.Drawing.Size(205, 21);
            this.txtBenhnhan.TabIndex = 1;
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Location = new System.Drawing.Point(128, 179);
            this.cboThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(636, 23);
            this.cboThuoc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 165;
            this.label4.Text = "Thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(310, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 152;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(411, 213);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(212, 21);
            this.txtDVT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 152;
            this.label6.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(128, 213);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(132, 21);
            this.txtSoluong.TabIndex = 4;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(128, 279);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(747, 47);
            this.txtGhichu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 167;
            this.label7.Text = "Ghi chú";
            // 
            // btnSearchThuoc
            // 
            this.btnSearchThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchThuoc.Location = new System.Drawing.Point(775, 176);
            this.btnSearchThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchThuoc.Name = "btnSearchThuoc";
            this.btnSearchThuoc.Size = new System.Drawing.Size(100, 28);
            this.btnSearchThuoc.TabIndex = 169;
            this.btnSearchThuoc.Text = "Search";
            this.btnSearchThuoc.UseVisualStyleBackColor = true;
            // 
            // dgvDonthuoc
            // 
            this.dgvDonthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonthuoc.Location = new System.Drawing.Point(16, 334);
            this.dgvDonthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonthuoc.Name = "dgvDonthuoc";
            this.dgvDonthuoc.Size = new System.Drawing.Size(862, 249);
            this.dgvDonthuoc.TabIndex = 170;
            // 
            // txtBacsy
            // 
            this.txtBacsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacsy.Location = new System.Drawing.Point(384, 24);
            this.txtBacsy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBacsy.Name = "txtBacsy";
            this.txtBacsy.Size = new System.Drawing.Size(205, 21);
            this.txtBacsy.TabIndex = 171;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBacsy);
            this.groupBox1.Controls.Add(this.txtChuandoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBenhnhan);
            this.groupBox1.Controls.Add(this.lblBenhnha);
            this.groupBox1.Controls.Add(this.dtpNgaykedon);
            this.groupBox1.Controls.Add(this.lblTuoi);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(856, 96);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtChuandoan
            // 
            this.txtChuandoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuandoan.Location = new System.Drawing.Point(112, 59);
            this.txtChuandoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtChuandoan.Name = "txtChuandoan";
            this.txtChuandoan.Size = new System.Drawing.Size(734, 21);
            this.txtChuandoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 152;
            this.label3.Text = "Chuẩn đoán";
            // 
            // lblMaBA
            // 
            this.lblMaBA.AutoSize = true;
            this.lblMaBA.BackColor = System.Drawing.Color.Transparent;
            this.lblMaBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBA.ForeColor = System.Drawing.Color.Black;
            this.lblMaBA.Location = new System.Drawing.Point(804, 334);
            this.lblMaBA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBA.Name = "lblMaBA";
            this.lblMaBA.Size = new System.Drawing.Size(17, 16);
            this.lblMaBA.TabIndex = 172;
            this.lblMaBA.Text = "   ";
            this.lblMaBA.Visible = false;
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
            // frmDonthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 611);
            this.Controls.Add(this.lblMaBA);
            this.Controls.Add(this.dgvDonthuoc);
            this.Controls.Add(this.btnSearchThuoc);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuLammoi);
            this.Controls.Add(this.txtLieudung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.lblMBN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonthuoc";
            this.Load += new System.EventHandler(this.frmDonthuoc_Load);
            this.mnuLammoi.ResumeLayout(false);
            this.mnuLammoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.MenuStrip mnuLammoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThemmoi;
        private System.Windows.Forms.ToolStripMenuItem mnuHuy;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        //private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.TextBox txtLieudung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaykedon;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblBenhnha;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label lblMBN;
        private System.Windows.Forms.TextBox txtBenhnhan;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchThuoc;
        private System.Windows.Forms.DataGridView dgvDonthuoc;
        private System.Windows.Forms.TextBox txtBacsy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChuandoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaBA;
        private System.Windows.Forms.ToolStripMenuItem mnuInDonthuoc;
    }
}