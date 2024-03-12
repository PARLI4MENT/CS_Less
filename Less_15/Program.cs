/* 
 * Less 15
 * Вывод массива с помощью рекурсии
 */

using System;

namespace Less_14
{
    internal class Program
    {
        static void PrintArrOfRecursive(ref int[] arr, int index = 0)
        {
            if (index < arr.Length)
            {
                Console.WriteLine(arr[index]);
                PrintArrOfRecursive(ref arr, index + 1);
            }
            return;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            PrintArrOfRecursive(ref arr);

            Console.ReadKey();
        }
    }
}
