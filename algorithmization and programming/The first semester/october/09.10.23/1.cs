/*** Дано k мышек из них одна белая. Мышки сидят по кругу. 
 * Кот начинает съедать каждую m-ную мышку. Необходимо 
 * определить с какой мышки кот должен съедать каждую 
 * m-ную мышку, чтобы осталась одна белая     ***/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите кол-во мышек:");
        int cnt_mice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите позицию белой мышки:");
        int white_mouse = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите диапазон съедения:");
        int eating_range = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Номера мышек");
        int[] array_cnt_mice = new int[cnt_mice];
        for (int ig = 0, j = 1; ig < cnt_mice; ig++, j++)
        {
            array_cnt_mice[ig] = j;
            Console.WriteLine(array_cnt_mice[ig]);
        }

        Console.WriteLine("-------------------------------");

        int cnt = 0; // идем по циклу пока не останется 1 мышка
        int i = 0; // какую мышку съедаем

        while (cnt != cnt_mice - 1)
        {
            for (int j = 0; j <= eating_range; j++)
            {

                //условие чтобы мышку, которую только съели сразу не брать в счет
                if (array_cnt_mice[i] == 0 && j != 0)
                {
                    i++;
                    j--;
                    continue;
                }

                //условие чтобы съедали каждую eating_range мышку начиная от 1
                if (j >= eating_range)
                {
                    array_cnt_mice[i] = 0;
                    break;
                }

                //условие чтобы не ушли за границы массива
                if (i >= cnt_mice - 1)
                {
                    i = 0;
                }

                else
                {
                    i++;
                }
            }

            // выводим всех мышек
            for (int k = 0; k < cnt_mice; k++)
            {
                Console.WriteLine(array_cnt_mice[k]);
            }
            Console.WriteLine("-------------------------------");

            cnt++;
        }

        // ищем мышку которая осталась
        for (int k = 0; k < cnt_mice; k++)
        {
            if (array_cnt_mice[k] != 0)
            {
                i = k;
            }
        }

        if (eating_range < cnt_mice)
        {
            if (i + 1 == white_mouse)
            {
                Console.WriteLine("Кот должен начать съедать с 1 мышки");
            }

            else if (i + 1 < white_mouse)
            {
                Console.WriteLine($"Кот должен начать съедать с {white_mouse - i} мышки");
            }

            else
            {
                Console.WriteLine($"Кот должен начать съедать с {white_mouse + (i - white_mouse)} мышки");
            }
        }

        else
        {
            if (i + 1 == white_mouse)
            {
                Console.WriteLine("Кот должен начать съедать с 1 мышки");
            }

            else if (i + 1 > white_mouse)
            {
                Console.WriteLine($"Кот должен начать съедать с {white_mouse + (i - white_mouse)} мышки");
            }

            else
            {
                Console.WriteLine($"Кот должен начать съедать с {white_mouse + (i - white_mouse)} мышки");
            }
        }

    }
}