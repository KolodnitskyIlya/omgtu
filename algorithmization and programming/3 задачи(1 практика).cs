using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 задача (вводятся 2 числа a и b, в выводе присвоить a значение b и также b присвоить а)
            //(новые переменные добавлять нельзя)
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // 2 задача (вводится число в сек, перевести его в часы:минуты:секунды) (без %))
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 3600;
            int c = a / 3600;
            int g = a - (c * 3600);
            int n = g / 60;
            int m = g - (n * 60);
            Console.Write(c);
            Console.Write(':');
            Console.Write(n);
            Console.Write(':');
            Console.Write(m);

            // 3 задача (вводятся 2 переменные a и b. Найти min и max среди них)
            // (использовать только + - * / abs, без <>)
            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            a = (a + b) / 2;
            b = Math.Abs(b - a);
            float max = a + b;
            float min = a - b;
            Console.Write(min + " & ");
            Console.Write(max);
            
        }
    }
}
