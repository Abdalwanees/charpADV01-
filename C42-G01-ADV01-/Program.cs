using C42_G01_ADV01.BubbleSort;
using C42_G01_ADV01.Genaric;

namespace C42_G01_ADV01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            int[] arr = { 3, 5, 9, 7, 5, 6, 5, 1, 4, 2, 3 };

            Console.Write("Arr :[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }

            Console.WriteLine("\n---------------");
            Console.WriteLine("Array After Sorting");
            Sort.BubbleSort(arr);
            #endregion
            Console.WriteLine();
            #region MyRegion
            Range<int> range = new Range<int>(5, 15);
            Console.WriteLine($"Is 10 in range: {range.IsInRange(10)}");  // True
            Console.WriteLine($"Is 20 in range: {range.IsInRange(20)}");  // False
            Console.WriteLine($"Length of range: {range.Length()}");      // 10
            #endregion
        }
    }
}
