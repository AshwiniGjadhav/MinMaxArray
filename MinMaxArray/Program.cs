using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 6, 5, 4, 2, 3, 9, 8, 10, 11 };
            int j, i;
            int max = arr[0];
            int min = arr[0];


            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine($"Maximum array number {max}");

            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine($"Minimum array number  {min}");

        }
    }
}
