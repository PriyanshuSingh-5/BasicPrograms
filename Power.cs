using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Power
    {
        public static void main()
        {
            int number = Convert.ToInt32(number);
            int num = 1;
            int i = 1;
            int LimitPowerTwo = 31;

            if (number > LimitPowerTwo)
            {
                Console.WriteLine("enter { number}  2^ exceeds the value");

            }
            else
                for(i = 1;i<=number;i++)
                {
                    num = (num * 2);
                }
            Console.WriteLine("num");
            }
        }
    }
}

