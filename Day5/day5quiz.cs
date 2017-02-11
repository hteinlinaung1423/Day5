using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class day5quiz
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.0, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        public static int AskForIncome()
        {
            int income;
            Console.Write("Please enter your annual taxabel income : ");
            income = Convert.ToInt32(Console.ReadLine());

            return income;

        }


        public static int GetTaxBracket(int income)
        {
            int index=-1;

            
            {
                for (int i = minIncomeArray.Length - 1; i >=0 ; i--)
                {
                    if (  minIncomeArray[i] < income)
                    {
                        index = i;
                        break;
                    }
                }
            }

            return index;
        }

        public static double CalculateIncomeTax(int annual, int tax)
        {
            double taxpayable = 0;
            if (tax != -1)
            {
                int minincome = minIncomeArray[tax];
                double taxrate = taxRateArray[tax];
                int baseamount= basePayableAmountArray[tax];
                taxpayable = (annual - minincome) * taxrate + baseamount;
            }
            return taxpayable;
        }

        public static void PrintResult(int annual, double taxpayable)
        {
            Console.WriteLine("For taxable annual income of ${0:0,0.00}, the tax payable amount is ${1:0.00}", annual, taxpayable);
        }





    }
}
