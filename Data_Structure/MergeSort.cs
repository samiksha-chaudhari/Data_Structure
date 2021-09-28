using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class MergeSort
    {
        /// <summary>
        /// method for printing merge array
        /// </summary>
        public void Merging()
        {
            int[] numbers = {50, 80, 45, 18, 1, 22};
            int len = numbers.Length; //storing length of array in len
                                 
            Console.WriteLine("Number after Merge Sort");
            Sort(numbers, 0, len - 1);//calling sort()
            foreach (int i in numbers)//printing sorted number
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// method for merging sorted sub array 
        /// </summary>
        /// <param name="numbers">number present in array</param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        static public void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1); //Find sizes of left end
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))//while 
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        /// <summary>
        /// method for sortig Array
        /// </summary>
        /// <param name="numbers">array</param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static public void Sort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2; //finding mid value
                Sort(numbers, left, mid);//Call Sort() for first half
                Sort(numbers, (mid + 1), right);//Call Sort() for second half
                Merge(numbers, left, (mid + 1), right);//call merge for merging both sub array
            }
        }
    }
}
