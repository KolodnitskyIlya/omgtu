using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace новый_язык_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //для первых четырех задачи используем одно условие
            // вводим 10 элементов
            int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10;
            int N = 0;
            int N1 = 0;
            int N2 = 0;
            int N3 = 1;
            b1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            b3 = Convert.ToInt32(Console.ReadLine());
            b4 = Convert.ToInt32(Console.ReadLine());
            b5 = Convert.ToInt32(Console.ReadLine());
            b6 = Convert.ToInt32(Console.ReadLine());
            b7 = Convert.ToInt32(Console.ReadLine());
            b8 = Convert.ToInt32(Console.ReadLine());
            b9 = Convert.ToInt32(Console.ReadLine());
            b10 = Convert.ToInt32(Console.ReadLine());

            // 1 задача (кол во отрицательных)
            if (b1 < 0) { N += 1; }
            if (b2 < 0) { N += 1; }
            if (b3 < 0) { N += 1; }
            if (b4 < 0) { N += 1; }
            if (b5 < 0) { N += 1; }
            if (b6 < 0) { N += 1; }
            if (b7 < 0) { N += 1; }
            if (b8 < 0) { N += 1; }
            if (b9 < 0) { N += 1; }
            if (b10 < 0) { N += 1; }
            Console.WriteLine("кол во отрицательных: " + N);

            // 2 задача (кол во элементов, оканчивающихся на 3)
            if (Math.Abs(b1) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b2) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b3) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b4) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b5) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b6) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b7) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b8) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b9) % 10 == 3) { N1 += 1; }
            if (Math.Abs(b10) % 10 == 3) { N1 += 1; }
            Console.WriteLine("кол во элементов, оканчивающихся на 3: " + N1);

            // 3 задача (сумма элементов, которые в 3-ой и 5-ой системе оканчиваются одинакого)
            if (Math.Abs(b1) % 3 == Math.Abs(b1) % 5) { N2 += b1; }
            if (Math.Abs(b2) % 3 == Math.Abs(b2) % 5) { N2 += b2; }
            if (Math.Abs(b3) % 3 == Math.Abs(b3) % 5) { N2 += b3; }
            if (Math.Abs(b4) % 3 == Math.Abs(b4) % 5) { N2 += b4; }
            if (Math.Abs(b5) % 3 == Math.Abs(b5) % 5) { N2 += b5; }
            if (Math.Abs(b6) % 3 == Math.Abs(b6) % 5) { N2 += b6; }
            if (Math.Abs(b7) % 3 == Math.Abs(b7) % 5) { N2 += b7; }
            if (Math.Abs(b8) % 3 == Math.Abs(b8) % 5) { N2 += b8; }
            if (Math.Abs(b9) % 3 == Math.Abs(b9) % 5) { N2 += b9; }
            if (Math.Abs(b10) % 3 == Math.Abs(b10) % 5) { N2 += b10; }
            Console.WriteLine("сумма элементов, которые в 3-ой и 5-ой системе оканчиваются одинакого: " + N2);

            // 4 задача (произведение неотрицательных четных элементов)
            if ((b1 >= 0) & (b1 % 2 == 0)) { N3 *= b1; }
            if ((b2 >= 0) & (b2 % 2 == 0)) { N3 *= b2; }
            if ((b3 >= 0) & (b3 % 2 == 0)) { N3 *= b3; }
            if ((b4 >= 0) & (b4 % 2 == 0)) { N3 *= b4; }
            if ((b5 >= 0) & (b5 % 2 == 0)) { N3 *= b5; }
            if ((b6 >= 0) & (b6 % 2 == 0)) { N3 *= b6; }
            if ((b7 >= 0) & (b7 % 2 == 0)) { N3 *= b7; }
            if ((b8 >= 0) & (b8 % 2 == 0)) { N3 *= b8; }
            if ((b9 >= 0) & (b9 % 2 == 0)) { N3 *= b9; }
            if ((b10 >= 0) & (b10 % 2 == 0)) { N3 *= b10; }
            if (N3 == 1) { N3 = 0; }
            Console.WriteLine("произведение неотрицательных четных элементов: " + N3);

            // 5 - 7 задачу проверяем по отдельности

            // 5 задача(кол-во элементов, значения которых меньше предыдущего)
            int b1;
            int Z = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++, b = b1)
            {
                b1 = Convert.ToInt32(Console.ReadLine());
                if (b1 < b) { Z += 1; }
            }
            Console.WriteLine("кол-во элементов, значения которых меньше предыдущего:" + Z);

            // 7 задача(кол-во смены знаков последовательности)
            int b1;
            int Z = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++, b = b1)
            {
                b1 = Convert.ToInt32(Console.ReadLine());
                if ((((b1 * -1) < 0) & ((b * -1) > 0)) | (((b1 * -1) > 0) & ((b * -1) < 0))) { Z += 1; }
            }
            Console.WriteLine("кол-во смены знаков последовательности:" + (Z));

            // 6 задача(кол-во элементов, значения которых меньше всех предыдущих)
            int b1;
            int mn;
            int Z = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            mn = b;
            for (int i = 1; i <= n - 1; i++)
            {
                b1 = Convert.ToInt32(Console.ReadLine());
                if (b1 < mn) { Z += 1; mn = b1; }
                else { mn = mn; }
            }
            Console.WriteLine("кол-во элементов, значения которых меньше всех предыдущих:" + Z);
        }
    }
}
