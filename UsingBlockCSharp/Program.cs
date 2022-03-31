using System;
using System.IO;


namespace UsingBlockCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path = @"c:\temp\file1.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    Console.ReadKey();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}
