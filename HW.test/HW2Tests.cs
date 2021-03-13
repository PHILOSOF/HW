using NUnit.Framework;
using HW;

namespace HW.test
{
    class HW2Tests
    {

        [TestCase(6, 5, 11)]
        [TestCase(10,10,100)]
        [TestCase(3, 8,-5)]
        public void Task1(double a, double b, double expected)
        {
            double actual = HW2.task1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 5, 1)]
        [TestCase(-1, 3, 2)]
        [TestCase(3, -5, 4)]
        public void Task2(double a, double b, double expected)
        {
            double actual = HW2.task2(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 3, new int[3] {1, 3, 5 })]
        [TestCase(10, 2, 5, new int[3] {2, 5, 10 })]
        [TestCase(8, 3, 10, new int[3] {3, 8 ,10 })]
        public void Task3(int a, int b, int c, int[] expected)
        {
            int[] actual = HW2.task3(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 25, 11, new double[2] { -12.043, -0.45668 })]
        [TestCase(1, 4, 3, new double[2] {-3, -1})]
        [TestCase(1, 2, 1, new double[2] {-1, -1})]
        public void Task4(double a, double b, double c, double[] expected)
        {
            double[] actual = HW2.task4(a, b, c);
            Assert.AreEqual(expected[0], actual[0], 0.001d);
            Assert.AreEqual(expected[1], actual[1], 0.001d);
        }

        [TestCase(23,"двадцать три")]
        [TestCase(1,"один")]
        [TestCase(15,"пятнадцать")]
        public void Task5(int a,string expected)
        {
            string actual = HW2.task5(a);
            Assert.AreEqual(expected, actual);

        }

    }
}
