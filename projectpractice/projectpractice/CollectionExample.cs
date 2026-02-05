using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace projectpractice
{
    internal class CollectionExample
    {
        internal void arraylistexample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        // hash  table
        internal void hashtableexample()
        {

            Hashtable hs = new Hashtable();
            hs.Add("name", "zain");
            hs.Add("age", 22);
            hs.Add("city", "sahiwal");
            foreach (DictionaryEntry keys in hs)
            {
                Console.WriteLine("Key: {0}, Value: {1}", keys.Key, keys.Value);

            }


        }
        // shortlist call
        internal void shortlistexample()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        // stack example
        internal void stackexample()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Peek());
            while (stack.Count!=0)
            {
                Console.WriteLine(stack.Pop());
            }

        }

        //  queue example
        internal void Queuexample()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
           Console.WriteLine(queue.Peek());
           
            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}