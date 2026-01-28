using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class Studentclass
    {
        private int rollno;
        internal int fee;

        internal void accept(int rollno, int fee)
        {
            this.rollno = rollno;
            this.fee = fee;
        }
        internal void display()
        {
            Console.WriteLine("Roll No is {0} and Fee is {1}", rollno, fee);
        }
    }
}
