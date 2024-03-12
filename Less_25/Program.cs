/*
 * Способы инициализации массива
 */


namespace Less_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(5, 10).ToArray();
            int[] arr2 = Enumerable.Repeat(5, 10).ToArray();

            Console.ReadKey();
        }
    }
}
