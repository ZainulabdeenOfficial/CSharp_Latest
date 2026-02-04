using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace projectpractice
{
    internal class FileHandling
    {
        // try and catch complesary in file handling

        string path = "D:\\.net fullstack course\\C# latest\\zain.txt";
        internal void createfile()
        {
            try
            {

                if (File.Exists(path))
                {

                    Console.WriteLine("file already exists");
                }
                else
                {
                    File.Create(path);


                }
            } catch(Exception e) {
            Console.WriteLine(e.Message.ToString());
            }
        }

        internal void AddFileContent()
        {
            try
            {
                Console.WriteLine("Enter content to add to file:");
                string content = Console.ReadLine();
                File.WriteAllText(path, content);
                Console.WriteLine("Content added to file successfully.");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message.ToString());
            }
            }

        internal void appendfiletext()
        {
            try
            {
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine("Enter content to append to file:");
                string content = Console.ReadLine();
                File.AppendAllText(path, content);
                Console.WriteLine("Content appended to file successfully.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            }

        internal void ReadFile()
        {
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            }

        internal void filedelete()
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
