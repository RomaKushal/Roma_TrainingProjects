using System;
using System.Data;
using System.Data.SqlClient;

namespace Database_Controls
{
    public partial class GridView : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn  = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from dbo.Users",sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}