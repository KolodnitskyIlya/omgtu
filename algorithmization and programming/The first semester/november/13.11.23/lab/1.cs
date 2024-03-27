/**** Дан двумерный массив mxn, необходимо:
 1. Определить в каждой строке максимальный отрицательный элемент
 2. Определить в каждом столбце кол-во элементов, отличных от минимального
 элемента массива
 3. Заменить элементы строки с наибольшей суммой четных элементов на
 единички, если таких строк несколько, заменить в каждой строке элементы
 Ограничения: ввод массива делать в отдельной функции
 ****/

using System;
class HelloWorld
{
    static void M(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        int max = getLongestElement(array);
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    Console.Write('[');
                }

                Console.Write($"{Convert.ToString(array[i, j]).PadLeft(max, ' ')}");

                if (j != n - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(']');
                }

            }

            Console.WriteLine();
        }
    }

    public static int getLongestElement(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        int length = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Convert.ToString(array[i, j]).Length > length)
                {
                    length = Convert.ToString(array[i, j]).Length;
                }
            }
        }

        return length;
    }

    public static int[,] populateArray(int m, int n)
    {
        int[,] array = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return array;
    }

    public static int[,] Transpose(int[,] array, int rows, int cols)
    {
        int[,] t = new int[cols, rows];
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                t[i, j] = array[j, i];
            }
        }

        return t;
    }

    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = populateArray(m, n);

        int[] sum = new int[m];
        for (int i = 0; i < m; i++)
        {
            sum[i] = 0;
        }

        int[] maxNegatives = new int[m];

        int min_cnt = 10000000;

        for (int i = 0; i < m; i++)
        {
            int maxRowNegative = 0;

            for (int j = 0; j < n; j++)
            {
                int cnt = array[i, j];

                if (cnt % 2 == 0)
                {
                    sum[i] += cnt;
                }

                if (cnt < 0 && (cnt != 0 || cnt > maxRowNegative))
                {
                    maxRowNegative = cnt;
                }

                if (cnt < min_cnt)
                {
                    min_cnt = cnt;
                }
            }

            maxNegatives[i] = maxRowNegative;
        }

        int[] colsDiffFromMin = new int[n];
        for (int i = 0; i < n; i++)
        {
            colsDiffFromMin[i] = 0;
        }

        int[,] t = Transpose(array, m, n);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (t[i, j] != min_cnt)
                {
                    colsDiffFromMin[i]++;
                }
            }
        }

        Console.WriteLine("Двумерный массив:");
        M(array);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Транспонированный двумерный массив:");
        M(t);
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Максимальный отрицательный элемент каждой строки:");
        for (int i = 0; i < maxNegatives.Length; i++)
        {
            if (maxNegatives[i] == 0)
            {
                Console.WriteLine($"{i + 1}: такого элемента нет");
            }
            else
            {
                Console.WriteLine($"{i + 1}: {maxNegatives[i]}");
            }
        }

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Кол-во элементов каждого столбца, отличных от минимального элемента массива:");
        for (int i = 0; i < colsDiffFromMin.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {colsDiffFromMin[i]}");
        }

        int maxEvenSum = sum.Max();
        int[] maxsumIndexes = new int[1 + sum.Count(x => x == maxEvenSum)];

        int pointer = 0;

        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] == maxEvenSum)
            {
                maxsumIndexes[pointer] = i;
                pointer++;
            }
        }

        int[,] onesMatrix = array.Clone() as int[,];

        pointer = 0;
        for (int i = 0; i < m; i++)
        {
            if (maxsumIndexes[pointer] == i)
            {
                for (int j = 0; j < n; j++)
                {
                    onesMatrix[i, j] = 1;
                }
                pointer++;
            }
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Массив элементы строк с наибольшей суммой четных чисел которого - единички:");
        M(onesMatrix);
    }
}