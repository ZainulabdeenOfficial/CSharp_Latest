using System;

namespace projectpractice
{
    class Program
    {
        // 'out' is used to pass a variable to a method
        // so the method can assign a value to it
        // and send that value back to the caller


        void userinput(out int a ,out  int b)
        {
            Console.WriteLine("Enter First number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  second  number:");
             b= Convert.ToInt32(Console.ReadLine());
        }
        void sum(int a,int b)
        {
            
            Console.WriteLine(a + b);
        }

        void sub(int a , int b)
        {
           
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            
            //Program obj = new Program();
            //int num1, num2;
            //obj.userinput(out num1,out num2);
            //obj.sum(num1, num2);
            //obj.sub(num1, num2);

            //Sudentinfo studentdata = new Sudentinfo();
            //studentdata.accept(Guid.NewGuid(),"zain",26);
            //studentdata.display();

            Console.WriteLine(StaticMethod.name);
            StaticMethod.fun();
            InstanceExample instanceExample = new InstanceExample();
           Console.WriteLine(instanceExample.age);
            instanceExample.fun1();


        }
    }
}
