/*
 * Методы для удаления первого, последнего эл-та
 * и эл-та по указанному индексу
 */


using System;

namespace Less_14
{
    internal class Program
    {
        static void RemoveAt(ref int[] arr, int index)
        {
            if (index <= arr.Length)
            {
                int[] endArr = new int[arr.Length - 1];
                for (int i = 0; i < index; i++)
                    endArr[i] = arr[i];
                for (int i = index + 1; i < arr.Length; i++)
                    endArr[i - 1] = arr[i];

                arr = endArr;
            }
            else { Console.WriteLine("Index out of range array."); return; }
        }
        static void RemoveFirst(ref int[] arr)
        {
            RemoveAt(ref arr, 0);
        }
        static void RemoveLast(ref int[] arr)
        {
            RemoveAt(ref arr, arr.Length -1);
        }

        static void Main(string[] args)
        {
            int[] baseArr = { 1, 2, 3, 4, 5 };
            for (int i = 0;i < baseArr.Length; i++)
                Console.WriteLine($"[{i}] {baseArr[i]}");

            RemoveAt(ref baseArr, 2);
            for (int i = 0;i < baseArr.Length; i++)
                Console.WriteLine($"[{i}] {baseArr[i]}");

            RemoveFirst(ref baseArr);
            for (int i = 0;i < baseArr.Length; i++)
                Console.WriteLine($"[{i}] {baseArr[i]}");

            RemoveLast(ref baseArr);
            for (int i = 0;i < baseArr.Length; i++)
                Console.WriteLine($"[{i}] {baseArr[i]}");

            Console.ReadLine();
        }
    }
}
