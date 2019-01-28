using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mshtml;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace apiGeter
{

    class Do
    {
        
        private bool ie_read = false;
        public SHDocVw.InternetExplorer ie = new SHDocVw.InternetExplorer();

        public  void  IeExp()
        {
           

            ie.Height = 1200;
            ie.Width = 1500;
            ie.Visible = true;
            ie.DocumentComplete += Ie_DocomentComplete;
            ie.Navigate("http://www.baidu.com");
            ie.Visible = true;
            ie_read = false;
            compWait();
            HTMLDocument doc = ie.Document;
            doc.getElementById("kw").innerText = "234567";

            //ie.Quit();

        }

       
        private void Ie_DocomentComplete(object pDisp, ref object URL) //加载完成事件
        {
            ie_read = true;
        }
        private void compWait() //等待，直到加载完成
        {
            while (ie_read != true)
            {
                Application.DoEvents();
            }
        }
    }

    //class reqWeb
    //{
    //    public string request(string url)
    //    {
    //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    //        request.Method = "GET";
    //        request.ContentType = "text/html;charset=UTF-8";
    //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    //        Stream myResponseStream = response.GetResponseStream();
    //        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
    //        string retString = myStreamReader.ReadToEnd();
    //        myStreamReader.Close();
    //        myResponseStream.Close();
    //        return retString;
    //    }
    //}

}
