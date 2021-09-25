using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Permutation
    {
        /// <summary>
        /// method to calculate parmutation 
        /// </summary>
        /// <param name="str"> string provided for parmutation </param>
        /// <param name="l"> starting index</param>
        /// <param name="r"> end index </param>
        public void permute(string str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = swap(str, start, i);
                    permute(str, start + 1, end);
                    str = swap(str, start, i);
                }
            }
        }

        /// <summary>
        /// method to swap character at position and return swapped string
        /// </summary>
        /// <param name="a"> string value </param>
        /// <param name="i"> position 1 </param>
        /// <param name="j"> position 2 </param>
        /// <returns></returns>
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

    }
        
}
