using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023
{
    internal class Program
    {
        static void PrintJaggedArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = 0; y < arr[i].Length; y++)
                {
                    Console.Write($"{arr[i][y]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int max_size = 10;
            const int max_val = 100;
            int[][] arr = new int[rnd.Next(1, max_size)][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rnd.Next(1, max_size)];
                for (int y = 0; y < arr[i].Length; y++)
                {
                    arr[i][y] = rnd.Next(0, max_val);
                }
            }

            PrintJaggedArr(arr);

            #region Task 1
            int[] iSwap = { 0, 0};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[iSwap[0]].Length < arr[i].Length) iSwap[0] = i;
                if (arr[iSwap[1]].Length > arr[i].Length) iSwap[1] = i;
            }
            (arr[iSwap[0]], arr[iSwap[1]]) = (arr[iSwap[1]], arr[iSwap[0]]);
            PrintJaggedArr(arr);
            #endregion

            #region Task 2
            int[][] arr_2 = new int[rnd.Next(1, max_size)][];
            for (int i = 0; i < arr_2.Length; i++)
            {
                arr_2[i] = new int[arr_2.Length - i];
                for (int y = 0; y < arr_2[i].Length; y++)
                {
                    arr_2[i][y] = rnd.Next(0, max_val);
                }
            }

            PrintJaggedArr(arr_2);  
            #endregion

            Console.ReadKey();
        }
    }
}
