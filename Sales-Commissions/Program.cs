using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int salesAmount;
            double salaryAmount;
            int[] counters = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            do
            {
                bool isNum;
                do
                {
                    Console.Write("Enter sales amount (negative to quit): ");
                    isNum = int.TryParse(Console.ReadLine(), out salesAmount);
                    if (isNum == false) { Console.WriteLine("Please enter a valid integer amount with no commas."); }
                } while (isNum == false);

                salaryAmount = (0.09 * salesAmount) + 200;

                if (salaryAmount <= 299 && salaryAmount > 0)
                {
                    counters[0] += 1;
                } else if (salaryAmount > 299 && salaryAmount <= 399)
                {
                    counters[1] += 1;
                } else if (salaryAmount > 399 && salaryAmount <= 499)
                {
                    counters[2] += 1;
                } else if (salaryAmount > 499 && salaryAmount <= 599)
                {
                    counters[3] += 1;
                } else if (salaryAmount > 599 && salaryAmount <= 699)
                {
                    counters[4] += 1;
                } else if (salaryAmount > 699 && salaryAmount <= 799)
                {
                    counters[5] += 1;
                } else if (salaryAmount > 799 && salaryAmount <= 899)
                {
                    counters[6] += 1;
                } else if (salaryAmount > 899 && salaryAmount <= 999)
                {
                    counters[7] += 1;
                } else if (salaryAmount > 1000)
                {
                    counters[8] += 1;
                }

            } while (salesAmount > 0);

            printTable(counters);

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        static void printTable(int[] counters)
        {
            int minRange = 200, maxRange = 299;
            Console.WriteLine("Range                   Number");
            for (int i = 0; i < counters.Length; i++)
            {
                if (i == 8)
                {
                    Console.WriteLine("$1000 or over             " + counters[i]);
                    break;
                }
                Console.WriteLine("$" + minRange + "-" + "$" + maxRange + "                 " + counters[i]);
                minRange += 100;
                maxRange += 100;
            }
        }
    }
}
