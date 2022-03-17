using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArrays
{
    public static class OneDimensionalArray
    {
        public static int[] GenerateArray(int lenght)
        {
            Random random = new Random();
            int[] a = new int[lenght];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-100, 100);
            }

            return a;
        }

        public static void WriteArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static int FindMinOfArrayElements(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }

            }
            return min;
        }

        public static int FindMaxOfArrayElements(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }

            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMaxArrayElement(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }
            int max = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    index = i;

                }
            }
            return index;

        }
        public static int FindIndexOfMinArrayElement(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }
            int min = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    index = i;

                }
            }
            return index;
        }

        //Посчитать сумму элементов массива с нечетными индексами
        public static int FindSumElementsOfOddIndex(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + a[i];
                }

            }
            return sum;
        }
        //Сделать реверс массива (массив в обратном направлении)

        public static int[] DoReverseOfArray(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }

            int[] arrayForReverse = new int[a.Length];
            int j = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                arrayForReverse[j] = a[i];
                j++;
            }
            return arrayForReverse;
        }

        public static int FindSumElementsOfOddDigits(int[] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Can't be zero");
            }

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    sum += 1;
                }

            }
            return sum;
        }

        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312.
        public static int[] ChangePlacesOfTwoPartsOfArrange(int[] a)
        {
            int middle = (a.Length / 2);
            int[] firstPart;
            int[] secondPart;

            if (a.Length % 2 == 0)
            {
                firstPart = new int[middle];
                secondPart = new int[middle];

                int j = 0;
                for (int i = 0; i < middle; i++)
                {
                    firstPart[j] = a[i];
                    j++;
                }

                j = 0;
                for (int i = middle; i < a.Length; i++)
                {
                    secondPart[j] = a[i];
                    j++;
                }

            }
            else
            {
                firstPart = new int[middle + 1];
                secondPart = new int[middle];

                int j = 0;
                for (int i = 0; i <= middle; i++)
                {
                    firstPart[j] = a[i];
                    j++;
                }

                j = 0;
                for (int i = middle + 1; i < a.Length; i++)
                {
                    secondPart[j] = a[i];
                    j++;
                }

            }

            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < middle)
                {
                    result[i] = secondPart[i];
                }
                else
                {
                    result[i] = firstPart[i - middle];
                }
            }
            return result;
        }

        public static int[] DoBubbleSort(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }

                }
            }
            return a;
        }


    }
}
