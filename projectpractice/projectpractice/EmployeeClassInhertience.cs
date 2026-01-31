using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class EmployeeClassInhertience : ManagerClassInhertence
    {
        internal  float bonus { get; set; }

        internal void employeemethod(float bonus)
        {
            this.bonus = bonus;
            Console.WriteLine("Bonus: " + bonus);
        }

        internal void DisplayEmployee()
        {
            DisplayManager();
            Console.WriteLine("Bonus: " + bonus);
        }
    }
}
