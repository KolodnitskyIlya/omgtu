using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_задача_1_практика_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // для n вводимых элементов определить:
            
            //1 задача (Кол-во целых элементов, у которых имеется хотя бы одна цифра 3)           
             int N = 0;
            Console.Write("Введите кол-во чисел:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
             {
             int b1 = Convert.ToInt32(Console.ReadLine());
             while (Math.Abs(b1) > 0) 
             { 
                 if (Math.Abs(b1) % 10 == 3) 
                 { 
                     N += 1;
                     break;
                 } 
                 else
                 {
                     b1 = Math.Abs(b1) / 10;
                 }
             }
             }
             Console.WriteLine("Кол-во целых элементов, у которых имеется хотя бы одна цифра 3:" + N);
             

            //3 задача (кол-во элементов в записи которых 3,5 и 7 системе счисления оканчивается на одну и ту же цифру)           
            int b2,b3,b4;
            int N = 0;
            Console.Write("Введите кол-во чисел:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
            {
            int b1 = Convert.ToInt32(Console.ReadLine());
            b1 = Math.Abs(b1);
            b2 = b1 % 3;
            b3 = b1 % 5;
            b4 = b1 % 7;
            if ((b2 == b3) & (b2 == b4)) {N += 1;}
            }
            Console.WriteLine("Кол-во элементов в записи которых 3,5 и 7 системе счисления оканчивается на одну и ту же цифру:" + N);
            

            
            //2 задача (наименьший нечетный элемент)
            int min = 0;
            Console.Write("Введите кол-во чисел:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(b1) % 2 != 0) { min = b1; }
            for (int i = 0; i < n - 1; i++)
            {
                int b2 = Convert.ToInt32(Console.ReadLine());
                if (Math.Abs(b2) % 2 != 0)
                {
                    if (b2 < min)
                    {
                        min = b2;
                    }
                }              
            }
            Console.WriteLine("Наименьший нечетный элемент:" + min);
            
        }
    }
}
    

