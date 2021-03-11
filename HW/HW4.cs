using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{
    public static class HW4
    {
        public static int[] createAndFillArray(int size = 9, int min = 0, int max = 10)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; ++i)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }

        public static void showArray(int[] arr)
        {
           
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            
        }

        //1.Найти минимальный элемент массива
        public static int task1(int[] arr)
        {
            int min = arr[0];
            for(int i=1;i<arr.Length;++i)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        //2.Найти максимальный элемент массива
        public static int task2(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        //3.Найти индекс минимального элемента массива

        public static int task3(int[] arr)
        {
            int min = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < arr[min])
                    min = i;
            }
            return min;
        }
        //4.Найти индекс максимального элемента массива
        public static int task4(int[] arr)
        {
            int max = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] > arr[max])
                    max = i;
            }
            return max;
        }
        //5.Посчитать сумму элементов массива с нечетными индексами
        public static int task5(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (i%2 != 0)
                    sum += i;
            }
            return sum;
        }

        //6.Сделать реверс массива(массив в обратном направлении)
        public static int[] task6(int[] arr)
        {
            int tmp = 0;
            int i = 0;
            int j = arr.Length - 1;
            while (i < arr.Length / 2)
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                ++i;
                --j;
            }
            return arr;
        }

        //7.Посчитать количество нечетных элементов массива
        public static int task7(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (i % 2 != 0)
                    ++count;
            }
            return count;
        }

        //8.Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public static int[] task8(int[] arr)
        {
            int tmp = 0;        
            int i = arr.Length / 2 - 1;
            int j = arr.Length - 1;
            while(i >= 0)
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                --i;
                --j;
            }
            return arr;
        }

        //9.Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором(Select) или вставками(Insert))
            public static int[] task9(int[] arr)
        {
            int tmp;
            for (int i = 0; i < arr.Length; ++i)
            {
                for(int j=i+1;j<arr.Length;++j)
                {
                    if(arr[i]>arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                } 
            }
            return arr;
        }

        //10.Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public static int[] task10(int[] arr)
        {
            int tmp;
            for (int i = 1; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr.Length-i; ++j)
                {
                    if (arr[j+1] < arr[j])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}
