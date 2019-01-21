using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "zhang":
                    MessageBox.Show("zhang");
                    break;
                case "hello":
                    MessageBox.Show("yoyo");
                    break;
                default:
                    textBox1.Text = "asdad";
                    break;
            }
        }
    }
}
