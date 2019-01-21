using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string[] myArray = new string[4];
            //List<string> Names = new List<string>();
            //Names.Add("Adam");
            //Names.Add("Joe");
            List<int> intArray = new List<int>();
            intArray.Add(3);
            MessageBox.Show(intArray[0].ToString());

        }
    }
}
