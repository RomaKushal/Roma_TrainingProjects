using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["Count"] = Convert.ToInt32(Application["Count"]) + 1; //Set Value to The Application Object
            Label2.Text = Application["Count"].ToString(); //Get Value from the Application Object
        }
    }
}