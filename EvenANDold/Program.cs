using System;

namespace EvenANDodd
{
    class program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("enter the number for check even or odd");
            //int num = Convert.ToInt32(Console.ReadLine());

            //CHeckNumberIS.Number(num);




            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hint 1 :printa-z \n 2: print table of number \n 3:power of number \n 4:factorial of number \n 5:palindromenumber \n 6: ASCII Value");

            Console.WriteLine("check want you want");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    ProblemForNumber.PrintChar();
                    break;
                case 2:
                    ProblemForNumber.MultiplicationTable(num);
                    break;
                case 3:
                    ProblemForNumber.power(num);
                    break;
                case 4:
                    ProblemForNumber.Factorial(num);
                    break;
                case 5:
                    ProblemForNumber.ISpalindromeNumber(num);
                    break;
                case 6:
                    ProblemForNumber.ASCIIValue();
                    break;

                default:
                    Console.WriteLine("invalid ");
                    break;

            }




        }


        
    }
}