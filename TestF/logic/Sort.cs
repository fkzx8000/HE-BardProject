using System;
using System.Collections.Generic;

namespace TestF.logic.DataAndFile
{
    public class Sort
    {
        private static void Swap(BirdData[] arr, int i, int j)
        {
            BirdData temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static BirdData[] ConvertToArr(List<BirdData> data)
        {
            BirdData[] Data = data.ToArray();

            return Data;
        }

        // O(n^2) Sorting Algorithm
        public static BirdData[] RegularSort(BirdData[] array)
        {

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (int.Parse(array[i].Serial) > int.Parse(array[i + 1].Serial))
                    {
                        Swap(array, i + 1, i);
                    }
                }
            }

            return array;
        }




        public static BirdData[] QuickSort(BirdData[] array, int leftIndex, int rightIndex)
        {
            Console.WriteLine(array);
            if (leftIndex <= 0 && rightIndex < 0)
                return new BirdData[0]; 

            var i = leftIndex;
            var j = rightIndex;
            var pivot = int.Parse(array[leftIndex].Serial);

            while (i <= j)
            {
                while (int.Parse(array[i].Serial) < pivot)
                {
                    i++;
                }

                while (int.Parse(array[j].Serial) > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }

            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex);

            return array;
        }
    }
}
