using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_form
{
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
