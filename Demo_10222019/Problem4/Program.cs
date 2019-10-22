using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array of base class type w/ member of each class & method
            /* BULLET POINT ONE */
            // an array of the base class type is created and initialized with 
            // a member of each class in the hierarchy

            // first, create a class hierarchy and define inheritance
            Parent[] myArray = new Parent[3];
            // initialization
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new Grandchild();

            /* BULLET POINT TWO */
            // show that a method belonging to the base class is called 
            // from the child instance

            // create ParentMethod() in Parent and iterate through array
            // calling this method to demo that all child classes have
            // access to it

            // test ParentMethod() using a foreach loop
            foreach(Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.ParentMethod();
            }
            Console.WriteLine();
            #endregion


            #region demo overriding base class method by child
            /* BULLET POINT THREE */
            // demo overriding a base class method by a child

            // create a new method in parent that is virtual and use override
            // to override that method in child class

            // test using foreach loop
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.SomeMethod();
            }
            Console.WriteLine();
            #endregion

            #region demo a child method calling the parent's method
            /* BULLET POINT FOUR */
            // create a virtual method in parent
            // override in child and call the parent as part of the implementation
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.Method2();
            }
            Console.WriteLine();
            #endregion

            #region demo as/is keywords
            Console.WriteLine("AS Keyword");
            /* BULLET POINT FIVE */
            // repeat calls to SomeMethod
            // as keyword
            foreach (object element in myArray)
            {
                // elements are obj type
                // casting as Parent in order to call method
                Parent p = element as Parent;
                // or use this instead of above code
                // aka explicit casting
                // Parent p = (Parent)element;
                Console.Write("{0}: ", p.GetType());
                p.SomeMethod();
            }

            Console.WriteLine();

            /* BULLET POINT SIX */
            // demo use of is keyword
            Console.WriteLine("IS Keyword");
            foreach(Parent element in myArray)
            {
                if (element is Grandchild) Console.WriteLine("Grandchild");
                else if (element is Child) Console.WriteLine("Child");
                else if (element is Parent) Console.WriteLine("Parent");
            }
            Console.WriteLine();
            #endregion


            #region switch
            /* BULLET POINT 9 */
            Console.WriteLine("SWITCH demo");
            foreach(Parent element in myArray)
            {
                switch (element)
                {
                    case Grandchild gc:
                        Console.WriteLine("Grandchild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            }
            Console.WriteLine();
            #endregion


            #region casting
            /* BULLET POINT 13/14 */
            object obj = new Parent();
            // when not casted obj only gets methods of object type
            // cast obj to parent
            // obj. vs ((Parent)obj).
            ((Parent)obj).ParentMethod();

            Parent p2= new Grandchild();
            ((Grandchild)p2).SpecializedMethod();
            #endregion
        }
    }
}
