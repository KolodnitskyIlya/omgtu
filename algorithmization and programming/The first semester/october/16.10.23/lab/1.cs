using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Дано n - строк, m - столбцов.

        Console.WriteLine("Введите кол-во строк:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[n, m];
        Console.WriteLine("Введите числа в массив:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1 + " строка:");
            for (int j = 0; j < m; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------");
        }

        Console.WriteLine("---------------------------------------");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("---------------------------------------");


        //1 задача(кол-во столбцов, в которых сумма отрицательна, а произведение положительно)
        int cnt1_sum;
        int cnt1_przv;
        int cnt1 = 0;
        for (int i = 0; i < m; i++)
        {
            cnt1_sum = 0;
            cnt1_przv = 1;
            for (int j = 0; j < n; j++)
            {
                cnt1_sum += array[j, i];
                cnt1_przv *= array[j, i];
            }
            if (cnt1_sum < 0 && cnt1_przv > 0)
            {
                cnt1++;
            }
        }
        Console.WriteLine("1)кол-во столбцов, в которых сумма отрицательна, а произведение положительно: " + cnt1);


        //2 задача(кол-во строк, в которых мин. элемент четный)
        int min;
        int cnt2 = 0;
        for (int i = 0; i < n; i++)
        {
            min = array[i, 0];
            for (int j = 1; j < m; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i,j];
                }
            }
            if (min % 2 == 0)
            {
                cnt2++;
            }
        }
        if (cnt2 == n)
        {
            Console.WriteLine("2)кол-во строк, в которых мин. элемент четный: " + cnt2 + ". Да, во всех строках мин. элемент четный");
        }
        else
        {
            Console.WriteLine("2)кол-во строк, в которых мин. элемент четный: " + cnt2 + ". Нет, не во всех строках мин. элемент четный");
        }


        //3 задача(кол-во ненулевых элементов в массиве)
        int cnt3 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (array[i, j] != 0)
                {
                    cnt3++;
                }
            }  
        }
        Console.WriteLine("3)кол-во ненулевых элементов в массиве: " + cnt3);


        //4 задача(определить в каждом столбце наиб. четный элемент)
        Console.WriteLine("4)");
        int max;
        for (int j = 0; j < m; j++)
        {
            max = array[0, j];
            for (int i = 1; i < n; i++)
            {
                if (max % 2 != 0)
                {
                    max = array[i, j];
                }
                else if (array[i, j] > max && array[i, j] % 2 == 0)
                {
                    max = array[i, j]; 
                }
            }
            if (max % 2 == 0)
            {
                Console.WriteLine("Наибольший четный элемент " + (j + 1) + " столбца: " + max);
            }
            else
            {
                Console.WriteLine("Наибольшего четного элемента в " + (j + 1) + " столбце нету");
            }

        }


        //5 задача(определить кол-во пар строк, состоящих их одинаковых элементов)
        int cnt4g = 0;
        for (int i = 0; i < n; i++)
        {   
            for (int i1 = i+1; i1 < n; i1++)
            {

                int c = 0; //сумма элементов i - й строки
                int sum5g = 0;
                while (c < m)
                {
                    sum5g += array[i, c];
                    c++;
                }

                int c1 = 0;  //сумма элементов (i + 1) - й строки
                int sum5 = 0;
                while (c1 < m)
                {
                    sum5 += array[i1, c1];
                    c1++;
                }

                int cnt4 = 0;
                for (int j = 0; j < m; j++)
                {

                    int sr = array[i, j];

                    for (int j1 = 0; j1 < m; j1++)
                    {
                        if (sr == array[i1, j1])
                        {
                            cnt4++;
                            break;                   
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (cnt4 == m && sum5 == sum5g)
                {
                    cnt4g++;
                }
            }
        }
        Console.WriteLine("5)кол-во пар строк, состоящих их одинаковых элементов: " + cnt4g);

        Console.WriteLine();

        Console.WriteLine("ПРИМЕР 5 ЗАДАЧИ");
        int[,] pr = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(pr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("кол - во пар строк:");
        for (int i = 1; i <= 3; i++)
        {
            for (int j = i + 1; j <= 3; j++)
            {
                Console.Write(i + "-" + j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Ответ: 3");
    }
}