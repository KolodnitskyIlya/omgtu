﻿//Дана последовательность из "n" пар элементов, из 
//каждой пары необходимо взять ровно одно число.
//Необходимо определить макс. возможную сумму элементов пар,
//кратную 3, если такую сумму получить невозможно, необходимо
//выдать сообщение (отриц. чисел нет)

using System;
class HelloWorld
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[] min_r1 = { Int32.MaxValue, Int32.MaxValue };
        int[] min_r2 = { Int32.MaxValue, Int32.MaxValue };
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            string[] pair = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(pair[0]);
            int n2 = Convert.ToInt32(pair[1]);
            int difference = Math.Abs(n1 - n2);

            if (difference % 3 == 1)
            {
                if (difference < min_r1[0])
                {
                    min_r1[0] = difference;
                }
                else if (difference < min_r1[1])
                {
                    min_r1[1] = difference;
                }
            }
            else if (difference % 3 == 2)
            {
                if (difference < min_r2[0])
                {
                    min_r2[0] = difference;
                }
                else if (difference < min_r2[1])
                {
                    min_r2[1] = difference;
                }
            }

            sum += Math.Max(n1, n2);
        }

        bool test1 = (min_r1[0] < Int32.MaxValue || min_r1[1] < Int32.MaxValue)
            || (min_r2[0] < Int32.MaxValue && min_r2[1] < Int32.MaxValue);
        bool test2 = (min_r2[0] < Int32.MaxValue || min_r2[1] < Int32.MaxValue)
            || (min_r1[0] < Int32.MaxValue && min_r1[1] < Int32.MaxValue);

        if (sum % 3 == 0)
        {
            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }
        else if (sum % 3 == 1 && test1)
        {
            int r1 = ((min_r1[0] < min_r1[1]) ? min_r1[0] : min_r1[1]);
            int min = r1;

            if (min_r2[0] < Int32.MaxValue && min_r2[1] < Int32.MaxValue)
            {
                int r2 = min_r2[0] + min_r2[0];
                min = (min < r2 ? min : r2);
            }

            if (min < Int32.MaxValue)
            {
                sum = sum - min;
            }

            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }
        else if (sum % 3 == 2 && test2)
        {
            int r2 = ((min_r2[0] < min_r2[1]) ? min_r2[0] : min_r2[1]);
            int min = r2;

            if (min_r1[0] < Int32.MaxValue && min_r1[1] < Int32.MaxValue)
            {
                int r1 = min_r1[0] + min_r1[0];
                min = (min < r1 ? min : r1);
            }

            if (min < Int32.MaxValue)
            {
                sum = sum - min;
            }

            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }

        else
        {
            Console.WriteLine("Такой суммы нет :(");
        }

    }
}