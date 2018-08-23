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
    public partial class frmBenhan : Form
    {
        int trangthai = 0;
        clsData csData;
        public frmBenhan()
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

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                SqlParameter p1 = new SqlParameter("@MaBA", SqlDbType.Int);
                p1.Value = dgvBenhan.CurrentRow.Cells["MaBA"].Value.ToString();

                csData = new clsData();
                sucess = csData.Delete_table("Benhan_Delete", p1);
                if (sucess == true)
                    MessageBox.Show("Cập nhật thành công ");
                else
                    MessageBox.Show("Cập nhật không thành công ");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công ");
            }
            finally
            {
                Hienthi();
                trangthai = 0;
                Set_value();
            }
        }

        private void mnuLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                csData = new clsData();
                if (trangthai == 1)
                    sucess = csData.Insert_table("Benhan_Insert", Benhan_Parameter());
                else
                    sucess = csData.Insert_table("Benhan_Update", Benhan_Parameter());
                if (sucess == true)
                {
                    MessageBox.Show("Cập nhật thành công ");
                }
                else
                    MessageBox.Show("Cập nhật không thành công ");
            }
            catch { MessageBox.Show("Cập nhật không thành công "); }
            finally
            {
                Hienthi();
                trangthai = 0;
                Set_value();
            }
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

        private void frmBenhan_Load(object sender, EventArgs e)
        {
            trangthai = 0;            
            Hienthi();
            Set_value();
        }

        #region Update data
        private void Hienthi()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("Benhan_SelectAll");

            dgvBenhan.DataSource = ds;
            dgvBenhan.DataMember = ds.Tables[0].TableName.ToString();

            Hienthi_BN();
            Hienthi_Bacsy();
        }

        private void Nut_bam()
        {
            if (trangthai == 0)
            {
                txtMaBA.Enabled = false;
                cboMaBN.Enabled = false;
                dtpNgaykham.Enabled = false;
                txtChuandoan.Enabled = false;
                cboMabacsy.Enabled = false;

                txtSearch.Text = "";
                mnuHuy.Enabled = false;
                mnuLuu.Enabled = false;

                dgvBenhan.Enabled = true;
                mnuThemmoi.Enabled = true;
                mnuSua.Enabled = true;
                mnuXoa.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else
            {

                txtMaBA.Enabled = true;
                cboMaBN.Enabled = true;
                dtpNgaykham.Enabled = true;
                txtChuandoan.Enabled = true;
                cboMabacsy.Enabled = true;

                txtSearch.Text = "";
                mnuHuy.Enabled = true;
                mnuLuu.Enabled = true;

                dgvBenhan.Enabled = false;
                mnuThemmoi.Enabled = false;
                mnuSua.Enabled = false;
                mnuXoa.Enabled = false;
                mnuThoat.Enabled = false;
                txtMaBA.Enabled = false;
            }
        }

        private void Set_value()
        {
            if (trangthai == 2)
            {
                Nut_bam();
                txtMaBA.Text = dgvBenhan.CurrentRow.Cells["MaBA"].Value.ToString();
                cboMaBN.SelectedValue  = dgvBenhan.CurrentRow.Cells["MaBN"].Value.ToString();
                dtpNgaykham.Value = Convert.ToDateTime( dgvBenhan.CurrentRow.Cells["Ngaykham"].Value.ToString());
                txtChuandoan.Text = dgvBenhan.CurrentRow.Cells["Chuandoan"].Value.ToString();
                cboMabacsy.SelectedValue = dgvBenhan.CurrentRow.Cells["Mabacsy"].Value.ToString();
            }
            else
            {
                Nut_bam();
                txtMaBA.Text = "";
                
                dtpNgaykham.Value = DateTime.Now.Date;
                txtChuandoan.Text = "";             
                }
        }

        private SqlParameter[] Benhan_Parameter()
        {
            SqlParameter[] sqlpara = new SqlParameter[5];
            SqlParameter p0 = new SqlParameter("@MaBA", SqlDbType.Int);
            p0.Value = txtMaBA.Text;
            sqlpara[0] = p0;

            SqlParameter p1 = new SqlParameter("@MaBN", SqlDbType.VarChar, 15);
            p1.Value = cboMaBN.SelectedValue;
            sqlpara[1] = p1;

            SqlParameter p2 = new SqlParameter("@Ngaykham", SqlDbType.SmallDateTime);
            p2.Value = dtpNgaykham.Value;
            sqlpara[2] = p2;

            SqlParameter p3 = new SqlParameter("@Chuandoan", SqlDbType.NVarChar, 350);
            p3.Value = txtChuandoan.Text;
            sqlpara[3] = p3;

            SqlParameter p4 = new SqlParameter("@Mabacsy", SqlDbType.VarChar , 15);
            p4.Value = cboMabacsy.SelectedValue;
            sqlpara[4] = p4;
           
            return sqlpara;
        }

        private void Hienthi_BN()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("TTBN_SelectAll");

            cboMaBN.DataSource = ds.Tables[0];
            cboMaBN.ValueMember = "MaBN";
            cboMaBN.DisplayMember = "Hoten";
            if (ds.Tables[0].Rows.Count > 0)
             cboMaBN.SelectedIndex = 0;
        }

        private void Hienthi_Bacsy()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("Bacsy_SelectAll");

            cboMabacsy.DataSource = ds.Tables[0];
            cboMabacsy.ValueMember = "Mabacsy";
            cboMabacsy.DisplayMember = "Tenbacsy";
            if (ds.Tables[0].Rows.Count>0)
            cboMabacsy.SelectedIndex = 0;
        }
        private SqlParameter TKBN_Parameter()
        {
            SqlParameter pra = new SqlParameter("@Tim", SqlDbType.NVarChar, 35);
            pra.Value = txtSearch.Text;
            return pra;
        }
        #endregion

        private void mnuDonthuoc_Click(object sender, EventArgs e)
        {
            frmDonthuoc frDonthuoc = new frmDonthuoc();
            frDonthuoc.intMaBA =int.Parse(dgvBenhan.CurrentRow.Cells["MaBA"].Value.ToString());
            frDonthuoc.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            csData = new clsData();
            DataSet ds = new DataSet();
            ds = csData.Search_table("Tim_BA", TKBN_Parameter());
            DataTable dt = new DataTable();
            dgvBenhan.DataSource = ds;
            dgvBenhan.DataMember = ds.Tables[0].TableName.ToString();
        }

        

    }
}
