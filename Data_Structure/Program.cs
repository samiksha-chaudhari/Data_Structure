﻿using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {

                Console.WriteLine("------------------------Welcome to data structure-----------------------");
                Console.WriteLine("1.Parmutation 2.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("Enter string for permutation : ");
                        string str = Console.ReadLine();
                        Console.WriteLine("\n");
                        int n = str.Length;
                        Permutation par = new Permutation();
                        par.permute(str, 0, n - 1);
                        break;
                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
                }
            }
        }
    }
}