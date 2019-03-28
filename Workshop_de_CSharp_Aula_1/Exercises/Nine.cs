using System;
namespace BasicCSharp.Exercises
{
    public class Nine : Exercise
    {
        public static void Start()
        {
            float wage;
            float sales;

            wage = ReadFloat("Enter the wage of the salesman:");

            while (wage < 0)
            {
                wage = ReadFloat("No negative numbers, please. Try again:");
            }

            sales = ReadFloat("Enter the total value of the sales he/she made this month");

            while (sales < 0)
            {
                sales = ReadFloat("No negative numbers, please. Try again:");
            }

            float extra;

            if (sales <= 1500)
            {

                // Calculating the 3%
                extra = (sales / 100) * 3;

            }
            else
            {

                // Calculating the 5% plus full 3% of the 1500
                extra = (((sales - 1500) / 100) * 5) + 45;

            }

            float total = wage + extra;

            Console.WriteLine("The salesman total payout is " + total);
            Console.WriteLine();
        }
    }
}
