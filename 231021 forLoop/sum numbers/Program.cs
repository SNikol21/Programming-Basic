using System;

namespace sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum = num2+ sum;
                
            }
            Console.WriteLine(sum);
        }
    }
}
