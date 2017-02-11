using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class exef1
    {
        static void Main()
        {
            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            double[] sales = new double[12];

            double avg = 0.0;
            double total = 0.0;
            for (int i = 0; i <= sales.Length - 1; i++)
            {
                Console.Write("Enter a sales for {0} : ", months[i]);
                sales[i] = Convert.ToInt32(Console.ReadLine());
                total += sales[i];
            }

            avg = total / 12;
            double max = sales[0]; int maxindex = 0, minindex = 0;
            double min = sales[0];
            for (int i = sales.Length - 1; i >= 0; i--)
            {
                if (max > sales[i])
                {
                    min = sales[i];
                    minindex = i;
                }
                else
                {
                    max = sales[i];
                    maxindex = i;
                }
            }
           


            Console.WriteLine("Maximum sales occured in {0}", months[maxindex]);
            Console.WriteLine("Minumum sales occured in {0}", months[minindex]);
            Console.WriteLine("Average monthly sales of the year {0:0.000}", avg);
        }
    }
}
