using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class Rectangle : TriangaleClass
    {
        internal int param3;
                internal void rectangle(int param3)
            { this.param3 = param3; }
        internal void CalculateAreaRectangle()
        {
            area = param1 * param3;

        }
        internal void DisplayAreaRectangle()
        {
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
