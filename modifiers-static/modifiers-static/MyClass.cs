using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClass
{
    class MyClass
    {
        enum Names:byte
        {
            zhang = 1,
            adam = 2,
            joe,
        }
        string Name;
        public MyClass(string name)
        {
            Name = name;
        }
        public string name()
        {
            return Name;
        }

        Names myName = Names.zhang;
        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public static void ShowMessage(int message)
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }

    }
}
