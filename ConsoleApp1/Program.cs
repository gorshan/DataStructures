using System;
using DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array2 = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //array2[5] += 1;
            Console.WriteLine(array2[2]);
        }
    }
}
