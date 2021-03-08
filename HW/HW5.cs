using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{
    class HW5
    {
        public static int[,] createAndFillTwoDimensionalArray(int height = 5, int width = 9,  int min = 0, int max = 10)
        {
            int[,] array = new int[height,width];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[i,j] = rand.Next(min, max);
                }
            }
            return array;
        }

        public static void showTwoDimensionalArray(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            
            

        }

        //1.Найти минимальный элемент массива
        public static int task1(int[,] arr)
        {
            int min = arr[0,0];
            for(int i=0;i<arr.GetLength(0) ;++i)
            {
                for(int j=0;j< arr.GetLength(1); ++j )
                {
                    if (min > arr[i, j])
                        min = arr[i, j];
                }
            }
            return min;
        }
        //2.Найти максимальный элемент массива
        public static int task2(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (max < arr[i, j])
                        max = arr[i, j];
                }
            }
            return max;
        }

        //3.Найти индекс минимального элемента массива
        public static int[] task3(int[,] arr)
        {
            int[] min =new int[2] {0,0};
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[min[0],min[1]] > arr[i, j])
                    {
                        min[0] = i;
                        min[1] = j;
                    }
                }
            }
            return min;
        }
        //4.Найти индекс максимального элемента массива
        public static int[] task4(int[,] arr)
        {
            int[] max = new int[2] { 0, 0 };
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[max[0], max[1]] < arr[i, j])
                    {
                        max[0] = i;
                        max[1] = j;
                    }
                }
            }
            return max;
        }

        //5.Найти количество элементов массива, которые больше всех своих соседей одновременно

        //6.Отразите массив относительно его главной диагонали
        public static int[,] task6(int[,] arr)
        {
            int[,] mirrorArr = new int[arr.GetLength(1),arr.GetLength(0)];

            for(int i=0;i< mirrorArr.GetLength(0); ++i)
            {
                for(int j =0;j< mirrorArr.GetLength(1);++j)
                {
                    mirrorArr[i, j] = arr[j, i];
                }
            }
            return mirrorArr;
        }
    }
}
