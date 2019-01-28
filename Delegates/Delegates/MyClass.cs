using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 委托

namespace MyNameSpace
{
    class MyClass
    {
        delegate void Mydelegate(string msg);
        public void showThoesMsg(string msg)
        {
            Mydelegate md = new Mydelegate(ShowMessage);
            md += ShowAnotherMessage;
            System.Windows.Forms.MessageBox.Show(msg);
            md("zhang");
        }
        void ShowMessage(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);

        }
        void ShowAnotherMessage(string mg)
        {
            System.Windows.Forms.MessageBox.Show(mg);
        }
    }
}
