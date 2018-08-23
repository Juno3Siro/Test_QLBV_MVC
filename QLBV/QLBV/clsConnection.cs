using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace _38CNT1_QLSV
{
    class clsConnection
    {
        private string diachi = @"Data Source=DESKTOP-5APG2T7\SQLEXPRESS;Initial Catalog=QLBV;Integrated Security=True";
    
       public SqlConnection KhoiTao()
       {
           SqlConnection ketnoi;
         return  ketnoi = new SqlConnection(diachi);        
       }

    }
}
