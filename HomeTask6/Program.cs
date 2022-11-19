using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 34, 12, 875, 23, 5, 7, 1, 6 , 65 };

            foreach(int res in myArray.Reverse())
            {
                Console.Write($"{res} ");
            }

            Console.ReadKey();
        }
    }
}
