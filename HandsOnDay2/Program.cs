using System;

namespace HandsOnDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a > 0)
            {
                Console.WriteLine("A is positive");
            }
            else
                Console.WriteLine("A is negative");
            int b = 13;
            if (b % 2 == 0)
            {
                Console.WriteLine("Num is even");
            }
            else
                Console.WriteLine("Num is odd");
        }
    }
}
