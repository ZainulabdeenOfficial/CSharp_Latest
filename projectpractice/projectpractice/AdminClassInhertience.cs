using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace projectpractice
{
    internal class AdminClassInhertience
    {
        internal Guid id { get; set; }
        internal string name { get; set; }
        internal void adminmethod(Guid id, string name)
        {
         this.id = id;
         this.name = name;
         Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);

        }
        internal void DisplayAdmin()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
}
