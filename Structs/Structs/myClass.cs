using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClass
{
    struct Client:IClient
    {
       
        public Client(string name)
        {
            Name = name;
            Age = 0;
        }
        string Name;
        public int Age;
        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }

    }

    interface IClient
    {

        public string Name;

    }
}