using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class BubbleSort
    {
        public void Bubblesort()
        {
            int[] arr = {45, 67, 3, 16};
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        Console.WriteLine("Sorted:");
                        foreach (int p in arr)
                            Console.WriteLine(p + " ");
                    }
                }
            }
        }
    }
}
