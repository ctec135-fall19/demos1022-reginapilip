using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// "has-a" defines a relationship of a higher complexity
namespace Problem3
{
    class MyClass
    {
        // fields
        private string str;  // he selected strings bc
        private string str2; // strings are already an obj/class
                             // reference vs value type

        public MyClass(string inStr)
        {
            // here, composition is defined
            // MyClass owns str. str doesn't exist outside of MyClass
            str = "some string";

            // if this was not a string (a non-object var.)
            // then you would be instantiating an obj
            // using the new keyword


            //aggregation
            // str2 refers to object outside of MyClass
            // passing in an object outside
            str2 = inStr;
        }

        // this is a simplistic way to display aggregation and composition
        public void PrintState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }

        /*
        // example of a nested class
        // not the same as above
        // not a typical practice
        // may be used to encapsulate a utility within a class
        class MyNestedClass
        {

        }
        */
    }
}
