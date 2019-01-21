using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用_if判断
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox1.Text = "zhang";
            if (textBox1.Text == "")
            {
                MessageBox.Show("zhang");
            }
            else if (textBox1.Text =="zh")
            {
                MessageBox.Show("zh");
            }
            else
            {
                MessageBox.Show("hehe");
            }
        }
    }
}
