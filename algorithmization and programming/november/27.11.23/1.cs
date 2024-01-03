using System.Reflection.Metadata;
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во интервалов:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите длину схода вниз:");
        int t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-------------------------------------");

        int sum_a = 0; //сумматор "a" интервалов
        int sum_b = 0; //сумматор "a" интервалов
        long sum = Convert.ToInt64(Math.Pow(10, 12));

        int c = 0; //счетчик для sum(чтобы не считал первый "b" интервал)


        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine($"{i}-й интервал");

            Console.Write($"a{i}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"b{i}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            if (c == 1) //проверка для sum(чтобы не считал первый "b" интервал)
            {
                sum += b;
            }

            sum_a += a; //суммирует верхние интервалы
            sum_b += b; //суммирует нижние интервалы

            if (sum_a <= sum) // переход на нижний интервал 
            {
                sum = sum_a;
                c = 1;
            }

        }
        Console.WriteLine($"Минимальная сумма равна: {Math.Min(Math.Min(sum_a, sum_b), sum) + t}");
    }
}





