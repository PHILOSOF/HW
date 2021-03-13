using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{
    public static class HW3
    {
        private static bool isEvenMoreUneven(int num)
        {
            bool ret = false;
            int even = 0;
            int uneven = 0;
            do
            {
                if ((num % 10) % 2 == 0)
                {
                    even += (num % 10);
                }
                else
                {
                    uneven += (num % 10);
                }
                num /= 10;
            }
            while (num != 0);
            if (even > uneven)
            {
               ret = true;
            }

            return ret;
        }
        //1. Пользователь вводит 2 числа(A и B).Возвести число A в степень B.
        public static double task1(double a, double b)
        {
            double pov = 1;
            for (int i = 0; i < b; ++i)
            {
                pov *= a;
            }
            return pov;
        }

        //2. Пользователь вводит 1 число(A).Вывести все числа от 1 до 1000, которые делятся на A.
        public static int[] task2(int a = 50)
        {
            int[] arr = new int[1000 / a];
            for (int i = a; i <= 1000; i += a)
            {
                //Console.Write(i + " ");
                arr[(i / a) - 1] = i;
            }
            return arr;
        }

        //3. Пользователь вводит 1 число(A).
        //     Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int task3(int a)
        {
            int tmp = 0;
            for (int i = 1; i * i < a; ++i)
            {
                tmp = i;
            }
            return tmp;
        }

        //4. Пользователь вводит 1 число(A).Вывести наибольший делитель(кроме самого A) числа A.
        public static int task4(int a = 137)
        {

            for (int i = 2; i < a; ++i)
            {
                if (a % i == 0)
                {
                    return a / i;

                }
            }
            return 1;
        }

        //5. Пользователь вводит 2 числа(A и B).
        //     Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
        //     (Учтите, что при вводе B может оказаться меньше A).
        public static int task5(int a = 1,int b = 157)
         {
            int tmp;
            if (b<a)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            tmp = 0;
            for (int i = (int)a; i <= b; ++i)
            {
                if (i % 7 == 0)
                {
                    tmp += i;
                }
            }
            return tmp;
            }

        //6. Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.
        //     В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        public static int task6(int a=7)
        {
            int first = 1;
            int second = 1;
            int tmp = 0;
            if (a < 3)
            {
                tmp = 1;
            }
            for (int i = 3; i <= a; ++i)
            {
                tmp = first + second;
                first = second;
                second = tmp;
            }
            return tmp;
        }
                                    

        //7. Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
        public static int task7(int a,int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a+b;
        }

        //8. Пользователь вводит целое положительное число,
        //     которое является кубом целого числа N. Найдите число N методом половинного деления.
        public static int task8(int a)
        {
            int left = 1;
            int right = a;
            int middle = right;
            while(middle*middle*middle != a)
            {
               if(((right + left) / 2) * ((right + left) / 2) * ((right + left) / 2) > a)
                {
                    right = middle;
                }
               else
                {
                    left = middle;
                }
                middle = (right + left) / 2;
            }
            return middle;
        }

        //9. Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
        public static int task9(int a)
        {
           int tmp = 0;
            
            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                    ++tmp;
                a /= 10;
            }
           return tmp;
        }

        //10. Пользователь вводит 1 число.Найти число, которое является зеркальным отображением последовательности
        //     цифр заданного числа, например, задано число 123, вывести 321.
        public static int task10(int a)
        {
            int tmp = a % 10;
            a /= 10;
            while (a != 0)
            {
                tmp *= 10;
                tmp+=a % 10;
                a /= 10;
            }
            return tmp;
        }
 
    //11. Пользователь вводит целое положительное  число(N).Выведите числа в диапазоне от 1 до N,
    //     сумма четных цифр которых больше суммы нечетных. 
    public static int[] task11(int N)
        {
            int count = 0;
            for(int i=2;i<=N;++i)
            {  
                if (isEvenMoreUneven(i))
                {

                    ++count;
                }
            }
            int[] retArr = new int[count];
            count = 0;
            for (int i = 2; i <= N; ++i)
            {
                if (isEvenMoreUneven(i))
                {
                    retArr[count] = i;
                    ++count;
                }
            }
            return retArr;
        }

    //12. Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
    //     Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
    public static bool task12(int a,int b)
        {
            bool ret = false;
            a = Math.Abs(a);
            b = Math.Abs(b);
            do
            {
                int tmp = b;
                do
                {
                    if (a % 10 == tmp % 10)
                        return true;
                    tmp /= 10;
                }
                while (tmp != 0);
                a /= 10;
            }
            while (a != 0);

            return ret;
        }


}
}
