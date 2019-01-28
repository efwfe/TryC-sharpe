using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomClass
{
    class MyClass
    {
        public string Name = "zhang";
        public int Age = 18;
        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        public virtual void Show(string msg)
        {
            MessageBox.Show(msg, "virtual");
        }
    }

    class MySecondClass:MyClass, IMyInterface
    {
        public string HairColor = "black";
        public void MessageBoxSpecial()
        {
            MessageBox.Show(base.Age.ToString());
        }
        public override void Show(string msg)
        {
            MessageBox.Show(msg, "override");
        }
        public static void MyVoid()
        {
            MessageBox.Show("inner interface");
        }
    }
    class MyThirdClass : MySecondClass
    {


    }
    interface IMyInterface
    {
        void MyVoid();
  
    }
}
