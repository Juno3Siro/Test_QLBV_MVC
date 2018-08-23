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
    public partial class frmBacsy : Form
    {
        int trangthai = 0;
        clsData csData;
        public frmBacsy()
        {
            InitializeComponent();
        }

        private void frmBacsy_Load(object sender, EventArgs e)
        {
            trangthai = 0;
            Set_value();
            Hienthi();
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

        private void mnuLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                csData = new clsData();
                if (trangthai == 1)
                    sucess = csData.Insert_table("Bacsy_Insert", Bacsy_Parameter());
                else
                    sucess = csData.Insert_table("Bacsy_Update", Bacsy_Parameter());
                if (sucess == true)
                {
                    MessageBox.Show("Cập nhật thành công ");
                }        
                else
                    MessageBox.Show("Cập nhật không thành công ");
            }
            catch { MessageBox.Show("Cập nhật không thành công "); }
            finally {
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

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                SqlParameter p1 = new SqlParameter("@MaBacsy", SqlDbType.VarChar, 15);
                p1.Value = dgvBacsy.CurrentRow.Cells["MaBacsy"].Value.ToString();

                csData = new clsData();
                sucess = csData.Delete_table("Bacsy_Delete", p1);
                if (sucess == true)
                    MessageBox.Show("Cập nhật thành công ");
                else
                    MessageBox.Show("Cập nhật không thành công ");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công ");
            }
            finally {
                Hienthi();
                trangthai = 0;
                Set_value();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Update data
        private void Hienthi()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("Bacsy_SelectAll");

            dgvBacsy.DataSource = ds;
            dgvBacsy.DataMember = ds.Tables[0].TableName.ToString();
        }

        private void Nut_bam()
        {
            if (trangthai == 0)
            {
                txtMaBacsy.Enabled = false;
                txtTenbacsy.Enabled = false;               
                txtSoDT.Enabled = false;
                txtChuyenkhoa.Enabled = false;
               
                txtSearch.Text = "";
                mnuHuy.Enabled = false;
                mnuLuu.Enabled = false;

                dgvBacsy.Enabled = true;
                mnuThemmoi.Enabled = true;
                mnuSua.Enabled = true;
                mnuXoa.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else
            {
                txtTenbacsy.Enabled = true;
                txtChuyenkhoa.Enabled = true;
                txtSoDT.Enabled = true;
                txtSearch.Enabled = true;
               
                mnuHuy.Enabled = true;
                mnuLuu.Enabled = true;

                dgvBacsy.Enabled = false;
                mnuThemmoi.Enabled = false;
                mnuSua.Enabled = false;
                mnuXoa.Enabled = false;
                mnuThoat.Enabled = false;
                if (trangthai == 1)
                    txtMaBacsy.Enabled = true;
                else
                    txtMaBacsy.Enabled = false;
            }
        }

        private void Set_value()
        {
            if (trangthai == 2)
            {
                Nut_bam();
                txtMaBacsy.Text = dgvBacsy.CurrentRow.Cells["MaBacsy"].Value.ToString();
                txtTenbacsy.Text = dgvBacsy.CurrentRow.Cells["Tenbacsy"].Value.ToString();
                txtSoDT.Text = dgvBacsy.CurrentRow.Cells["SoDT"].Value.ToString();
                txtChuyenkhoa.Text = dgvBacsy.CurrentRow.Cells["Chuyenkhoa"].Value.ToString();
            }
            else
            {
                Nut_bam();
                txtMaBacsy.Text = "";
                txtTenbacsy.Text = "";
                txtChuyenkhoa.Text = "";
                txtSoDT.Text = "";
            }
        }

        private SqlParameter[] Bacsy_Parameter()
        {
            SqlParameter[] sqlpara = new SqlParameter[4];
            SqlParameter p1 = new SqlParameter("@MaBacsy", SqlDbType.VarChar, 15);
            p1.Value = txtMaBacsy.Text;
            sqlpara[0] = p1;

            SqlParameter p2 = new SqlParameter("@Tenbacsy", SqlDbType.NVarChar, 50);
            p2.Value = txtTenbacsy.Text;
            sqlpara[1] = p2;

            SqlParameter p3 = new SqlParameter("@SoDT", SqlDbType.VarChar, 15);
            p3.Value = txtSoDT.Text;
            sqlpara[2] = p3;
            
            SqlParameter p4 = new SqlParameter("@Chuyenkhoa", SqlDbType.NVarChar, 150);
            p4.Value = txtChuyenkhoa.Text;
            sqlpara[3] = p4;

            return sqlpara;
        }
        private SqlParameter TKBN_Parameter()
        {
            SqlParameter pra = new SqlParameter("@Tim", SqlDbType.NVarChar, 35);
            pra.Value = txtSearch.Text;
            return pra;
        }
        #endregion

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            csData = new clsData();
            DataSet ds = new DataSet();
            ds = csData.Search_table("Tim_BS", TKBN_Parameter());
            DataTable dt = new DataTable();
            dgvBacsy.DataSource = ds;
            dgvBacsy.DataMember = ds.Tables[0].TableName.ToString();
        }
    }
}
