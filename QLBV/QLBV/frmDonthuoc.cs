using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using _38CNT1_QLSV; 

namespace QLBV
{
    public partial class frmDonthuoc : Form
    {
        int trangthai = 0;
        clsData csData;
        public int intMaBA = 0;
        public frmDonthuoc()
        {
            InitializeComponent();
        }

        private void mnuThemmoi_Click(object sender, EventArgs e)
        {
            trangthai = 1;
            Set_value();
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            trangthai = 2;
            Set_value();
        }

        private void mnuHuy_Click(object sender, EventArgs e)
        {
            trangthai = 0;
            Set_value();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            SqlParameter p1 = new SqlParameter("@MaDT", SqlDbType.VarChar, 15);
            p1.Value = dgvDonthuoc.CurrentRow.Cells["MaDT"].Value.ToString();

            csData = new clsData();
            sucess = csData.Delete_table("Donthuoc_Delete", p1);
            if (sucess == false)
            {
                MessageBox.Show("Cập nhật không thành công ");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công ");
                Hienthi();
                trangthai = 0;
                Set_value();
            }
        }

        private void mnuLuu_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            csData = new clsData();
            if (trangthai == 1)
                sucess = csData.Insert_table("Donthuoc_Insert", Donthuoc_Parameter());
            else
                sucess = csData.Insert_table("Donthuoc_Update", Donthuoc_Parameter());
            if (sucess == false)
            {
                MessageBox.Show("Cập nhật không thành công ");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công ");
                Hienthi();
                trangthai = 0;
                Set_value();
            }
        }

        private void frmDonthuoc_Load(object sender, EventArgs e)
        {
            trangthai = 0;
            Hienthi();
            Set_value();            
        }
        #region Update data
        private void Hienthi()
        {
            csData = new clsData();
            SqlParameter p1 = new SqlParameter("@MaBenhan", SqlDbType.Int);
            p1.Value = intMaBA;

            DataSet ds = new DataSet();
            ds = csData.Select_table("Donthuoc_SelectByMaBA", p1);

            dgvDonthuoc.DataSource = ds;
            dgvDonthuoc.DataMember = ds.Tables[0].TableName.ToString();

            Hienthi_TT_Benhan();
            Hienthi_Thuoc();
            
            
        }

        private void Nut_bam()
        {
            txtBenhnhan.Enabled = false;
            txtBacsy.Enabled = false;
            txtChuandoan.Enabled = false;
            dtpNgaykedon.Enabled = false;
            txtMaDT.Enabled = false;

            if (trangthai == 0)
            {
                cboThuoc.Enabled = false;
                txtSoluong.Enabled = false;
                txtDVT.Enabled = false;
                txtLieudung.Enabled = false;
                txtGhichu.Enabled = false;
                btnSearchThuoc.Enabled = false;
   
                mnuHuy.Enabled = false;
                mnuLuu.Enabled = false;

                dgvDonthuoc.Enabled = true;
                mnuThemmoi.Enabled = true;
                mnuSua.Enabled = true;
                mnuXoa.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else
            {

                cboThuoc.Enabled = true;
                txtSoluong.Enabled = true;
                txtDVT.Enabled = true;
                txtLieudung.Enabled = true;
                txtGhichu.Enabled = true;
                btnSearchThuoc.Enabled = true;

                mnuHuy.Enabled = true;
                mnuLuu.Enabled = true;

                dgvDonthuoc.Enabled = false;
                mnuThemmoi.Enabled = false;
                mnuSua.Enabled = false;
                mnuXoa.Enabled = false;
                mnuThoat.Enabled = false;
                txtMaDT.Enabled = false;
            }
        }

        private void Set_value()
        {
            if (trangthai == 2)
            {
                Nut_bam();
                txtMaDT.Text = dgvDonthuoc.CurrentRow.Cells["MaDT"].Value.ToString();
                cboThuoc.SelectedValue = dgvDonthuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
                txtSoluong.Text = dgvDonthuoc.CurrentRow.Cells["Soluong"].Value.ToString();
                txtDVT.Text = dgvDonthuoc.CurrentRow.Cells["DVT"].Value.ToString();
                txtLieudung.Text = dgvDonthuoc.CurrentRow.Cells["Lieudung"].Value.ToString();
                txtGhichu.Text = dgvDonthuoc.CurrentRow.Cells["Ghichu"].Value.ToString();
                dtpNgaykedon.Value = Convert.ToDateTime(dgvDonthuoc.CurrentRow.Cells["Ngaykedon"].Value.ToString());
            }
            else
            {
                Nut_bam();
                txtMaDT.Text = "";
                cboThuoc.SelectedIndex=0;
                txtSoluong.Text = "";
                txtDVT.Text = "";
                txtLieudung.Text = "";
                txtGhichu.Text = "";
                dtpNgaykedon.Value = DateTime.Now.Date;
            }
        }

        private SqlParameter[] Donthuoc_Parameter()
        {
            SqlParameter[] sqlpara = new SqlParameter[8];
            SqlParameter p0 = new SqlParameter("@MaDT", SqlDbType.Int);
            p0.Value = txtMaDT.Text;
            sqlpara[0] = p0;

            SqlParameter p1 = new SqlParameter("@MaBenhan", SqlDbType.Int);
            p1.Value = lblMaBA.Text;
            sqlpara[1] = p1;

            SqlParameter p2 = new SqlParameter("@Mathuoc", SqlDbType.VarChar, 15);
            p2.Value = cboThuoc.SelectedValue;
            sqlpara[2] = p2;

            SqlParameter p3 = new SqlParameter("@DVT", SqlDbType.NVarChar, 25);
            p3.Value = txtDVT.Text;
            sqlpara[3] = p3;

            SqlParameter p4 = new SqlParameter("@Soluong", SqlDbType.Int);
            p4.Value = txtSoluong.Text;
            sqlpara[4] = p4;

            SqlParameter p5 = new SqlParameter("@Ngaykedon", SqlDbType.SmallDateTime);
            p5.Value = dtpNgaykedon.Value;
            sqlpara[5] = p5;

            SqlParameter p6 = new SqlParameter("@Lieudung", SqlDbType.NVarChar, 300);
            p6.Value = txtLieudung.Text;
            sqlpara[6] = p6;

            SqlParameter p7 = new SqlParameter("@Ghichu", SqlDbType.NVarChar, 300);
            p7.Value = txtGhichu.Text;
            sqlpara[7] = p7;
            return sqlpara;
        }

        private void Hienthi_TT_Benhan()
        {
            csData = new clsData();
            SqlParameter p1 = new SqlParameter("@MaBenhan", SqlDbType.Int);
            p1.Value = intMaBA;

            DataSet ds = new DataSet();
            ds = csData.Select_table("BenhAn_SelectByID", p1);
          
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataRow dr;
            dr = dt.Rows[0];

            if (ds.Tables[0].Rows.Count > 0)
            {
               txtBenhnhan.Text = dr["Hoten"].ToString();
               txtBacsy.Text = dr["TenBacsy"].ToString();
               txtChuandoan.Text = dr["Chuandoan"].ToString();
               lblMaBA.Text = dr["MaBA"].ToString();
            }
        }

        private void Hienthi_Thuoc()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("Thuoc_SelectAll");

            cboThuoc.DataSource = ds.Tables[0];
            cboThuoc.ValueMember = "MaThuoc";
            cboThuoc.DisplayMember = "TenThuoc";
            if (ds.Tables[0].Rows.Count > 0)
                cboThuoc.SelectedIndex = 0;
        }
        #endregion
    }
}
