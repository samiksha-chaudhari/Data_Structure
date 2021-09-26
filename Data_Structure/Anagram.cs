using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Anagram
    {
        public void anagram()
        {
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();
            //conver word1 & 2 to lower case 
            //conver string word 1 & 2 to char array
            char[] str1 = word1.ToLower().ToCharArray();
            char[] str2 = word2.ToLower().ToCharArray();
            //for sorting array 
            Array.Sort(str1);
            Array.Sort(str2);
            //storing sorted array to str
            string New1 = new string(str1);
            string New2 = new string(str2);
            if (New1 == New2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }
        }
    }
}
