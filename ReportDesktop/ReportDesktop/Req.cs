using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace ReportDesktop
{


        public class HttpWebHelper
    {
       


        public static string Get(string url, Dictionary<string, string> Headers = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            //加入头信息
            if (Headers != null)
            {
                foreach (KeyValuePair<string, string> item in Headers)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }
      
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Timeout = 300000;
            request.Headers.Set("Pragma", "no-cache");
        
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamReceive = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
            string strResult = streamReader.ReadToEnd();
     

            streamReader.Close();
            streamReceive.Close();
            request.Abort();
            response.Close();

            return strResult;
        }


        public static string Post(string url, string data, Dictionary<string, string> Headers = null)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            //加入头信息
            if (Headers != null)
            {
                foreach (KeyValuePair<string, string> item in Headers)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //Json写入时机
                string json = "{\"user\":\"test\"," +
                              "\"password\":\"bla\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }



            //写数据
            request.Method = "POST";
            request.ContentLength = bytes.Length;
            request.ContentType = "application/json";
            Stream reqstream = request.GetRequestStream();
            reqstream.Write(bytes, 0, bytes.Length);
     

            //读数据
            request.Timeout = 300000;
            request.Headers.Set("Pragma", "no-cache");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamReceive = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
            string strResult = streamReader.ReadToEnd();

            //关闭流
            reqstream.Close();
            streamReader.Close();
            streamReceive.Close();
            request.Abort();
            response.Close();

            return strResult;
        }


    }



}
