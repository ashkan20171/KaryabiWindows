using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KaryabiWindows
{
    class Function
    {
        public static DataTable DoQuery(string Query)
        {
            
            SqlConnection con = new SqlConnection();
          //  con.ConnectionString = "data source=BEHNAM;initial catalog=KaryabiDB;user id=admin;password=adminadmin;MultipleActiveResultSets=True;App=EntityFramework";
            con.ConnectionString = KaryabiWindows.Properties.Settings.Default.KaryabiDBConnectionString;
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void DoDml(string Query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KaryabiWindows.Properties.Settings.Default.KaryabiDBConnectionString;
            SqlCommand cmd = new SqlCommand(Query,con);
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
