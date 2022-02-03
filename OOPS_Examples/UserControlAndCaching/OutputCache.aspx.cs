using System;
using System.Threading;

namespace UserControlAndCaching
{
    public partial class OutputCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("This page was generated and cache at:" +
            DateTime.Now.ToString());
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("<br><br>");
            Response.Write("<h2> Hello, " + this.txtName.Text + "</h2>");
        }
    }
}