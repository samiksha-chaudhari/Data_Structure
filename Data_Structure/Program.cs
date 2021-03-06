using System;

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
                Console.WriteLine("1.Algorithm Problems 2.Data Structure Problems 3.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        AlgorithamChoice algo = new AlgorithamChoice();
                        algo.algoritham();
                        break;
                    case 2:
                        DataStructureChoice ds = new DataStructureChoice();
                        ds.DataStructure();
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