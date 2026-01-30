using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class OverloadingExample
    {
      internal  void add (int a ,int b)
        {
            Console.WriteLine("Sum of two integers: " + (a + b));
        }
      internal  void add(int a, int b ,int c)
        {
            Console.WriteLine("Sum of three integers: " + (a + b + c));
        }

        
    }
}
