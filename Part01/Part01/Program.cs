using System;
namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            data[2] = 2;
            data[6] = 6;
            Console.WriteLine(data[2]);
            Console.WriteLine(data[6]);
            Console.ReadLine();
        }
    }
}