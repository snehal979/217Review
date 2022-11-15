using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvenANDodd
{
    public class CHeckNumberIS
    {
        public static void EvenOdd(int num)
        {
            if (num %2 == 0)
            {
                Console.WriteLine("{0} number is even", num);
            }
            else
            {
                Console.WriteLine("{0} number is odd", num);
            }
        }
        public static void Number(int num)
        {
            if(num > 0)
            {
                Console.WriteLine("the number is positive");
                Console.WriteLine("CHECK EVEN/ODD NUMBER -then enter 'Y'");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'Y')
                {
                    CHeckNumberIS.EvenOdd(num);
                } 

            } else if(num <0)
            {
                Console.WriteLine("{0} the num is negative", num);
            }else
            {
                Console.WriteLine("the number is zero");
            }

        }
    }
}
