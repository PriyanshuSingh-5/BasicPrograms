using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Factorial
    {
     public  void ReadInput()
        {
            Console.WriteLine("Enter the number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            FactorialNumber(num);
        }
        private static void FactorialNumber(int num)
        {
            int i;
            int f = 1;
           
            for (i=1;i<=num;i++)
            {
                f = f * i;
                Console.WriteLine("The Factorial of the number is",num,f) ;
            }
        }
    }
}
