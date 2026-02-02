using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class InterfaecImplementClass : InterfaecExample, InterfaceExample2
    {
        public void fun1()
        {
            Console.WriteLine("This is fun1 method from InterfaecExample");
        }
        public void fun2()
        {
            Console.WriteLine("This is fun2 method from InterfaecExample");
        }
        public void fun3()
        {
            Console.WriteLine("This is fun3 method from InterfaceExample2");
        }
    

    }
}
