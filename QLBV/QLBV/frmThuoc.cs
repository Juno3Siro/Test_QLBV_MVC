using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using _38CNT1_QLSV;

namespace QLBV
{
    public partial class frmThuoc : Form
    {
        int trangthai = 0;
        clsData csData;
        public frmThuoc()
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

        private void mnuLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                csData = new clsData();
                if (trangthai == 1)
                    sucess = csData.Insert_table("Thuoc_Insert", Thuoc_Parameter());
                else
                    sucess = csData.Insert_table("Thuoc_Update", Thuoc_Parameter());
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

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucess = true;
                SqlParameter p1 = new SqlParameter("@MaThuoc", SqlDbType.VarChar, 15);
                p1.Value = dgvThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();

                csData = new clsData();
                sucess = csData.Delete_table("Thuoc_Delete", p1);
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

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            trangthai = 0;
            Set_value();
            Hienthi();
        }

        #region Update data
        private void Hienthi()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("Thuoc_SelectAll");

            dgvThuoc.DataSource = ds;
            dgvThuoc.DataMember = ds.Tables[0].TableName.ToString();
        }

        private void Nut_bam()
        {
            if (trangthai == 0)
            {
                txtMaThuoc.Enabled = false;
                txtTenthuoc.Enabled = false;
                txtDVT.Enabled = false;
                txtLieudung.Enabled = false;
                txtTacdung.Enabled = false;
                txtLuuy.Enabled = false;

                txtSearch.Text = "";
                mnuHuy.Enabled = false;
                mnuLuu.Enabled = false;

                dgvThuoc.Enabled = true;
                mnuThemmoi.Enabled = true;
                mnuSua.Enabled = true;
                mnuXoa.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else
            {

                txtTenthuoc.Enabled = true;
                txtDVT.Enabled = true;
                txtLieudung.Enabled = true;
                txtTacdung.Enabled = true;
                txtLuuy.Enabled = true;

                txtSearch.Text = "";
                mnuHuy.Enabled = true;
                mnuLuu.Enabled = true;

                dgvThuoc.Enabled = false;
                mnuThemmoi.Enabled = false;
                mnuSua.Enabled = false;
                mnuXoa.Enabled = false;
                mnuThoat.Enabled = false;
                if (trangthai == 1)
                    txtMaThuoc.Enabled = true;
                else
                    txtMaThuoc.Enabled = false;
            }
        }

        private void Set_value()
        {
            if (trangthai == 2)
            {
                Nut_bam();
                txtMaThuoc.Text = dgvThuoc.CurrentRow.Cells["MaThuoc"].Value.ToString();
                txtTenthuoc.Text = dgvThuoc.CurrentRow.Cells["Tenthuoc"].Value.ToString();
                txtDVT.Text = dgvThuoc.CurrentRow.Cells["DVT"].Value.ToString();
                txtLieudung.Text = dgvThuoc.CurrentRow.Cells["Lieudung"].Value.ToString();
                txtTacdung.Text = dgvThuoc.CurrentRow.Cells["Tacdung"].Value.ToString();
                txtLuuy.Text = dgvThuoc.CurrentRow.Cells["Luuy"].Value.ToString();
            }
            else
            {
                Nut_bam();
                txtMaThuoc.Text = "";
                txtTenthuoc.Text = "";
                txtDVT.Text = "";
                txtLieudung.Text = "";
                txtTacdung.Text = "";
                txtLuuy.Text = "";
            }
        }

        private SqlParameter[] Thuoc_Parameter()
        {
            SqlParameter[] sqlpara = new SqlParameter[6];
            SqlParameter p0 = new SqlParameter("@Mathuoc", SqlDbType.VarChar, 15);
            p0.Value = txtMaThuoc.Text;
            sqlpara[0] = p0;

            SqlParameter p1 = new SqlParameter("@TenThuoc", SqlDbType.NVarChar, 350);
            p1.Value = txtTenthuoc.Text;
            sqlpara[1] = p1;

            SqlParameter p2 = new SqlParameter("@DVT", SqlDbType.NVarChar, 50);
            p2.Value = txtDVT.Text;
            sqlpara[2] = p2;

            SqlParameter p3 = new SqlParameter("@Tacdung", SqlDbType.NVarChar, 1500);
            p3.Value = txtTacdung.Text;
            sqlpara[3] = p3;

            SqlParameter p4 = new SqlParameter("@Lieudung", SqlDbType.NVarChar, 1500);
            p4.Value = txtLieudung.Text;
            sqlpara[4] = p4;            

            SqlParameter p5 = new SqlParameter("@Luuy", SqlDbType.NVarChar, 500);
            p5.Value = txtLuuy.Text;
            sqlpara[5] = p5;
            return sqlpara;
        }
        private SqlParameter TKBN_Parameter()
        {
            SqlParameter pra = new SqlParameter("@Tim", SqlDbType.NVarChar, 35);
            pra.Value = txtSearch.Text;
            return pra;
        }
        #endregion

        private void btnTim_Click(object sender, EventArgs e)
        {
            csData = new clsData();
            DataSet ds = new DataSet();
            ds = csData.Search_table("Tim_Thuoc", TKBN_Parameter());
            DataTable dt = new DataTable();
            dgvThuoc.DataSource = ds;
            dgvThuoc.DataMember = ds.Tables[0].TableName.ToString();
        }

        
    }
}
