using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ReportDesktop
{
    
    public partial class login : Form
    {
        public string token = null;
        public const string urlBase = "http://127.0.0.1:5000";
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string passwd = passWord.Text;
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("username",name);
            data.Add("passwod",passwd);
    
            // 登陆验证
            this.Hide();
            index f = new index();
            f.FormClosed += (s,args) => this.Close();
            try
            {
                f.Show();
            }
            catch(Exception)
            {
                Close();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "import notice", "somtasdads,asdadasdas,asdasdasdasd,asdasdasd,asdasd", ToolTipIcon.Info);
            }
        }
    }
}
