using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace apiGeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Do api = new Do();
        System.Timers.Timer timer = new System.Timers.Timer(5000);

        private void Form1_Load(object sender, EventArgs e)
        { 
            timer.Elapsed += SelectApi;
            timer.AutoReset = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void SelectApi(object sender, System.Timers.ElapsedEventArgs e)
        {
            //这里你去访问API，根据取回的值取更新api

            //reqWeb r = new reqWeb();
            //string url = "http://127.0.0.1:5000";
            //string content = r.request(url);
            //MessageBox.Show(content);
            
            api.IeExp();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            api.ie.Quit();   
        }

        private void 展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.ShowBalloonTip(1000, "提示信息", "提示信息哈哈哈哈", ToolTipIcon.Info);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            api.ie.Quit();
        }
    }
}
