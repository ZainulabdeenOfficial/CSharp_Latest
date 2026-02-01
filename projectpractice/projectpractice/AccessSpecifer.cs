using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    // used public class keyword to access class for project practice 2 project 
    public class AccessSpecifer
    {
        internal void fun1()
        {
            Console.WriteLine("internal access specifier");
        }

        private void fun2() { Console.WriteLine("private fun 2"); }

        protected void fun3() { Console.WriteLine("protected fun 3"); }

        protected internal void fun4() { Console.WriteLine(" ptotected Internal fun 4"); }

        public void fun5() { Console.WriteLine("public fun 5"); }
    }
}
