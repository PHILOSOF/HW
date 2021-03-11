using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{





    public static class HW1
    {
        //// задача №1 Пользователь вводит 2 числа(A и B). Выведите в консоль решение (5*A+B*B)/(B-A)
        //    Console.WriteLine((5 * a + b* b) / (b - a) + "\n");
        public static double task1(double a, double b)
        {
            if (a == b)
                throw new DivideByZeroException();
            return (5 * a + b * b) / (b - a);
        }

        //// задача №3 Пользователь вводит 2 числа(A и B). Выведите в консоль результат деления A на B и остаток от деления.
        public static int[] task3(int a, int b)
        {
            if (b==0)
                throw new DivideByZeroException();
            return  new int[2] { a / b, a % b };
        }
       
        //// задача №4 Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B=C.
        public static double task4(double a, double b, double c)
            {
            if (a == 0)
                throw new DivideByZeroException();
            return (c - b) / a;
            }

        ////задача №5 Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
        ////Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.
        ///
        public static string task5(double x1,double y1,double x2, double y2)
        {
            if ((x1 == x2) || x2 == 0)
            {
                throw new DivideByZeroException();
            }
            return $"Y = {(y1 - y2) / (x1 - x2)}X + {y2 - ((y1 - y2) / (x1 - x2)) * x2}";
        }

    }
}
