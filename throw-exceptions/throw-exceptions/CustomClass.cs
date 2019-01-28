using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClass
{
    class MyClass
    {
        static Exception myEx = new Exception("permissin deny");
        public static void CheckString(string mystring)
        {
            if (mystring== "")
            {
                throw myEx;
            }
           
        }
    }
}
