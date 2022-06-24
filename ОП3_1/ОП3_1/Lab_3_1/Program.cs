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
                1, -2, 3, 7, 8, 9, 9
            };

            Console.WriteLine("Чи всi  елементи унiкальнi: " + IsUniqueNumbers(numbers));
            
        }
        private static bool IsUniqueNumbers(List<int> numbers)
        {
            return numbers.Count == numbers.Distinct().Count();
        }
    }
}