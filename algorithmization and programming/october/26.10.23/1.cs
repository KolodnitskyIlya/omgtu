/**    Задано N множеств элементов.
 Необходимо сформировать одномерные массивы, которые хранят:
 1. Пересечение всех множеств
 2. Объединение всех множеств
 3. Дополнение для каждого множества относительно объединения     **/

using System;
class HelloWorld
{
    static int[] array_1(int[] array)
    {
        int[] sorted = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int min = 1000000000;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            sorted[i] = min;
        }

        return sorted;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] GR = new int[n][];
        int length = 0;

        for (int i = 0; i < n; i++)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            length += m;
            GR[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                GR[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] U = new int[length];
        int countUnion = 0;

        Console.WriteLine("Массивы:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < GR[i].Length; j++)
            {
                Console.Write($"{GR[i][j].ToString().PadLeft(5, ' ')} ");
                if (!U.Contains(GR[i][j]))
                {
                    U[countUnion] = GR[i][j];
                    countUnion++;
                }
            }
            Console.WriteLine();
        }

        U = new int[countUnion];
        int pointer = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < GR[i].Length; j++)
            {
                if (!U.Contains(GR[i][j]))
                {
                    U[pointer] = GR[i][j];
                    pointer++;
                }
            }
        }

        U = array_1(U);

        int[] intersections = new int[U.Length];
        int countIntersection = 0;
        for (int i = 0; i < intersections.Length; i++)
        {
            intersections[i] = 0;
        }

        for (int k = 0; k < U.Length; k++)
        {
            for (int i = 0; i < n; i++)
            {
                if (GR[i].Contains(U[k]))
                {
                    intersections[k]++;
                }
            }
        }

        for (int i = 0; i < intersections.Length; i++)
        {
            if (intersections[i] == n)
            {
                countIntersection++;
            }
        }

        int[] intersection = new int[countIntersection];
        pointer = 0;
        for (int i = 0; i < intersections.Length; i++)
        {
            if (intersections[i] == n)
            {
                intersection[pointer] = U[i];
                pointer++;
            }
        }

        Console.WriteLine("Пересечение всех множеств:");
        if (countIntersection > 0)
        {
            foreach (int item in intersection)
            {
                Console.Write($"{item} ");
            }
        }
        else
        {
            Console.Write("Пусто!");
        }
        Console.WriteLine();

        Console.WriteLine("Объединение всех множеств:");
        if (countUnion > 0)
        {
            foreach (int item in U)
            {
                Console.Write($"{item} ");
            }
        }
        else
        {
            Console.Write("Пусто!");
        }
        Console.WriteLine();

        Console.WriteLine("Дополнение для каждого множества относительно объединения:");
        for (int i = 0; i < n; i++)
        {
            int flag = 0;
            Console.Write($"{i}:\t");
            for (int k = 0; k < U.Length; k++)
            {
                if (!GR[i].Contains(U[k]))
                {
                    Console.Write("{0} ", U[k]);
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.Write("Пусто!");
            }
            Console.WriteLine();
        }
    }
}