namespace QLBV
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.mnuLammoi = new System.Windows.Forms.MenuStrip();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.btnBenhan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBacsy = new System.Windows.Forms.Button();
            this.btnBenhnhan = new System.Windows.Forms.Button();
            this.mnuBacsy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBenhnhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhambenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLammoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG KHÁM";
            // 
            // mnuLammoi
            // 
            this.mnuLammoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBacsy,
            this.mnuThuoc,
            this.mnuBenhnhan,
            this.mnuKhambenh,
            this.mnuThoat});
            this.mnuLammoi.Location = new System.Drawing.Point(0, 0);
            this.mnuLammoi.Name = "mnuLammoi";
            this.mnuLammoi.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuLammoi.Size = new System.Drawing.Size(961, 24);
            this.mnuLammoi.TabIndex = 160;
            this.mnuLammoi.Text = "menuStrip1";
            // 
            // btnThuoc
            // 
            this.btnThuoc.Image = global::QLBV.Properties.Resources.Thuoc;
            this.btnThuoc.Location = new System.Drawing.Point(790, 423);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(154, 176);
            this.btnThuoc.TabIndex = 165;
            this.btnThuoc.UseVisualStyleBackColor = true;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // btnBenhan
            // 
            this.btnBenhan.Image = global::QLBV.Properties.Resources.Khambenh;
            this.btnBenhan.Location = new System.Drawing.Point(270, 423);
            this.btnBenhan.Name = "btnBenhan";
            this.btnBenhan.Size = new System.Drawing.Size(147, 176);
            this.btnBenhan.TabIndex = 164;
            this.btnBenhan.UseVisualStyleBackColor = true;
            this.btnBenhan.Click += new System.EventHandler(this.btnBenhan_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = global::QLBV.Properties.Resources.PMQLBV;
            this.button3.Location = new System.Drawing.Point(500, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 186);
            this.button3.TabIndex = 163;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBacsy
            // 
            this.btnBacsy.Image = global::QLBV.Properties.Resources.Bacsy;
            this.btnBacsy.Location = new System.Drawing.Point(790, 178);
            this.btnBacsy.Name = "btnBacsy";
            this.btnBacsy.Size = new System.Drawing.Size(130, 163);
            this.btnBacsy.TabIndex = 162;
            this.btnBacsy.UseVisualStyleBackColor = true;
            this.btnBacsy.Click += new System.EventHandler(this.btnBacsy_Click);
            // 
            // btnBenhnhan
            // 
            this.btnBenhnhan.Image = global::QLBV.Properties.Resources.benhnhan;
            this.btnBenhnhan.Location = new System.Drawing.Point(270, 178);
            this.btnBenhnhan.Name = "btnBenhnhan";
            this.btnBenhnhan.Size = new System.Drawing.Size(131, 150);
            this.btnBenhnhan.TabIndex = 161;
            this.btnBenhnhan.UseVisualStyleBackColor = true;
            this.btnBenhnhan.Click += new System.EventHandler(this.btnBenhnhan_Click);
            // 
            // mnuBacsy
            // 
            this.mnuBacsy.Image = global::QLBV.Properties.Resources.add1;
            this.mnuBacsy.Name = "mnuBacsy";
            this.mnuBacsy.Size = new System.Drawing.Size(68, 20);
            this.mnuBacsy.Text = "Bác sỹ";
            // 
            // mnuThuoc
            // 
            this.mnuThuoc.Image = global::QLBV.Properties.Resources.edit;
            this.mnuThuoc.Name = "mnuThuoc";
            this.mnuThuoc.Size = new System.Drawing.Size(69, 20);
            this.mnuThuoc.Text = "Thuốc";
            // 
            // mnuBenhnhan
            // 
            this.mnuBenhnhan.Image = global::QLBV.Properties.Resources.Save;
            this.mnuBenhnhan.Name = "mnuBenhnhan";
            this.mnuBenhnhan.Size = new System.Drawing.Size(92, 20);
            this.mnuBenhnhan.Text = "Bệnh nhân";
            // 
            // mnuKhambenh
            // 
            this.mnuKhambenh.Image = global::QLBV.Properties.Resources.Refresh;
            this.mnuKhambenh.Name = "mnuKhambenh";
            this.mnuKhambenh.Size = new System.Drawing.Size(96, 20);
            this.mnuKhambenh.Text = "Khám bệnh";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QLBV.Properties.Resources.Stop_2;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(66, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 632);
            this.Controls.Add(this.btnThuoc);
            this.Controls.Add(this.btnBenhan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBacsy);
            this.Controls.Add(this.btnBenhnhan);
            this.Controls.Add(this.mnuLammoi);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuLammoi.ResumeLayout(false);
            this.mnuLammoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuLammoi;
        private System.Windows.Forms.ToolStripMenuItem mnuBacsy;
        private System.Windows.Forms.ToolStripMenuItem mnuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuBenhnhan;
        private System.Windows.Forms.ToolStripMenuItem mnuKhambenh;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Button btnBenhnhan;
        private System.Windows.Forms.Button btnBacsy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Button btnBenhan;
    }
}

