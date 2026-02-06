using System;
using static projectpractice.DelegateExample;

namespace projectpractice
{

    class Program
    {
        public void TestEvent()
        {
            EventExamplecs eventExamplecs = new EventExamplecs();
          eventExamplecs.eventHandler += My_eventHandler;
           eventExamplecs.eventHandler -= My_eventHandler;
        }

        private void My_eventHandler()
        {
            Console.WriteLine("Event Handled");
        }





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
            //ConstructorClass constructorClass = new ConstructorClass();
            // parameterized  constructor call
            //ConstructorClass constructorClass1 = new ConstructorClass("Paramterizzed Constructor");

            // Copy Constructor call
            //ConstructorClass constructorClass2 = new ConstructorClass(22);
            //ConstructorClass constructorClass3 = new ConstructorClass(constructorClass2);

            // Gettetr and Setter method call

            // Getter always and setter optional 

            //GetterSetter getterSetter = new GetterSetter();
            //getterSetter.Id = 101;

            //Console.WriteLine("ID:" + getterSetter.Id);

            // override method call

            //OverloadingExample obj = new OverloadingExample();
            //obj.add(10, 20);
            //obj.add(10, 20, 30);

            InhertitenceChidlClass inhertitenceChidlClass = new InhertitenceChidlClass();
            // parents menthod call through child class
            inhertitenceChidlClass.display();
            // child method call
            inhertitenceChidlClass.displaychild();

            // inhertience Example 
            EmployeeClassInhertience obj = new EmployeeClassInhertience();
           
            obj.adminmethod(Guid.NewGuid(), "Admin Name");
            obj.managermethod(500);
            obj.employeemethod(2000);
            obj.DisplayAdmin();
            obj.DisplayManager();
            obj.DisplayEmployee();

            // abstact class example call
            // refernce abstarct class always and object used chaild class

            AbstractClassExample example = new AbstractChaildlArea();
            example.Accept(10, 20);
            example.ractangle();
            example.Display();

            AbstractClassExample example1 = new AbstractChaildlArea();
            example1.Accept(10, 20);
            example.traiangle();
            example.Display();

            // Acces Specifier Example call
            AccessSpecifer accesSpecifierExample = new AccessSpecifer();

            accesSpecifierExample.fun1();
            accesSpecifierExample.fun4();
            accesSpecifierExample.fun5();


            // Interface Example call
            // interface refernce and object used implemet class

            InterfaecExample obj1 = new InterfaecImplementClass();
            obj1.fun1();

            // Override funcation call

            OverridingExample overriding = new Overridingimplemetationclass();
            overriding.calculatebill(5000);


            // Exception Handling Example 
            // throw is used call expection mannully
            // always used inside try

            // int num;
            // try
            // {
            //     int a, b, c;
            //     Console.WriteLine("Enter first number");
            //     num = Convert.ToInt32(Console.ReadLine());

            //     if (num<0)
            //     {
            //         throw new Exception("Negative number not allowed");
            //     }

            //     Console.WriteLine("Enter first number");
            //     a = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter second number");
            //     b = Convert.ToInt32(Console.ReadLine());
            //     c = a / b;
            //     Console.WriteLine("Result:" + c);

            // }

            // // try alway one but we can used it multiple catch block
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine("Error: Cannot divide by zero."+ex.Message.ToString());
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine("Error: Invalid input format."+ex.Message.ToString());
            // }

            // catch (Exception ex) { 

            // Console.WriteLine("Error:"+ex.Message.ToString());

            // }
            // // finaly always execute
            //finally
            // {
            //     Console.WriteLine("Execution completed.");
            // }


            // file handling call
            //FileHandling fileHandling = new FileHandling();
            //fileHandling.createfile();
            //fileHandling.AddFileContent();
            //fileHandling.appendfiletext();
            //fileHandling.ReadFile();

            // Collections Example Call

            //CollectionExample collectionsExample = new  CollectionExample();
            //collectionsExample.arraylistexample();
            //collectionsExample.hashtableexample();
            //collectionsExample.shortlistexample();
            //collectionsExample.stackexample();
            //collectionsExample.Queuexample();
            //collectionsExample.Queuexample();


            // Delegate Example Call
            // delegate is used when not need not create object again and again for method 
            // access method through intermadiate delagate
            DelegateExample delegateExample = new DelegateExample();
            helloDelegate he = new helloDelegate(delegateExample.hello);
            he();


            Program pro = new Program();
            pro.TestEvent();




        }
    }
}
