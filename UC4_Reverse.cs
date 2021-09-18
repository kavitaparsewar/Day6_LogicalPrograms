using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalPrograms
{
    class UC4_Reverse
    {
        public static void rev()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");

            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }

    }
}
