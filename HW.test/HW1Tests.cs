using NUnit.Framework;
using HW;

namespace HW.test
{
    public class HW1Tests
    {
        [TestCase(1, 5, 7.5)]
        [TestCase(10, 2, -6.75)]
        [TestCase(3, 8, 15.8)]
        public void Task1(double a, double b, double expected)
        {
            double actual = HW1.task1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 5, 1)]
        [TestCase(0, 1, 1, 0)]
        [TestCase(10,0,0,10)]
        public void Task2(int a,int b, int expectedA, int expectedB)
        {
            HW1.task2(ref a, ref b);

            int actualA = a;
            int actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(1, 5, new int[2] { 0, 1 })]
        [TestCase(10, 2, new int[2] { 5, 0 })]
        [TestCase(8, 3, new int[2] { 2, 2 })]
        public void Task3(int a, int b, int[] expected)
        {
            int[] actual = HW1.task3(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 3, -2)]
        [TestCase(10, 2, 7, 0.5)]
        [TestCase(8, 3, 2, -0.125)]
        public void Task4(double a, double b, double c, double expected)
        {
            double actual = HW1.task4(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //$"Y = {(y1 - y2) / (x1 - x2)}X + {y2 - ((y1 - y2) / (x1 - x2)) * x2}"
        [TestCase(1, 5, 3, 2, "Y = -1,5X + 6,5")]
        [TestCase( 10, 2, 7, 5, "Y = -1X + 12")]
        [TestCase( 8, 3, 2, 12, "Y = -1,5X + 15")]
        public void Task5(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = HW1.task5(x1,y1,x2,y2);
            Assert.AreEqual(expected, actual);
        }
    }
}