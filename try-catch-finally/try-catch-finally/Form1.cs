using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_catch_finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Names = new string[2];
                string s = Names[3];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error was happended:"+ex.Message);
            }
            finally
            {
                MessageBox.Show("code is done");
            }
        }
    }
}
