using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 задача (кол во отрицательных)
            int N = 0;
            for (int i = 1;i <= 10;i++)
            {
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (b1 < 0) { N += 1;}
            }
            Console.WriteLine("кол во отрицательных: " + N);

            // 2 задача (кол во элементов, оканчивающихся на 3)
            int N = 0;
            for (int i = 1;i <= 10;i++)
            {
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(b1) % 10 == 3) { N += 1;}
            }
            Console.WriteLine("кол во элементов, оканчивающихся на 3: " + N);

            // 3 задача (сумма элементов, которые в 3-ой и 5-ой системе оканчиваются одинакого)
            int N = 0;
            for (int i = 1; i <= 10; i++)
            {
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(b1) % 3 == Math.Abs(b1) % 5) { N += b1;}
            }
            Console.WriteLine("сумма элементов, которые в 3-ой и 5-ой системе оканчиваются одинакого: " + N);

            // 4 задача (произведение неотрицательных четных элементов)
            int N = 1;
            for (int i = 1; i <= 10; i++)
            {
                int b1 = Convert.ToInt32(Console.ReadLine());
                if ((Math.Abs(b1) % 2 == 0) & (b1 >= 0)) { N *= b1; }
            }
            if (N == 1) { N = 0; }
            Console.WriteLine("произведение неотрицательных четных элементов: " + N);

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
