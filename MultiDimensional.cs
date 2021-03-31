using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class MultiDimensional
    {
        public static void ReadMultiArray()
        {
            object[][] array = new object[4][];
            array[0] = new object[4];
            array[1] = new object[4];
            array[2] = new object[4];
            array[3] = new object[4];
            Console.WriteLine("enter integer array of 4 element");
            for(int i=0;i<4;i++)
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter boolean array of 4 element");
            for (int i = 0; i < 4; i++)
            {
                array[1][i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("enter String array of 4 element");
            for (int i = 0; i < 4; i++)
            {
                array[2][i] = Console.ReadLine();

            }
            Console.WriteLine("enter double array of 4 element");
            for (int i = 0; i < 4; i++)
            {
                array[3][i] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
