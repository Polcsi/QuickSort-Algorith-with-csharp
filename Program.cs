using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = 50;
            int range = 501;
            Array quickSort = new Array(length);
            int n = quickSort.Length;

            Console.WriteLine("Original Array:");
            for (int i = 0; i < n; i++)
            {
                if (i == 20 || i == 40)
                {
                    Console.WriteLine();
                }
                quickSort[i] = rnd.Next(0, range);
                Console.Write(quickSort[i] + " ");
            }
            Console.WriteLine();

            quickSort.Sort();

            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < n; i++)
            {
                if (i == 20 || i == 40)
                {
                    Console.WriteLine();
                }
                Console.Write(quickSort[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
