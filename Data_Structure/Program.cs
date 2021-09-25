using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure");
            Console.WriteLine("Enter string for permutation : ");
            string str = Console.ReadLine();
            Console.WriteLine("\n");
            int n = str.Length;
            Permutation par = new Permutation();
            par.permute(str, 0, n - 1);
        }
    }
}
