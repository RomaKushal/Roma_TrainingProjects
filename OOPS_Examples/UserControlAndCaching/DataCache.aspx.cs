using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlAndCaching
{
    public partial class DataCache : System.Web.UI.Page
    {
        // if you change the data in the table within these 60 seconds,
        // it is not shown before the cache expires.
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = String.Format("Page posted at: {0}", DateTime.Now.ToLongTimeString());
        }

        
    }
}