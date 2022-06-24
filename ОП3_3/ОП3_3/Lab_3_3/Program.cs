using System;
using System.Collections.Generic;
using System.Linq;


namespace Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                1, -2, 3, 5, 8, -9, 10
            };
            var firstPositiveNumber = numbers.First(number => number > 0);
            var lastNegativeNumber = numbers.Last(number => number < 0);

            Console.WriteLine("First positive number: " + firstPositiveNumber);
            Console.WriteLine("Last negative number: " + lastNegativeNumber);
        }
    }
}