using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace repoServer
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(Handler);
        }

        protected override void OnStop()
        {
        }
        // 定时执行的代码段
        private void Handler()
        {
            while (true)
            {
                try
                {

                    var path = AppDomain.CurrentDomain.BaseDirectory + "service.log";
                    var context = "report Server:" + DateTime.Now + "\n";
                    WriteLogs(path, context);
                   

                }
                catch(Exception e)
                {
                    throw;
                }

            }
        }

        // 执行程序
        public void WriteLogs(string path,string context)
        {
            var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(context);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
