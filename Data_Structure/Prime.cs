using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Prime
    {
        /// <summary>
        /// method to find prime number between given range
        /// </summary>
        public void prime()
        {
            int num1, num2, count1 = 0, count2 = 0;
            Console.Write("Enter lower range: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper range: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers between {0} and {1} are: ", num1, num2);
            Console.WriteLine("\n");
            for (int i = num1; i < num2; i++)//for loop till num2
            {
                count1 = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0) //checking for reminder 0
                        {
                            count1 = 1;
                            break;
                        }
                    }
                    if (count1 == 0)
                    {
                        count2++; //for checking total prime number between given range 
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("We found {0} prime numbers.", count2);
        }
    }
}
