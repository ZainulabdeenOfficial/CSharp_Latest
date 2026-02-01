using System;
using projectpractice;

namespace practiceproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessSpecifer accessSpecifer = new AccessSpecifer();
            // proof only public access is allowed from another  project
            accessSpecifer.fun5();

        }
    }
}