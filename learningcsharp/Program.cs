using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int  reverse = 0, remainder;
           

            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int num = n;
            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
           
            }
           
            if (num == reverse)
            {
                Console.WriteLine("number is palindrome");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("number is not palindrome");
                Console.ReadLine();
            }
            
        }
    }
}
