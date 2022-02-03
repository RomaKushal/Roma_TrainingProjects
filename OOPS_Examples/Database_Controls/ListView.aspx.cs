using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_Controls
{
    public partial class ListView : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from dbo.Users", sqlconn);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sqlda.Fill(dt);
                ds.Tables.Add(dt);

                ListView1.DataSource = ds.Tables[0];
                ListView1.DataBind();
            }
        }
    }
}