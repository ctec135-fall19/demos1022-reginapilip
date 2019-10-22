using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// aggregation and composition
namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            // an object that exists independent of MyClass
            string s = "string from main";

            // instantiates an object from MyClass and passes in the 
            // newly created, independent object from Main
            MyClass mc = new MyClass(s);
            mc.PrintState();
        }
    }
}
