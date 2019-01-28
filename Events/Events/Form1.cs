using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNameSpace;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.OnPropertyChanged += new EventHandler(mc_OnPropertyChanged); //事件回调
            // mc.Name = "aaa";
        }

        void mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("things changed");
        }

    }
}
