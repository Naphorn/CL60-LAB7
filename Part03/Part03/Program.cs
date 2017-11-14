using System;
using System.Linq;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November",
                                "December"};

            var sortDescending = from var1 in array1
                                orderby var1 descending
                                select var1;

            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);

            // wait
            Console.ReadLine();
        }
    }
}