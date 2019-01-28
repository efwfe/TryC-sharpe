using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class MyClass
    {
        public static string name = "zhang";
        public static int Age = 15;
        public static void Msg(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
        public abstract void ShowMsg(string msg);
    }

    class SecondClass:MyClass
    {
        public override void ShowMsg(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
    }
}
