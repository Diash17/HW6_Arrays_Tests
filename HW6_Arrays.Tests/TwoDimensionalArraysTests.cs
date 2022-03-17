using System;
using TwoDimensionalArrays;
using NUnit.Framework;
using HW6_Arrays;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwoDimensionalArrayTests
{

    public class TwoDimensionalArrayTests
    {
        [TestCase(TwoDimensionalMockType.First, 1)]
        [TestCase(TwoDimensionalMockType.Second, 1)]

        public void FindMinElementTest(TwoDimensionalMockType type, int expected)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int actual = TwoDimensionalArray.FindMinElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void FindMinElementTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.FindMinElement(a));
        }


        [TestCase(TwoDimensionalMockType.First, 53)]
        [TestCase(TwoDimensionalMockType.Second, 9)]
        public void FindMaxElementTest(TwoDimensionalMockType type, int expected)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int actual = TwoDimensionalArray.FindMaxElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void FindMaxElementTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.FindMaxElement(a));
        }

        [TestCase(TwoDimensionalMockType.First, new int[] { 2, 1 })]
        [TestCase(TwoDimensionalMockType.Third, new int[] { 0, 0 })]
        public void FindIndexOfMaxElementTest(TwoDimensionalMockType type, int[] expected)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int[] actual = TwoDimensionalArray.FindIndexOfMaxElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void FindIndexOfMaxElementTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.FindIndexOfMaxElement(a));
        }
        [TestCase(TwoDimensionalMockType.First, new int[] { 0, 0 })]
        [TestCase(TwoDimensionalMockType.Third, new int[] { 1, 2 })]
        public void FindIndexOfMinElementTest(TwoDimensionalMockType type, int[] expected)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int[] actual = TwoDimensionalArray.FindIndexOfMinElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void FindIndexOfMinElementTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.FindIndexOfMinElement(a));
        }


        [TestCase(TwoDimensionalMockType.First, 2)]
        [TestCase(TwoDimensionalMockType.Second, 2)]
        [TestCase(TwoDimensionalMockType.Third, 3)]
        public void FindNumberOfTheBiggestElementAroundNeighboursTest(TwoDimensionalMockType type, int expected)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int actual = TwoDimensionalArray.FindNumberOfTheBiggestElementAroundNeighbours(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void FindNumberOfTheBiggestElementAroundNeighboursTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.FindNumberOfTheBiggestElementAroundNeighbours(a));
        }

        [TestCase(TwoDimensionalMockType.First, TwoDimensionalMockType.FirstMirrored)]
        [TestCase(TwoDimensionalMockType.Second, TwoDimensionalMockType.SecondMirrored)]
        [TestCase(TwoDimensionalMockType.Third, TwoDimensionalMockType.ThirdMirrored)]
        
        public void CreateMirrorByMainDiagonalTest(TwoDimensionalMockType type, TwoDimensionalMockType expectedType)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            int[,] expected = TwoDimensionalMock.GetMock(expectedType);
            int[,] actual = TwoDimensionalArray.CreateMirrorByMainDiagonal(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwoDimensionalMockType.Empty)]
        public void CreateMirrorByMainDiagonalTest_WhenLenghtIsZero_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.CreateMirrorByMainDiagonal(a));
        }

        [TestCase(TwoDimensionalMockType.NotSquare)]
        public void CreateMirrorByMainDiagonalTest_WhenIsNotSquare_ShouldThrowException(TwoDimensionalMockType type)
        {
            int[,] a = TwoDimensionalMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArray.CreateMirrorByMainDiagonal(a));
        }
    }

}
