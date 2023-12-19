using System;
class HelloWorld
{
    static double F(string Z) // функция для преобразования строковых элементов в вещественные числа
    {
        return Convert.ToDouble(Z); 
    }

    static void Main()
    {

        Console.WriteLine("Введите кол-во фирм:");
        int N = Convert.ToInt32(Console.ReadLine());
        int minI = 0; // счетчик для вычисления номера фирмы, у которой стоимость одного литра собственно молока минимальна
        double minsum = 2000; // счетчик для вычисления этой стоимости

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"{i} фирма");
            Console.WriteLine("Введите: 3 размера 1 упаковки, через пробел; 3 размера 2 упаковки, через пробел;цену 1 упаковки, через пробел; цену 2 упаковки, через пробел");

            string elements = Console.ReadLine();
            elements = elements.Replace('.', ','); //чтобы тип double нормально работал, заменим "." на ","
            string[] elements_1 = elements.Split();

            double[] elements_G = new double[8];
            for (int j = 0; j < 8; j++)
            {
                elements_G[j] = F(elements_1[j]);
            }

            Console.WriteLine();

            Console.WriteLine("Площадь полной поверхности 1 упаковки"); // S п.п. = 2(ab + bc + ac)
            double r1 = 2 * (elements_G[0] * elements_G[1] + elements_G[0] * elements_G[2] + elements_G[1] * elements_G[2]);
            Console.WriteLine(r1);

            Console.WriteLine("Объем молока 1 упаковки"); // V = a * b * c
            double o1 = (elements_G[0] * elements_G[1] * elements_G[2]) / 1000;
            Console.WriteLine(o1);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Площадь полной поверхности 2 упаковки");
            double r2 = 2 * (elements_G[3] * elements_G[4] + elements_G[3] * elements_G[5] + elements_G[4] * elements_G[5]);
            Console.WriteLine(r2);

            Console.WriteLine("Объем молока 2 упаковки");
            double o2 = (elements_G[3] * elements_G[4] * elements_G[5]) / 1000;
            Console.WriteLine(o2);

            Console.WriteLine($"Cтоимость одного литра собственно молока {i} фирмы");
            double l = (r2 * elements_G[6] - r1 * elements_G[7]) / (o1 * r2 - r1 * o2); // из двух уравнений выражаем l - стоимость одного литра собственно молока
            Console.WriteLine("{0:0.00}", l);


            if (l <= minsum) // поиск минимальной цены
            {
                minsum = l;
                minI = i;
            }
        }

        Console.WriteLine("----------------------------------");
        Console.WriteLine("Номер фирмы, у которой стоимость одного литра собственно молока минимальна, а также эта стоимость в рублях");
        Console.Write($"{minI} ");
        Console.WriteLine("{0:0.00}", minsum);

    }
}