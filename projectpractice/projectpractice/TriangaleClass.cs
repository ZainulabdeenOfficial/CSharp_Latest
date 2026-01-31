using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class TriangaleClass : Circle
    {
        internal int param2;
        internal void triangale(int param2)
        {
            this.param2 = param2;
        }
        internal void CalculateAreaTriangale()
        {
            area = 0.5f * param1 * param2;
        }

                                                                            
        internal void DisplayAreaTriangale()
        {
            Console.WriteLine("Area of Triangale: " + area);
        }
    }
}
