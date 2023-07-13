using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine($"The number {num} is Zero");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is Positive Number");
            }
            else
                Console.WriteLine($"The number {num} is Negative Number");
           var result = num % 2 == 0 ? $"The number {num} is Even" : $"The number {num} is Odd";
           Console.WriteLine(result);
        }
    }
}
