using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW
{

    //Console.WriteLine("Нажмите любую кнопку...");
    //Console.ReadLine();
    //Console.Clear();
    public static class HW2
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
            if(a==0 || b==0)
            {
                throw new System.ArgumentException("The point is on the coordinate axis");
            }
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
            else
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
        public static double[] task4(double a, double b, double c)
        {
            double[] retArr = new double[2];
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                retArr[0] = (-b - Math.Sqrt(D)) / (2 * a);
                retArr[1] = (-b + Math.Sqrt(D)) / (2 * a);
                
            }
            else
            {
                throw new Exception("Discriminant less than zero, no solutions");
            }

            return retArr;
        }

         //5.Пользователь вводит двузначное число.
        //    Выведите в консоль прописную запись этого числа.
        //    Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string task5(int num)
        {
            string output = "";   
            if(9<num && num<20)
            {
                switch (num)
                {
                    case 10: output = "десять"; break;
                    case 11: output = "одинадцать"; break;
                    case 12: output = "двенадцать"; break;
                    case 13: output = "тринадцать"; break;
                    case 14: output = "четырнадцать"; break;
                    case 15: output = "пятнадцать"; break;
                    case 16: output = "шестнадцать"; break;
                    case 17: output = "семнадцать"; break;
                    case 18: output = "восемнадцать"; break;
                    case 19: output = "девятнадцать"; break;
                }
            }
            else
            {
                switch (num / 10)
                {
                    case 2: output = "двадцать "; break;
                    case 3: output = "тридцать "; break;
                    case 4: output = "сорок "; break;
                    case 5: output = "пятьдесят "; break;
                    case 6: output = "шестьдесят "; break;
                    case 7: output = "семдесят "; break;
                    case 8: output = "восемьдесят "; break;
                    case 9: output = "девяносто "; break;
                }
                switch (num % 10)
                {
                    case 1: output += "один"; break;
                    case 2: output += "два"; break;
                    case 3: output += "три"; break;
                    case 4: output += "четыре"; break;
                    case 5: output += "пять"; break;
                    case 6: output += "шесть"; break;
                    case 7: output += "семь"; break;
                    case 8: output += "восемь"; break;
                    case 9: output += "девять"; break;
                }

            }
            return output;
        }

}
       
}

