using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser wb = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate("http://www.baidu.com");
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wd_finished);
        }
        void wd_finished(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb.Document.GetElementById("kw").SetAttribute("innerHTML","aa");
         
        }
    }
}
