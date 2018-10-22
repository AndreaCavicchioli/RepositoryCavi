using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaviGit
{
    class Program
    {
        public static int GetMax(int []a)
        {
            int max = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int GetMin(int[] a)
        {
            int min = 999999;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int max = 0, min = 99999;
            array[0] = 22;
            array[1] = 88;
            array[2] = 2;
            array[3] = 7;
            array[4] = 9;
            array[5] = 45;
            array[6] = 77;
            array[7] = 80;
            array[8] = 30;
            array[9] = 17;

            max = GetMax(array);
            min = GetMin(array);

            Console.WriteLine("Il valore minore e': " + min);
            Console.WriteLine("Il valore maggiore e': " + max);

            Console.ReadLine();


        }
    }
}
