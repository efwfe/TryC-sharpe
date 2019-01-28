using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomClass;

namespace Inheritance_override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySecondClass msc = new MySecondClass();
            //msc.ShowMessage(msc.HairColor);
            //msc.MessageBoxSpecial();
            //msc.Show("just show something");
            msc.MyVoid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
