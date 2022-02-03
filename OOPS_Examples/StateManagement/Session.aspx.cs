using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;//Set Value to The Session
            Label2.Text = Session["Count"].ToString(); //Get Value from the Sesion
        }
    }
}