using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace projectpractice
{
    internal class ManagerClassInhertence : AdminClassInhertience
    {
        internal int salary { get; set; }
        internal void managermethod(int sallery)
        {
            this.salary = sallery;
            Console.WriteLine("Sallery: " + sallery);
        }

        internal void DisplayManager()
        {
            DisplayAdmin();
            Console.WriteLine("Salary: " + salary);
        }
    }
}
