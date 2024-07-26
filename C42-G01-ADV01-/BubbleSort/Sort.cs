using System;

namespace C42_G01_ADV01.BubbleSort
{
    internal class Sort
    {
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array is null or empty.");
                return;
            }
            bool swapped;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                Console.WriteLine($"\nStep {i + 1}:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }

                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
