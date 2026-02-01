using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal abstract class AbstractClassExample
    {
        internal float areas;
        internal int param1, param2;

       
        internal abstract void ractangle();

        internal abstract void traiangle();

        internal void Accept(int param1,int param2)
        {
           this.param1 = param1;
           this.param2 = param2;
        }

        internal void Display()
        {
            Console.WriteLine("Area is: " + areas);
        }
    }
}
