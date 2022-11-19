using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 25, 234, 12, 65, 34, 98 };
            Insert(ref myArray, 11111);
            foreach (int res in myArray)
            {
                Console.Write($"{res} ");
            }

            Console.ReadKey();
        }

        static void Insert(ref int[] array, int value)
        {
            int[] newValues = new int[array.Length + 1];
            newValues[0] = value; // set the prepended value
            Array.Copy(array, 0, newValues, 1, array.Length); // copy the old values

            array = newValues;
        }
    }
}
