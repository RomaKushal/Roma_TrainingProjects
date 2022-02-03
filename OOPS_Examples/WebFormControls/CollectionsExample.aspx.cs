using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormControls
{
    public partial class CollectionsExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Non-Generic

        // In non-generic collections, each element can represent
        // a value of a different type.
        // The collection size is not fixed. Items from the collection
        // can be added or removed at runtime.

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            string str = "Roma Patel";
            int x = 22;
            DateTime d = DateTime.Parse("31-dec-2021");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Response.Write(o);
                Response.Write("<br>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Response.Write(d.Key + " " + d.Value);
                Response.Write("<br>");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry d in sl)
            {
                Response.Write(d.Key + " " + d.Value);
                Response.Write("<br>");
            }

        }

        #endregion

        #region Generic Collections

        //Generic Collections work on the specific type that is specified in the program whereas non-generic collections work on the object type. 
        //Specific type
        //Array Size is not fixed
        //Elements can be added / removed at runtime.

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Response.Write(i + "<br>");
            }

        }

        #endregion

        protected void Button6_Click(object sender, EventArgs e)
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Response.Write(kvp.Key + " " + kvp.Value);
                Response.Write("<br>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Response.Write(kvp.Key + " " + kvp.Value);
                Response.Write("<br>");
            }

        }
    }
}