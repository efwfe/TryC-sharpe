using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 变量类型__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte myByte = 255;
            short myShort = 0;
            Int16 num = 12;
            int myInt = 0;
            Int32 myint32 = myInt;
            long mylong = 0;
            Int64 myInt54 = mylong;

        }
    }
}
