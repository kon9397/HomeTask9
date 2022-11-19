using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 7, 43, 23, 6 };


            foreach (var res in MyReverse(arr))
            { 

                Console.Write($"{res} ");
            }
            Console.WriteLine();

            foreach (var res in SubArray(arr, 3, 8))
            {

                Console.Write($"{res} ");
            }

            Console.ReadKey();


        }
        static int[] MyReverse(int[] array)
        {
            int n = array.Length;
            int[] aux = new int[n];

            for (int i = 0; i < n; i++)
            {
                aux[n - 1 - i] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = aux[i];
            }

            return array;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                int j = i + index;
                if (j >= array.Length)
                    newArray[i] = 1;
                else
                    newArray[i] = array[j];
            }

            return newArray;
        }
    }
}
