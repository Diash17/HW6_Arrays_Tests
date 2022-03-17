using NUnit.Framework;
using System;
using OneDimensionalArrays;



namespace OneDimensionalArrayTests
{
    public class OneDimensionalArrayTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { -1, -2, -6, -23 }, -23)]
        [TestCase(new int[] { 12, 12, 12 }, 12)]
        public void FindMinOfArrayElementsTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindMinOfArrayElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMinOfArrayElementsTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindMinOfArrayElements(a)));
        }
        //2
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { -1, -2, -6, -23 }, -1)]
        [TestCase(new int[] { 12, 12, 12 }, 12)]
        public void FindMaxOfArrayElementsTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindMaxOfArrayElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMaxOfArrayElementsTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindMaxOfArrayElements(a)));
        }

        //3
        [TestCase(new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { -1, -2, -6, -23 }, 0)]
        [TestCase(new int[] { 12, 12, 12 }, 0)]
        public void FindIndexOfMaxArrayElementTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindIndexOfMaxArrayElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfMaxArrayElementTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindIndexOfMaxArrayElement(a)));
        }

        //3
        [TestCase(new int[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { -1, -2, -6, -23 }, 3)]
        [TestCase(new int[] { 12, 12, 12 }, 0)]
        public void FindIndexOfMinArrayElementTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindIndexOfMinArrayElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfMinArrayElementTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindIndexOfMinArrayElement(a)));
        }

        //4
        [TestCase(new int[] { 1, 2, 3, 4 }, 6)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 2 }, 6)]
        [TestCase(new int[] { -1, -2 }, -2)]
        [TestCase(new int[] { 12 }, 0)]
        public void FindSumElementsOfOddIndexTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindSumElementsOfOddIndex(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindSumElementsOfOddIndexTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindSumElementsOfOddIndex(a)));
        }

        //5
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 66, 77, 88, 11 }, new int[] { 11, 88, 77, 66 })]
        [TestCase(new int[] { -1, -2 }, new int[] { -2, -1 })]


        public void DoReverseOfArrayTest(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArray.DoReverseOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void DoReverseOfArrayTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindSumElementsOfOddIndex(a)));
        }

        //6 

        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 2 }, 2)]
        [TestCase(new int[] { -1, -2 }, 1)]
        [TestCase(new int[] { 12 }, 0)]
        public void FindSumElementsOfOddDigitsTest(int[] a, int expected)
        {
            int actual = OneDimensionalArray.FindSumElementsOfOddDigits(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindSumElementsOfOddDigitsTest_WhenLenghtIsZero_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>((() => OneDimensionalArray.FindSumElementsOfOddDigits(a)));
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 2 }, new int[] { 3, 4, 2, 0, 1, 2 })]
        [TestCase(new int[] { -1, -2 }, new int[] { -2, -1 })]
        [TestCase(new int[] { 12 }, new int[] { 12 })]

        public void ChangePlacesOfTwoPartsOfArrangeTest(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArray.ChangePlacesOfTwoPartsOfArrange(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 2 }, new int[] { 0, 1, 2, 2, 3, 4 })]
        [TestCase(new int[] { -56, -3, 12, 5, -1, -2 }, new int[] { -56, -3, -2, -1, 5, 12 })]
        [TestCase(new int[] { 12 }, new int[] { 12 })]

        public void DoBubbleSortTest(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArray.DoBubbleSort(a);
            Assert.AreEqual(expected, actual);
        }




    }



}