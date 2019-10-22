using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Grandchild : Child
    {
        /* BULLET POINT THREE */
        // create a new method in parent that is virtual and use override
        // to override that method in child class
        public override void SomeMethod()
        {
            Console.WriteLine("Grandchild's Some Method");
        }

        /* BULLET POINT FOUR */
        // demo a child method calling the parent's method
        // create a virtual method in parent
        // override in child and call the parent as part of the implementation
        // demo
        public override void Method2()
        {
            // base calls immediate parent (in this case, child)
            base.Method2();
            Console.WriteLine("Grandchild.Method2");
        }

        /* BULLET POINT */
        public void SpecializedMethod()
        {
            Console.WriteLine("Specialized Method");
        }
    }
}
