using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ParseXML : Form
    {
        public ParseXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFileName = openFileDialog.FileName;
                using (DataSet ds= new DataSet())
                {
                    ds.ReadXml(xmlFileName);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
