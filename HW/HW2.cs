using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{

    //Console.WriteLine("Нажмите любую кнопку...");
    //Console.ReadLine();
    //Console.Clear();
    class HW2
    {
        ////1.Пользователь вводит 2 числа(A и B).Если A > B, 
        ////    подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B.

        public static double task1(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        ////2.Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y).

        public static int task2(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                return 1;
            }
            else if (a < 0 && b > 0)
            {
                return 2;
            }
            else if (a < 0 && b < 0)
            {
                return 3;
            }
            else //if (a > 0 && b < 0)
            {
                return 4;
            }

        }

        ////3.Пользователь вводит 3 числа(A, B и С).Выведите их в консоль в порядке возрастания.

        public static int[] task3(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    if (b < c)
                        return new int[3] { a, b, c };
                    else
                        return new int[3] { a, c, b };
                }
                else
                    return new int[3] { c, a, b };
            }
            else if (b < c)
            {
                if (a < c)
                    return new int[3] { b, a, c };
                else
                    return new int[3] { b, c, a };
            }
            else
                return new int[3] { c, b, a };

        }


        ////4.Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X)
        ////    квадратного уравнения стандартного вида, где AX2 + BX + C = 0.

        //a = Convert.ToDouble(Console.ReadLine());
        //b = Convert.ToDouble(Console.ReadLine());
        //c = Convert.ToDouble(Console.ReadLine());

        //double D = b * b - 4 * a * c;
        //if (D > 0)
        //{
        //    Console.WriteLine("x1 =" + (-b - Math.Sqrt(D)) / (2 * a));
        //    Console.WriteLine("x2 =" + (-b + Math.Sqrt(D)) / (2 * a));
        //}
        //else if (D == 0)
        //{
        //    Console.WriteLine("Так как дискриминант равен нулю то," +
        //        " квадратное уравнение имеет один действительный корень:");

        //    Console.WriteLine("x =" + (-b) / (2 * a));
        //}
        //else
        //{
        //    Console.WriteLine(" Так как дискриминант меньше нуля, то уравнение не имеет действительных решений.");
        //}


        //5.Пользователь вводит двузначное число.
        //    Выведите в консоль прописную запись этого числа.
        //    Например при вводе “25” в консоль будет выведено “двадцать пять”.
        //public static string task5(int num)
        //{
        //    string ret = "";
        //    int first = num / 10;
        //    int second = num % 10;
        //    string output = "";
        //    switch (first)
        //    {
        //        case 0:
        //            break;
        //    }
        //    return ret;
        //}

}
       
}

