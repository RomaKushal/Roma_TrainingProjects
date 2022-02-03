using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            hdValue.Value = "Hello World !";
        }

        protected void btnViewHiddenField_Click(object sender, EventArgs e)
        {
            Label1.Text = "The value is : ";
            Label2.Text = hdValue.Value.ToString();
        }
    }
}