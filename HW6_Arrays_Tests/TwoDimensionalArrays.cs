namespace TwoDimensionalArrays
{
    public class TwoDimensionalArray
    {

        public static int[,] GenerateArray(int x, int y)
        {
            Random random = new Random();
            int[,] a = new int[x, y];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(-100, 100);
                }
            }

            return a;
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Copy(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Сan't be zero");
            }

            int[,] arrayCopy = new int[a.GetLength(0), a.GetLength(1)];
            Array.Copy(a, arrayCopy, a.Length);
            return arrayCopy;
        }

        public static int FindMinElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("can't be zero");
            }

            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }
                }
            }
            return min;
        }

        public static int FindMaxElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("can't be zero");
            }

            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }

        public static int[] FindIndexOfMaxElement(int[,] a)
        {
            int[] index = new int[2] { 0, 0 };
            if (a.Length == 0)
            {
                throw new Exception("can't be zero");
            }

            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        index = new int[2] { i, j };
                    }
                }
            }
            return index;
        }

        public static int[] FindIndexOfMinElement(int[,] a)
        {
            int[] index = new int[2] { 0, 0 };
            if (a.Length == 0)
            {
                throw new Exception("can't be zero");
            }

            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        index = new int[2] { i, j };
                    }
                }
            }
            return index;
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static int FindNumberOfTheBiggestElementAroundNeighbours(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("can't be zero");
            }

            int counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i == 0 || a[i, j] > a[i - 1, j])
                        && (i == a.GetLength(0) - 1 || a[i, j] > a[i + 1, j])
                        && (j == 0 || a[i, j] > a[i, j - 1])
                        && (j == a.GetLength(1) - 1 || a[i, j] > a[i, j + 1]))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        //Отразите массив относительно его главной диагонали (на вход приходит квадрат)
        public static int[,] CreateMirrorByMainDiagonal(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Сan't be zero");
            }
            if (a.GetLength(0) != a.GetLength(1))
            {
                throw new Exception("Should be a square");
            }
            int[,] copyA = Copy(a);
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = i; j < a.GetLength(0); j++)
                {
                    int tmp = copyA[i, j];
                    copyA[i, j] = copyA[j, i];
                    copyA[j, i] = tmp;
                }
            }
            return copyA;
        }
    }
}
