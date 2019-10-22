using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Parent
    {
        /* BULLET POINT TWO */
        // show that a method belonging to the base class is called 
        // from the child instance 

        // create ParentMethod() in Parent and iterate through array
        // calling this method to demo that all child classes have
        // access to it
        public void ParentMethod()
        {
            Console.WriteLine("Parent method");
        }

        /* BULLET POINT THREE */
        // create a new method in parent that is virtual and use override
        // to override that method in child class
        public virtual void SomeMethod()
        {
            Console.WriteLine("Parent's Some Method");
        }

        /* BULLET POINT FOUR */
        // demo a child method calling the parent's method
        // create a virtual method in parent
        // override in child and call the parent as part of the implementation
        // demo
        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }


    }
}
