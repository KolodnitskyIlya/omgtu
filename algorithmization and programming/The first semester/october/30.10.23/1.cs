/***      На вход подается n серых и m белых мышек.
 k - съедаем. N1 серых должно остаться. 
M1 остаток белых. Выходим только с серой. 
Необходимо рассадить мышек таким образом, что при исходных данных 
остались мышки в том кол-ве, в котором было задано кол-во. 
Рассадки могут быть разными.       ***/

using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во серых мышей");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кол-во белых мышей");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите диапазон съедения мышей");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Остаток серых мышей");
        int N1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Остаток белых мышей");
        int M1 = Convert.ToInt32(Console.ReadLine());

        int sum = N1 + M1;

        int[] mice = new int[n + m];
        for (int i = 0; i < mice.Length; i++)
        {
            mice[i] = 1;
        }

        int cnt = 0;

        while (mice.Count(c => c == 1) > sum)
        {
            int moved = 0;

            while (moved != k)
            {
                ++cnt;

                if (cnt > mice.Length - 1)
                {
                    cnt = 0;
                }

                if (mice[cnt] == 1)
                {
                    ++moved;
                }
            }

            mice[cnt] = 0;
        }

        int p_n = 0, p_m = 0, placed_alive_n = 0, placed_alive_m = 0;

        if (n - N1 == 0 || m - M1 == 0)
        {
            Console.WriteLine("Мышек так расположить не получится");
        }
        else
        {
            for (int i = 0; i < mice.Length; i++)
            {
                if (mice[i] == 0)
                {
                    if (p_n < n - N1)
                    {
                        Console.WriteLine("Серая");
                        p_n++;
                    }
                    else if (p_m < m - M1)
                    {
                        Console.WriteLine("Белая");
                        p_m++;
                    }
                }
                else if (mice[i] == 1)
                {
                    if (placed_alive_n < N1)
                    {
                        Console.WriteLine("Серая");
                        placed_alive_n++;
                    }
                    else if (placed_alive_m < 1)
                    {
                        Console.WriteLine("Белая");
                        placed_alive_m++;
                    }
                }
            }
        }
    }
}