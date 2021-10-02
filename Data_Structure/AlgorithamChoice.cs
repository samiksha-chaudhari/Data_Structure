using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class AlgorithamChoice
    {
        public void algoritham()
        {
             int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {

                Console.WriteLine("------------------------Welcome to Algorithm Prblems-----------------------");
                Console.WriteLine("1.Parmutation 2.Binary Search  3.Insertion Sort  4.Bubble Sort  5.Anagram  6.Merge Sort  7.Prime  8.Exit");
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
                    case 2:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.binarysearch();
                        break;
                    case 3:
                        InsertionSort insert = new InsertionSort();
                        insert.Insert();
                        break;
                    case 4:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Bubblesort();
                        break;
                    case 5:
                        Anagram anagram = new Anagram();
                        anagram.anagram();
                        break;
                    case 6:
                        MergeSort merge = new MergeSort();
                        merge.Merging();
                        break;
                    case 7:
                        Prime num = new Prime();
        num.prime();
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
