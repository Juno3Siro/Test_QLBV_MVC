using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBenhnhan_Click(object sender, EventArgs e)
        {
            frmBenhnhan benhnha = new frmBenhnhan();
            benhnha.Show();
        }

        private void btnBenhan_Click(object sender, EventArgs e)
        {
            frmBenhan benhan = new frmBenhan();
            benhan.Show();
        }

        private void btnBacsy_Click(object sender, EventArgs e)
        {
            frmBacsy bs = new frmBacsy();
            bs.Show();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc thuoc = new frmThuoc();
            thuoc.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
