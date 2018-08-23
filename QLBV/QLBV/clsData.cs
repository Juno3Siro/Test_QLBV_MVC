using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Data;
using System.Data.SqlClient;

namespace _38CNT1_QLSV
{
    class clsData
    {
        clsConnection csConn = new clsConnection();
        SqlConnection ketnoi; 
        public DataSet Select_table(string store_name)
        {
            DataSet ds = new DataSet();
            try
            {
                ketnoi = csConn.KhoiTao();// Gọi phương thức khởi tạo của Class
                ketnoi.Open();

                SqlCommand objComm = new SqlCommand();
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = store_name;
                objComm.Connection = ketnoi;

                SqlDataAdapter objAdap = new SqlDataAdapter(objComm);                
                objAdap.Fill(ds);
                ketnoi.Close();
            }
            finally { ketnoi.Close(); }
            return ds;
        }
        public DataSet Select_table(string store_name, SqlParameter pr)
        {
            DataSet ds = new DataSet();
            try
            {
                ketnoi = csConn.KhoiTao();// Gọi phương thức khởi tạo của Class
                ketnoi.Open();

                SqlCommand objComm = new SqlCommand();
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = store_name;
                objComm.Parameters.AddWithValue(pr.ParameterName, pr.Value);
                objComm.Connection = ketnoi;

                SqlDataAdapter objAdap = new SqlDataAdapter(objComm);
                objAdap.Fill(ds);
                ketnoi.Close();
            }
            finally { ketnoi.Close(); }
            return ds;
        }

        public bool Insert_table(string store_name, SqlParameter[] sql)
        {
            bool succes = true;
            try
            {
                //ketnoi = new SqlConnection(diachi);
                ketnoi = csConn.KhoiTao();
                ketnoi.Open();
                //Khai báo đối tượng sqlCommand
                SqlCommand objComm = new SqlCommand();
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = store_name;

                foreach (SqlParameter pr in sql)
                {
                    objComm.Parameters.AddWithValue(pr.ParameterName, pr.Value);
                }
                objComm.Connection = ketnoi;
                objComm.ExecuteNonQuery();
            }
            catch
            {
                succes = false;
            }
            
            finally
            {                
                ketnoi.Close();                
            }
            return succes;
        }

        public bool Delete_table(string store_name, SqlParameter sql)
        {
            bool sucess = true;
            try
            {
                //ketnoi = new SqlConnection(diachi);
                ketnoi = csConn.KhoiTao();
                ketnoi.Open();
                //Khai báo đối tượng sqlCommand
                SqlCommand objComm = new SqlCommand();
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = store_name;
                objComm.Parameters.AddWithValue(sql.ParameterName, sql.Value);
                objComm.Connection = ketnoi;
                objComm.ExecuteNonQuery();
            }
            catch {
                sucess = false;
            }
            finally
            {
                ketnoi.Close();                
            }
            return sucess;
        }
        public DataSet Search_table(string store_name, SqlParameter sql)
        {
            DataSet ds = new DataSet();
            try
            {
                ketnoi = csConn.KhoiTao();// Gọi phương thức khởi tạo của Class
                ketnoi.Open();

                SqlCommand objComm = new SqlCommand();
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = store_name;
                objComm.Parameters.AddWithValue(sql.ParameterName, sql.Value);
                objComm.Connection = ketnoi;

                SqlDataAdapter objAdap = new SqlDataAdapter(objComm);
                objAdap.Fill(ds);
                ketnoi.Close();
            }
            finally { ketnoi.Close(); }
            return ds;
        }

    }
}
