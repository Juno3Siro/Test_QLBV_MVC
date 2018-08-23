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
    public partial class frmBenhnhan : Form
    {
        int trangthai = 0;
        clsData csData;

        public frmBenhnhan()
        {
            InitializeComponent();
        }

        private void frmBenhnhan_Load(object sender, EventArgs e)
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
            bool sucess = true;
            csData = new clsData();
            if (trangthai == 1)
                sucess = csData.Insert_table("TTBN_Insert", TTBN_Parameter());
            else
                sucess = csData.Insert_table("TTBN_Update", TTBN_Parameter());
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

        private void mnuHuy_Click(object sender, EventArgs e)
        {
            trangthai = 0;
            Set_value();
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            bool sucess = true;
            SqlParameter p1 = new SqlParameter("@MaBN", SqlDbType.VarChar, 15);
            p1.Value = dgvShowBN.CurrentRow.Cells["MaBN"].Value.ToString();

            csData = new clsData();
            sucess = csData.Delete_table("TTBN_Delete", p1);
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

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Update Database

        private void Hienthi()
        {
            csData = new clsData();

            DataSet ds = new DataSet();
            ds = csData.Select_table("TTBN_SelectAll");

            dgvShowBN.DataSource = ds;
            dgvShowBN.DataMember = ds.Tables[0].TableName.ToString();
        }

        private SqlParameter[] TTBN_Parameter()
        {
            SqlParameter[] sqlpara = new SqlParameter[7];
            SqlParameter p1 = new SqlParameter("@MaBN", SqlDbType.VarChar, 15);
            p1.Value = txtMaBN.Text;
            sqlpara[0] = p1;

            SqlParameter p2 = new SqlParameter("@Hoten", SqlDbType.NVarChar, 35);
            p2.Value = txtHoten.Text;
            sqlpara[1] = p2;

            SqlParameter p3 = new SqlParameter("@Ngaysinh", SqlDbType.SmallDateTime);
            p3.Value = dtpNS.Value;
            sqlpara[2] = p3;

            SqlParameter p4 = new SqlParameter("@Diachi", SqlDbType.NVarChar, 350);
            p4.Value = txtDiachi.Text;
            sqlpara[3] = p4;

            SqlParameter p5 = new SqlParameter("@Gioitinh", SqlDbType.Bit);
            if (rdoNam.Checked == true)
                p5.Value = true;
            else
                p5.Value = false;
            sqlpara[4] = p5;

            SqlParameter p6 = new SqlParameter("@SDT", SqlDbType.VarChar, 15);
            p6.Value = txtSDT.Text;
            sqlpara[5] = p6;


            SqlParameter p7 = new SqlParameter("@Ghichu", SqlDbType.NVarChar, 1000);
            p7.Value = txtDiachi.Text;
            sqlpara[6] = p7;

            return sqlpara;
        }
        private SqlParameter TKBN_Parameter()
        {
            SqlParameter pra = new SqlParameter("@Tim", SqlDbType.NVarChar, 35);
            pra.Value = txtTim.Text;
            return pra;
        }

        private void Nut_bam()
        {
            if (trangthai == 0)
            {
                txtMaBN.Enabled = false;
                txtHoten.Enabled = false;
                txtDiachi.Enabled = false;
                txtSDT.Enabled = false;
                txtGhichu.Enabled = false;
                rdoNam.Enabled = false;
                rdoNu.Enabled = false;
                dtpNS.Enabled = false;
                mnuHuy.Enabled = false;
                mnuLuu.Enabled = false;

                dgvShowBN.Enabled = true;
                mnuThemmoi.Enabled = true;
                mnuSua.Enabled = true;
                mnuXoa.Enabled = true;
                mnuThoat.Enabled = true;
            }
            else
            {
                txtHoten.Enabled = true;
                txtDiachi.Enabled = true;
                txtSDT.Enabled = true;
                txtGhichu.Enabled = true;
                rdoNam.Enabled = true;
                rdoNu.Enabled = true;
                dtpNS.Enabled = true;
                mnuHuy.Enabled = true;
                mnuLuu.Enabled = true;

                dgvShowBN.Enabled = false;
                mnuThemmoi.Enabled = false;
                mnuSua.Enabled = false;
                mnuXoa.Enabled = false;
                mnuThoat.Enabled = false;
                if (trangthai == 1)
                    txtMaBN.Enabled = true;
                else
                    txtMaBN.Enabled = false;
            }
        }

        private void Set_value()
        {
            if (trangthai == 2)
            {
                Nut_bam();
                txtMaBN.Text = dgvShowBN.CurrentRow.Cells["MaBN"].Value.ToString();
                txtHoten.Text = dgvShowBN.CurrentRow.Cells["Hoten"].Value.ToString();
                dtpNS.Value = Convert.ToDateTime(dgvShowBN.CurrentRow.Cells["Ngaysinh"].Value.ToString());
                txtDiachi.Text = dgvShowBN.CurrentRow.Cells["Diachi"].Value.ToString();
                if (Convert.ToBoolean(dgvShowBN.CurrentRow.Cells["Gioitinh"].Value.ToString()) == true)
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                txtSDT.Text = dgvShowBN.CurrentRow.Cells["SDT"].Value.ToString();
                txtGhichu.Text = dgvShowBN.CurrentRow.Cells["Ghichu"].Value.ToString();
            }
            else
            {
                Nut_bam();
                txtDiachi.Text = "";
                txtMaBN.Text = "";
                txtHoten.Text = "";
                txtGhichu.Text = "";
                dtpNS.Value = DateTime.Now.Date;
                rdoNam.Checked = true;
            }
        }
        #endregion

        private void btnTim_Click(object sender, EventArgs e)
        {
            csData = new clsData();
            DataSet ds = new DataSet();
            ds = csData.Search_table("Tim_BN", TKBN_Parameter());
            DataTable dt = new DataTable();
            dgvShowBN.DataSource = ds;
            dgvShowBN.DataMember = ds.Tables[0].TableName.ToString();
        }
    }
}
