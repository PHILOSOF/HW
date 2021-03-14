using NUnit.Framework;
using HW;

namespace HW.test
{
    class HW5Tests
    {
        [TestCase(1, -5)]
        [TestCase(2, -999)]
        [TestCase(3, -9)]
        public void Task1(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int actual = HW5.task1(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,15)]
        [TestCase(2,81)]
        [TestCase(3,92)]
        public void Task2(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int actual = HW5.task2(arr);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1,new int[] {2, 1 })]
        [TestCase(2, new int[] {2, 2 })]
        [TestCase(3, new int[] {2, 2 })]
        public void Task3(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = HW5.task3(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {2, 2 })]
        [TestCase(2, new int[] { 0, 2 })]
        [TestCase(3, new int[] {1, 3 })]
        public void Task4(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = HW5.task4(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1 )]
        [TestCase(2,2)]
        [TestCase(3,2)]
        public void Task5(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int actual = HW5.task5(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,4)]
        [TestCase(2,5)]
        [TestCase(3,6)]
        public void Task6(int mockNumber, int expectedMockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);
            int[,] actual = HW5.task6(arr);
            int[,] expected = DoubleArrayMock.GetMock(expectedMockNumber);
            Assert.AreEqual(expected, actual);
        }


    }

    public static class DoubleArrayMock
    { 
    public static int[,] GetMock(int number)
    {
            int[,] result= new int[,] { };
        switch (number)
        {
            case 1:
                {
                    result = new int[,]
                    {
                    {1, 2, 3},
                    {5, 8, 0},
                    {-2, -5, 15}
                    };
                    break;
                }
           case 2:
                {
                    result = new int[,]
                    {
                    {60, 2, 81},
                    {5, 25, 0},
                    {-2, -5,-999}
                    };
                    break;
                }
          case 3:
                {
                    result = new int[,]
                    {
                    {60, 2, 81, 48},
                    {5, 25, 0, 92},
                    {-2, -5,-9, 42}
                    };
                    break;
                }
          case 4:
                {
                    result = new int[,]
                    {
                    {1, 5, -2},
                    {2, 8, -5},
                    {3, 0, 15}
                    };
                    break;
                }
           case 5:
                {
                    result = new int[,]
                    {
                    {60, 5, -2},
                    {2, 25, -5},
                    {81, 0,-999}
                    };
                    break;
                }
          case 6:
                {
                    result = new int[,]
                    {
                    {60, 5, -2},
                    {2, 25, -5},
                    {81, 0, -9},
                    {48, 92, 42}

                    };
                    break;
                }


        }
        return result;
    }
    }
}
