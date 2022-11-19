using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте размер массива");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[arraySize];
            
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Задайте значение массива");
                int userValue = Convert.ToInt32(Console.ReadLine());
                userArray.SetValue(userValue, i);
            }

            Console.WriteLine("Наибольшее значение массива");
            Console.WriteLine(userArray.Max());

            Console.WriteLine("Наименьшее значение массива");
            Console.WriteLine(userArray.Min());

            Console.WriteLine("Сумма всех элементов");
            Console.WriteLine(userArray.Sum());

            Console.WriteLine("Среднее арифметическое");
            Console.WriteLine(userArray.Average());

            Console.WriteLine("Все нечетные числа");
            for (int i = 0; i < userArray.Length; i++)
            {
                if(userArray[i] % 2 == 1)
                {
                    Console.WriteLine(userArray[i]);
                }
            }


            Console.ReadKey();

        }
    }
}
