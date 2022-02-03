using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = txtCreate.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddSeconds(2);
            Label1.Text = "Cookie Created";
            txtCreate.Text = "";
        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                txtRetrieve.Text = "No cookie found";
            }
            else
            {
                txtRetrieve.Text = Request.Cookies["name"].Value;
            }
        }
    }
}