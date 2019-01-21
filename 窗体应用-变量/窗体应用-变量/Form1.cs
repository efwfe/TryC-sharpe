using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用_变量
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string name = "zhang";
            // int number = 123;
            // bool flag = true;

            // MessageBox.Show(name,"name is");
            // MessageBox.Show(number.ToString());
            // MessageBox.Show(flag.ToString());

            // object myObj = true;
            //  object myObj = "zhang";
            object myObj = 234;
            MessageBox.Show(myObj.ToString());
        }
    }
}
