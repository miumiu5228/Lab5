using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("MyConnectString");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            

            using (conn)
                conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}