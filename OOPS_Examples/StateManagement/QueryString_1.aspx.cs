using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryString_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "")
            {
                Response.Redirect("QueryString_2.aspx?pageval=" + txtValue.Text);
            }
            else
            {
                Response.Redirect("QueryString_2.aspx?pageval=" + "No Data Found.");
            }
            
        }
    }
}