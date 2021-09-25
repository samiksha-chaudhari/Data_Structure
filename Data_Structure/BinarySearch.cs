using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class BinarySearch
    {
        public void binarysearch()
        {
            string samplePara = "Future belongs to those who believe in the beauty of their dreams";
            string[] para = samplePara.Split(" ");
            
            Array.Sort(para); //sorting Array

            Console.WriteLine("Enter word you want to search : ");
            string search = Console.ReadLine();

            int i = Array.BinarySearch(para, search);

            if (i >= 0)
                Console.WriteLine("word found at position " + i + "\n");
            else
                Console.WriteLine("word not found\n");
        }
    }
}
