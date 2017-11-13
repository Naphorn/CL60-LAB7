using System;
namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            data[4] = 4;
            data[9] = 9;
            Console.WriteLine(data[4]);
            Console.WriteLine(data[9]);
            Console.WriteLine(data[4] + data[9]);
            Console.ReadLine();
        }
    }
}