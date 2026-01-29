using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class GetterSetter
    {
        private int id;
        // shortcut for getter and setter not used data memebrs
        public int MyProperty { get; set; }

        public int Id { get => id; set => id = value; }
    }
}
