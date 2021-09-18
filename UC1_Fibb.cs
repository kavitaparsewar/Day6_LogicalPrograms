using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalPrograms
{
    class UC1_Fibb
    {
        public static void fibb()
        {
            int n1 = 0, n2 = 1, n3;

            Console.Write("Enter the number :-  ");
            int number = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); 
            //printing 0 and 1
            

            for (int i = 2; i < number; ++i) 

                //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
