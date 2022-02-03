using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormControls
{
    public partial class FormControls : System.Web.UI.Page
    {
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Label : " +  TextBox1.Text;
            Literal1.Text = "Literal : " +  TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs("D:/" + FileUpload1.FileName);
            Label2.Text = "File" + " " + FileUpload1.FileName + " " + "is uploaded successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PlaceHolder1.Controls.Add(TextBox1);        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                Label3.Text = "Gender is :" + rdbFemale.Text;
            }
            else if(rdbMale.Checked)
            {
                Label3.Text = "Gender is :" + rdbMale.Text;
            }
            else
            {
                Label3.Text = "Please select Gender.";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}