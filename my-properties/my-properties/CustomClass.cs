using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClass
{
    class MyClass
    {
        string myString;
        public MyClass(string name)
        {
            myString = name;
        }

        public string Name
        {
            get { return myString; }
            set
            {
                if (value == "") System.Windows.Forms.MessageBox.Show("you can not do that");
                else
                {
                    myString = value;
                }
            }

        }
    }
}
