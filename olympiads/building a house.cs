using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите девять целых чисел X, Y, L, С1, C2, С3, С4, С5, С6, разделенных пробелами:");
        string [] numbers = Console.ReadLine().Split(" ");

        Console.WriteLine();

        Console.WriteLine($"Дом с основанием в виде прямоугольника размером: {(numbers[0])} х {(numbers[1])}");
        Console.WriteLine($"Длина уцелевшей стены: {(numbers[2])}");
        Console.WriteLine($"Ремонт погонного метра уцелевшей стены, для использования ее в новом доме: {(numbers[3])}");
        Console.WriteLine($"Разбор погонного метра уцелевшей стены: {(numbers[4])}");
        Console.WriteLine($"Строительство погонного метра из материала, полученного при разборе стены: {(numbers[5])}");
        Console.WriteLine($"Строительство погонного метра из нового материала: {(numbers[6])}");
        Console.WriteLine($"Стоимость погонного метра нового материала: {(numbers[7])}");
        Console.WriteLine($"Вывоз на свалку погонного метра материала, образованного при разборе стены: {(numbers[8])}");

        // 1 случай (полностью разрушаем стену и вывозим ее на свалку - то есть, дом будет из нового материала)

        int dump = (Convert.ToInt32(numbers[2]) * Convert.ToInt32(numbers[4])) + (Convert.ToInt32(numbers[2]) * Convert.ToInt32(numbers[8]));

        int meters = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2;

        int price_1 = meters * Convert.ToInt32(numbers[7]) + meters * Convert.ToInt32(numbers[6]);

        int sum_1 = dump + price_1;

        // вводим макс суммы для дальнейшей проверки

        int sum_2 = 10000000;
        int sum_3 = 10000000;
        int sum_5 = 1000000;
        int sum_6 = 10000000;
        int sum_7 = 10000000;
        int sum_8 = 10000000;
        int sum_9 = 10000000;
        int sum_10 = 10000000;
        int sum_11 = 10000000;

        // 2.1 случай (вся длина стен должна быть больше либо равна длине исходной стены. Y <= L. стену Y восстанавливаем, остальное строим из нового материала, оставшееся L разбираем и из него снова строим)
        if (Convert.ToInt32(numbers[1]) <= Convert.ToInt32(numbers[2]) && ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 >= Convert.ToInt32(numbers[2])))
        {
            int difference_1 = Convert.ToInt32(numbers[2]) - Convert.ToInt32(numbers[1]);

            int repair_1 = Convert.ToInt32(numbers[1]) * Convert.ToInt32(numbers[3]);

            int renovated_1 = difference_1 * Convert.ToInt32(numbers[4]) + difference_1 * Convert.ToInt32(numbers[5]);

            int remaining_walls_1 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[1]) - difference_1;

            int price_2 = remaining_walls_1 * Convert.ToInt32(numbers[7]) + remaining_walls_1 * Convert.ToInt32(numbers[6]);

            sum_2 = repair_1 + renovated_1 + price_2;

        }

        // 2.2 случай (вся длина стен должна быть больше либо равна длине исходной стены. X <= L. стену X восстанавливаем, остальное строим из нового материала, оставшееся L разбираем и из него снова строим)
        if (Convert.ToInt32(numbers[0]) <= Convert.ToInt32(numbers[2]) && ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 >= Convert.ToInt32(numbers[2])))
        {
            int difference_2 = Convert.ToInt32(numbers[2]) - Convert.ToInt32(numbers[0]);

            int repair_2 = Convert.ToInt32(numbers[0]) * Convert.ToInt32(numbers[3]);

            int renovated_2 = difference_2 * Convert.ToInt32(numbers[4]) + difference_2 * Convert.ToInt32(numbers[5]);

            int remaining_walls_2 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[0]) - difference_2;

            int price_3 = remaining_walls_2 * Convert.ToInt32(numbers[7]) + remaining_walls_2 * Convert.ToInt32(numbers[6]);

            sum_3 = repair_2 + renovated_2 + price_3;

        }

        // 2.4 случай (если L <= X и L <= Y. L восстанавливаем. все остальное строим из нового материала)

        if (Convert.ToInt32(numbers[2]) <= Convert.ToInt32(numbers[1]) && Convert.ToInt32(numbers[2]) <= Convert.ToInt32(numbers[0]))
        {
            int repair_4 = Convert.ToInt32(numbers[2]) * Convert.ToInt32(numbers[3]);

            int remaining_walls_4 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[2]);

            int price_5 = remaining_walls_4 * Convert.ToInt32(numbers[7]) + remaining_walls_4 * Convert.ToInt32(numbers[6]);

            sum_5 = repair_4 + price_5;

        }

        // 3.1 случай (вся длина стен должна быть больше либо равна длине исходной стены. Y восстанавливаем. оставшееся L вывозим на свалку. остальное строим из нового материала)

        if (Convert.ToInt32(numbers[1]) <= Convert.ToInt32(numbers[2]) && ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 >= Convert.ToInt32(numbers[2])))
        {

            int difference_4 = Convert.ToInt32(numbers[2]) - Convert.ToInt32(numbers[1]);

            int repair_5 = Convert.ToInt32(numbers[1]) * Convert.ToInt32(numbers[3]);

            int dump_1 = difference_4 * Convert.ToInt32(numbers[4]) + difference_4 * Convert.ToInt32(numbers[8]);

            int remaining_walls_5 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[1]);

            int price_6 = remaining_walls_5 * Convert.ToInt32(numbers[7]) + remaining_walls_5 * Convert.ToInt32(numbers[6]);

            sum_6 = repair_5 + dump_1 + price_6;

        }

        // 3.2 случай (вся длина стен должна быть больше либо равна длине исходной стены. X восстанавливаем. оставшееся L вывозим на свалку. остальное строим из нового материала)

        if (Convert.ToInt32(numbers[0]) <= Convert.ToInt32(numbers[2]) && ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 >= Convert.ToInt32(numbers[2])))
        {
            int difference_5 = Convert.ToInt32(numbers[2]) - Convert.ToInt32(numbers[0]);

            int repair_6 = Convert.ToInt32(numbers[0]) * Convert.ToInt32(numbers[3]);

            int dump_2 = difference_5 * Convert.ToInt32(numbers[4]) + difference_5 * Convert.ToInt32(numbers[8]);

            int remaining_walls_6 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[0]);

            int price_7 = remaining_walls_6 * Convert.ToInt32(numbers[7]) + remaining_walls_6 * Convert.ToInt32(numbers[6]);

            sum_7 = repair_6 + dump_2 + price_7;

        }

        //4 случай (вся длина стен должна быть больше либо равна длине исходной стены. разбираем L и строим из нее новые стены. все остальное тоже из нового материала)
        if ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 >= Convert.ToInt32(numbers[2]))
        {
            int destroy = Convert.ToInt32(numbers[2]) * Convert.ToInt32(numbers[4]);

            int meters_1 = Convert.ToInt32(numbers[2]) * Convert.ToInt32(numbers[5]);

            int remaining_walls_7 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[2]);

            int price_8 = remaining_walls_7 * Convert.ToInt32(numbers[7]) + remaining_walls_7 * Convert.ToInt32(numbers[6]);

            sum_8 = destroy + meters_1 + price_8;

        }

        // 5.1 случай (вся длина стен должна быть меньше длины исходной стены. ненужное L вывозим на свалку. X ремонтируем. остальное разбираем и строем из этого новые стены.)

        if ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 < Convert.ToInt32(numbers[2]))
        {

            int destroy_1 = Convert.ToInt32(numbers[2]) - ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2);

            int destroy_1_price = destroy_1 * Convert.ToInt32(numbers[4]) + destroy_1 * Convert.ToInt32(numbers[8]);

            int meters_2_1 = Convert.ToInt32(numbers[0]) * Convert.ToInt32(numbers[3]);

            int meters_2_2 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[0]);

            int razn_1 = meters_2_2 * Convert.ToInt32(numbers[4]) + meters_2_2 * Convert.ToInt32(numbers[5]);

            sum_9 = destroy_1_price + meters_2_1 + razn_1;

        }

        // 5.2 случай (вся длина стен должна быть меньше длины исходной стены. ненужное L вывозим на свалку. Y ремонтируем. остальное разбираем и строем из этого новые стены)

        if ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 < Convert.ToInt32(numbers[2]))
        {

            int destroy_2 = Convert.ToInt32(numbers[2]) - ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2);

            int destroy_2_price = destroy_2 * Convert.ToInt32(numbers[4]) + destroy_2 * Convert.ToInt32(numbers[8]);

            int meters_3_1 = Convert.ToInt32(numbers[1]) * Convert.ToInt32(numbers[3]);

            int meters_3_2 = (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])) * 2 - Convert.ToInt32(numbers[1]);

            int razn_2 = meters_3_2 * Convert.ToInt32(numbers[4]) + meters_3_2 * Convert.ToInt32(numbers[5]);

            sum_10 = destroy_2_price + meters_3_1 + razn_2;

        }

        //5.3 случай (вся длина стен должна быть меньше длины исходной стены. ненужное L вывозим на свалку. всю длину стен разбираем и строем из этого новые стены)

        if ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2 < Convert.ToInt32(numbers[2]))
        {

            int destroy_3 = Convert.ToInt32(numbers[2]) - ((Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[0])) * 2);

            int destroy_3_price = destroy_3 * Convert.ToInt32(numbers[4]) + destroy_3 * Convert.ToInt32(numbers[8]);

            int meters_4_1 = Convert.ToInt32(numbers[2]) - destroy_3;

            int razn_3 = meters_4_1 * Convert.ToInt32(numbers[4]) + meters_4_1 * Convert.ToInt32(numbers[5]);

            sum_11 = destroy_3_price + razn_3;

        }

        Console.WriteLine();
        Console.WriteLine("Минимальная сумма (в руб.), которую необходимо потратить на строительство стен нового дома:");
        Console.WriteLine(Math.Min(Math.Min(Math.Min(Math.Min(sum_1, sum_2), Math.Min(Math.Min(sum_6, sum_7), sum_3)),Math.Min(Math.Min(sum_8,sum_5), Math.Min(sum_9, sum_10))), sum_11));
    
    }
}