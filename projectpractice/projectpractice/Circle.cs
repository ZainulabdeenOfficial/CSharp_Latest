using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class Circle
    {
        internal int param1;
      internal  float area;

        internal void circle(int param1)
        {
            this.param1 = param1;
        }
        internal void CalculateArea()
        {
            area = 3.14f * param1 * param1;
            
        }

        internal void DisplayArea()
        {
            
            Console.WriteLine("Area of Circle: " + area);
        }

    }
}
