using NUnit.Framework;
using HW;

namespace HW.test
{
    class HW3Tests
    {
        [TestCase(5, 6, 15625)]
        [TestCase(0, 0, 1)]
        [TestCase(5, 2, 25)]
        public static void Task1(double a, double b, double expected)
        {
            double actual = HW3.task1(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(50, new int[] {50, 100, 150, 200, 250, 300, 350
                                , 400, 450, 500, 550, 600, 650, 700
                                , 750, 800, 850, 900, 950, 1000})]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        public static void Task2(int a, int[] expected)
        {
            int[] actual = HW3.task2(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100,9 )]
        [TestCase(1000, 31)]
        [TestCase(7864451, 2804)]
        public static void Task3(int a,int expected)
        {
            int actual = HW3.task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 50)]
        [TestCase(137, 1)]
        [TestCase(7864451, 1123493)]
        public static void Task4(int a,int expected)
        {
            int actual = HW3.task4(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,15, 21)]
        [TestCase(137, 50, 1134)]
        [TestCase(2, 6, 0)]
        public static void Task5(int a,int b,int expected)
        {
            int actual = HW3.task5(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5ul)]
        [TestCase(100, 3736710778780434371ul)]
        [TestCase(28, 317811ul)]
        public static void Task6(int a, ulong expected)
        {
            ulong actual = HW3.task6(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 15, 1)]
        [TestCase(115, 15, 5)]
        [TestCase(2, 6, 2)]
        public static void Task7(int a, int b, int expected)
        {
            int actual = HW3.task7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(491169069ul,789ul)]
        [TestCase(27ul,3ul)]
        [TestCase(94818816ul, 456ul)]
        public static void Task8(ulong a, ulong expected)
        {
            ulong actual = HW3.task8(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(245873, 3)]
        [TestCase(0, 0)]
        [TestCase(-5, 1)]
        public static void Task9(int a,int expected)
        {
            int actual = HW3.task9(a);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(245873, 378542)]
        [TestCase(0, 0)]
        [TestCase(-55234, -43255)]
        public static void Task10(int a,int expected)
        {
            int actual = HW3.task10(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] {2,4,6,8})]
        [TestCase(2, new int[] {2})]
        [TestCase(25, new int[] {2,4,6,8,12,14,16,18,20,21,22,24})]

        
        public static void Task11(int a, int[] expected)
        {
            int[] actual = HW3.task11(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(245873,237, true)]
        [TestCase(0, 0, true)]
        [TestCase(-55234, 16789,false)]
        public static void Task12(int a, int b, bool expected)
        {
            bool actual = HW3.task12(a,b);
            Assert.AreEqual(expected, actual);
        }
    }
}
