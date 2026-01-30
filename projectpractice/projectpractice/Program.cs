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

            // Console.WriteLine(StaticMethod.name);
            // StaticMethod.fun();
            // InstanceExample instanceExample = new InstanceExample();
            //Console.WriteLine(instanceExample.age);
            // instanceExample.fun1();

            // Studentclass[]  obj = new Studentclass[5];
            // for (int i = 0; i< obj.Length;i++)
            // {
            //     obj[i] = new Studentclass();
            //     Console.WriteLine("Enter Rollno:");
            //     int rollno = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter Fee:");
            //     int fee = Convert.ToInt32(Console.ReadLine());
            //     obj[i].accept(rollno, fee);

            // }
            // int max = 0;
            // int maxstudentfee = 0;
            // for (int i = 0; i < obj.Length; i++)
            // {
            //     if (max < obj[i].fee)
            //     {
            //         max = obj[i].fee;
            //         maxstudentfee = i;
            //     }

            // }

            // Console.WriteLine("Student with max fee:{0}",max);

            // obj[maxstudentfee].display();

            // by deafult for static and deafult constructor is present
            ConstructorClass constructorClass = new ConstructorClass();
            // parameterized  constructor call
            ConstructorClass constructorClass1 = new ConstructorClass("Paramterizzed Constructor");

            // Copy Constructor call
            ConstructorClass constructorClass2 = new ConstructorClass(22);
            ConstructorClass constructorClass3 = new ConstructorClass(constructorClass2);

            // Gettetr and Setter method call

            // Getter always and setter optional 

            GetterSetter getterSetter = new GetterSetter();
            getterSetter.Id = 101;

            Console.WriteLine("ID:" + getterSetter.Id);

            // override method call

            OverloadingExample obj = new OverloadingExample();
            obj.add(10, 20);
            obj.add(10, 20, 30);


        }
    }
}
