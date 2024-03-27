/*** Есть посл городов, каждый город характеризуется расстоянием
от нач точки (1 город - и есть начало(0)). Надо определить в каком месте
между городами расположить заправку, чтобы расстояние было не <= n, и 
чтобы сумма расстояний от каждого города была min ***/

using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите количество городов: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите мин растояние до города: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите растояния до городов: ");
        int[] cities = new int[k];
        cities[0] = 0;
        for (int i = 1; i < k; i++)
        {
            cities[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(String.Join(",", cities));

        // проверка
        bool prov = false;
        string min_sum = "Nothing ";
        for (int i = 1; i < cities[^1]; ++i)
        {

            for (int h = 0; h < k; ++h)
            {

                if (Math.Abs(cities[h] - i) >= n)
                {
                    prov = true;
                }
                else
                {
                    prov = false;
                    break;
                }
            }
            if (prov)
            {
                int sum = 0;
                for (int j = 0; j < k; ++j)
                {
                    sum += Math.Abs(cities[j] - i);
                }
                min_sum += Convert.ToString(i) + " " + Convert.ToString(sum) + ", ";

            }
        }
        Console.WriteLine(min_sum);
    }
}