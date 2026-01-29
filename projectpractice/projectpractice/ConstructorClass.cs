using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class ConstructorClass
    {
        static ConstructorClass()
        {
            Console.WriteLine("Static Constructor called");
        }

      internal  ConstructorClass()
        {
                       Console.WriteLine("Instance Constructor called");

        }

       internal ConstructorClass(string name)
        {
            Console.WriteLine("Instance Constructor with parameter called: " + name);
        }

        // copy constructor
        int age;
        internal ConstructorClass(int age)
        {
            this.age = age;
            Console.WriteLine("copy Constructor " + age);
        }

        internal ConstructorClass(ConstructorClass C)
        {
            this.age = C.age;
            Console.WriteLine("copy Constructor " + age);
        }



    }
}
