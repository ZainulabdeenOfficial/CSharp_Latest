using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace projectpractice
{
    internal class EventExamplecs
    {
        public delegate void eventDelegate();
        public event eventDelegate eventHandler
            {
            add
            {
                Console.WriteLine("Opreation Added");
            }
            remove
            {
                Console.WriteLine("Opreation removed");
            }
        }

    }
}
