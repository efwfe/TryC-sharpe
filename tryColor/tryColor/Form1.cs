using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                button1.BackColor = cd.Color;

        }
    }
}
