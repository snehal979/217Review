using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenANDodd
{
    public class ProblemForNumber
    {
        public static void PrintChar()
        {
            Console.WriteLine("alphabate print a-z");
            char ch;

            for (ch = 'a'; ch <='z'; ch++)
            {
                Console.WriteLine(ch);
            }
        }

        public static void MultiplicationTable(int num)
        {
            Console.WriteLine("table of multiplication");
            int i;
            
            int result;
            for(i = 1; i<=10; i++)
            {
                result = num *i;
                Console.WriteLine(result);
            }

        }
        public static void power(int basenum)
        {
            Console.WriteLine("enter the power number");
            int powernum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("power of number");
            int result = 1;
            int i;
            for(i = 1; i <= powernum; i++) 
            {
                result = result * basenum;
                
            }
            Console.WriteLine(result);
        }
        public static void Factorial(int num1)
        {
            Console.WriteLine("factor of that number");
            double fact=0;
            for(int i = 0; i<=num1; i++)
            {
                fact = fact *i;
            }
            Console.WriteLine(fact);
        }
        public static void ISpalindromeNumber(int num)
        {
            Console.WriteLine("the number is palindrome");
            int reminder;
            int digit=0;
            int temp = num;
            while (num != 0)
            {
                reminder = num % 10;
                digit = digit * 10 + reminder;   // revese method
                num = num / 10;

            }
            if(temp == digit)
            {
                Console.WriteLine("the number is palindrome");
            } else
            {
                Console.WriteLine("the number is not palindrome");
            }
        }
        public static void ASCIIValue()
        {
            Console.WriteLine("enter the alphabate");
            char c = Convert.ToChar(Console.ReadLine()); // 2
            int ascii = c; //4
            Console.Write("The ASCII value of " +
                            c + " is: " + ascii);
        }
        
    }
}
