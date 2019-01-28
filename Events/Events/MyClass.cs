using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 事件 

namespace MyNameSpace
{
    class MyClass
    {
        public event EventHandler OnPropertyChanged; //属性修改事件
        string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
      


    }
}
