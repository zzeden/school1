using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.Write("lol");
            Console.WriteLine("Helloo");
            Console.Write("papa");


            Console.WriteLine("plese insert number");
            string s = Console.ReadLine();
            int num = int.Parse(s);


            Console.WriteLine(s);
        }

        private static int CalcAdd(int a, int b)
        {
            return a + b;
        }

        private static void CalcAddPrint(int a, int b)
        {
            Console.Write(a + b);
        }
    }
}
