using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class ThreadExamplecs
    {
        internal void display()
        {
            for (int i = 0;i<10;i++)
            Console.WriteLine("process" + i);
            Thread.Sleep(1000);
        }

        //public static void Main()
        //{
        //   ThreadExamplecs threadExamplecs = new ThreadExamplecs();
        //    ThreadStart th = new ThreadStart(threadExamplecs.display);
        //    Thread t = new Thread(th);
        //    t.Start();
        //}
    }
}
