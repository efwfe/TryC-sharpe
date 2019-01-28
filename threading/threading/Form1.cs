using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        string content = "";
        private void button1_Click(object sender, EventArgs e)
        {
            object[] data = { "zhan", 500 };
            t = new Thread(freeze);
            t.Start(data);
            while (t.IsAlive) ;
            richTextBox1.Text = content;
     
        }
        void freeze(object data)
        {
            object[] o =  data as object[];
            for (int i = 1; i < Convert.ToInt32(o[1]); i++)
            {

                content += o [0]+ i.ToString()+"\n";
            }
            
            
        }
        void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            t.Abort();

        }
    }
}
