using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace ReportDesktop
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            try
            {
                string content = HttpWebHelper.Get(login.urlBase);
                textBox1.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
    }
}
