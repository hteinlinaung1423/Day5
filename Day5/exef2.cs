using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class exef2
    {
        static void Main()
        {

            int[] num = new int[10] { 12, 90, 78, 56, 34, 45, 5, 9, 16, 49 };
            int[] sorted = new int[10];
            int min = num[0];
            for (int i = 0; i <= num.Length - 1; i++)
            {
                int c = 1;
                for (int j = i+1; j <= num.Length - 1; j++)
                {
                    
                    if (min > num[j])
                    {
                        int temp = min;
                        min = num[j];
                        num[j] = temp;
                    }
                }

                sorted[i] = min;
                min = num[c];
                c++;
            }

            foreach (int sort in sorted)
            {
                Console.Write(" " + sort);
            }
            Console.WriteLine();

        }

        
    }
}
