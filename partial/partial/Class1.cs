using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    public partial class MyClass
    {
        public string HairColor = "black";
        public bool Glasses = false;
        partial void Message(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
        public void ShowMsg(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
    }
}
