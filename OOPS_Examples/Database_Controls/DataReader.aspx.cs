using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_Controls
{
    public partial class DataReader : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            // Create a command object  
            SqlCommand cmd = new SqlCommand("select * from dbo.Users", conn);
            conn.Open();

            // Call ExecuteReader to return a DataReader  
            SqlDataReader reader = cmd.ExecuteReader();
            Response.Write(" =========== <b> Employee Details </b> ============" + "</br> </br>");

            while (reader.Read())
            {
                Response.Write("<b> Employee Id : </b> ");
                Response.Write(reader["Id"].ToString() + "</br> ");
                Response.Write("<b> Name : </b>");
                Response.Write(reader["Name"].ToString() + "</br> ");
                Response.Write("<b> Address : </b>");
                Response.Write(reader["Address"].ToString() + "</br> ");
                Response.Write("<b> Phone : </b>");
                Response.Write(reader["Phone"].ToString() + "</br> </br>");
            }

            //Release resources  
            reader.Close();
            conn.Close();
        }
    }
}