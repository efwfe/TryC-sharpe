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

namespace webClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(new Uri("http://10.2.1.57/file/gov/20190121_8365230272.xls"), sfd.FileName);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_Downloadfinished);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadChanged);
            }

        }
        void wc_DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label1.Text = "下载完成" + e.ProgressPercentage.ToString();
        }
        void wc_Downloadfinished(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("download is finished");
        }
    }
}
