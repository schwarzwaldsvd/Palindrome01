using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome01
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);
            var sum = 0;
            var temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                Console.WriteLine("Get the remainder by dividing the number with 10");
                var remainder = number % 10;
                Console.WriteLine($"Remainder: {remainder}");

                //multiply the sum with 10 and then add the remainder
                Console.WriteLine("Multiply the sum with 10 and then add the remainder");
                sum = (sum * 10) + remainder;
                Console.WriteLine($"Sum: {sum}");

                //Get the quotient by dividing the number with 10 
                Console.WriteLine("Get the quotient by dividing the number with 10");
                number /= 10;
                Console.WriteLine($"Number: {number}");
            }

            Console.WriteLine(temp == sum ? $"Number {temp} is Palindrome." : $"Number {temp} is not Palindrome");
            Console.ReadKey();
        }
    }
}
