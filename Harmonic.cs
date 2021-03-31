using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Harmonic
    {
        public static void ReadHarmonicNumber()
        {
            Console.WriteLine("enter the nth harmonic number");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            double result = Harmonicnum(nthNumber);
            Console.WriteLine("sum of all harmonic list" + result);

        }
        private static double Harmonicnum(int lastNumber)
        {
            double sum = 0;
            for(int i=1;i<=lastNumber;i++)
            {
                sum = sum + (1 / i);
            }
            return sum;
        }
    }
}
