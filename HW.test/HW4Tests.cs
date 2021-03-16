using NUnit.Framework;
using HW;

namespace HW.test
{
    class HW4Tests
    {

        [TestCase( new int[] {0, 100, 750, 20, 150, 37, 9950}, 0)]
        [TestCase( new int[] {10, 33, 22, 20, 96, 37, 9950}, 10)]
        [TestCase( new int[] {100, 100, 100, 100, 100}, 100)]
           
        public static void Task1(int[] a, int expected)
        {
            int actual = HW4.task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, 9950)]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, 96)]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, 100)]

        public static void Task2(int[] a, int expected)
        {
            int actual = HW4.task2(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, 0)]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37, 9950 }, 0)]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, 0)]

        public static void Task3(int[] a, int expected)
        {
            int actual = HW4.task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, 6)]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, 4)]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, 0)]

        public static void Task4(int[] a, int expected)
        {
            int actual = HW4.task4(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, 157)]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, 90)]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, 200)]

        public static void Task5(int[] a, int expected)
        {
            int actual = HW4.task5(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, new int[] {9950, 37, 150, 20, 750, 100, 0 })]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, new int[] { 37, 96, 20, 22, 33, 10})]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, new int[] { 100, 100, 100, 100, 100 })]

        public static void Task6(int[] a, int[] expected)
        {
            int[] actual = HW4.task6(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, 3)]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, 3)]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, 2)]

        public static void Task7(int[] a, int expected)
        {
            int actual = HW4.task7(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, new int[] { 150, 37, 9950, 20, 0, 100, 750 })]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, new int[] { 20, 96, 37, 10, 33, 22 })]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, new int[] { 100, 100, 100, 100, 100 })]

        public static void Task8(int[] a, int[] expected)
        {
            int[] actual = HW4.task8(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, new int[] { 0, 20, 37, 100, 150, 750, 9950})]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, new int[] { 10, 20, 22, 33, 37, 96 })]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, new int[] { 100, 100, 100, 100, 100 })]

        public static void Task9(int[] a, int[] expected)
        {
            int[] actual = HW4.task9(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 100, 750, 20, 150, 37, 9950 }, new int[] { 0, 20, 37, 100, 150, 750, 9950 })]
        [TestCase(new int[] { 10, 33, 22, 20, 96, 37 }, new int[] { 10, 20, 22, 33, 37, 96 })]
        [TestCase(new int[] { 100, 100, 100, 100, 100 }, new int[] { 100, 100, 100, 100, 100 })]

        public static void Task10(int[] a, int[] expected)
        {
            int[] actual = HW4.task10(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
