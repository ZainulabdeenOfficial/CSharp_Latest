using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class Sudentinfo
    {
        private Guid Id;
        private String Name;
        private int age;

      internal  void accept(Guid ID,String Name,int age)
        {
            this.Id = ID;
            this.Name = Name;
            this.age = age;
            
        }
     internal void display()
        {
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Age: " + age);
        }
    }
}
