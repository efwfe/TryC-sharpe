using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用_修改属性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "content";
            // button1.Height = 100;
            button1.Enabled = false;
            textBox1.Text = "zhang";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
