using System;
class HelloWorld
{

    static int how_many_days_are_there_in_a_month(int month, int year) // функция которая возращает кол-во дней в месяце
    {
        if (year % 4 != 0)
        {
            switch (month)
            {
                case 1: return 31;
                case 2: return 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
        }
        else // високосный год
        {
            switch (month)
            {
                case 1: return 31;
                case 2: return 29;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
        }

    }

    static void Main()
    {

        Console.WriteLine("Введите дату начала периода в формате ДД.ММ.ГГГГ");
        string the_beginning_of_the_period = Console.ReadLine();

        string[] the_beginning_of_the_period_array = the_beginning_of_the_period.Split('.', ' ');
        int[] The_beginning_of_the_period = new int[3];

        for (int i = 0; i < 3; i++)
        {
            The_beginning_of_the_period[i] = Convert.ToInt32(the_beginning_of_the_period_array[i]);
        }


        Console.WriteLine("Введите дату окончания периода в формате ДД.ММ.ГГГГ");
        string end_of_the_period = Console.ReadLine();

        string[] end_of_the_period_array = end_of_the_period.Split('.', ' ');
        int[] End_of_the_period = new int[3];

        for (int i = 0; i < 3; i++)
        {
            End_of_the_period[i] = Convert.ToInt32(end_of_the_period_array[i]);
        }


        Console.WriteLine("Введите начальный выпуск продукции P (0 <= P <= 5000)");

        int P = Convert.ToInt32(Console.ReadLine());

        int j = 0; // счетчик месяцев
        int k = 0; // счетчик дней
        int c1= 0; // проверка посл дня из даты
        int c2= 0; // проверка посл месяца из даты
        int end_of_the_month = 0; // кол-во месяцев
        int the_end_of_days = 0; // кол-во месяцев
        int number_of_products = 0; //суммарный объем продукции

        for (int i = The_beginning_of_the_period[2]; i <= End_of_the_period[2]; i++)
        {
            if (i == End_of_the_period[2])
            {
                end_of_the_month = End_of_the_period[1];
            }
            else
            {
                end_of_the_month = 12;
            }

            if (c2 == 0)
            {
                j = The_beginning_of_the_period[1];
                c2++;
            }
            else
            {
                j = 1;
            }

            for (; j <= end_of_the_month; j++)
            {

                if (i == End_of_the_period[2])
                {
                    if (j == end_of_the_month)
                    {
                        the_end_of_days = End_of_the_period[0];
                    }
                    else
                    {
                        the_end_of_days = how_many_days_are_there_in_a_month(j, i);
                    }
                }
                else
                {
                    the_end_of_days = how_many_days_are_there_in_a_month(j, i);
                }

                if (c1 == 0)
                {
                    k = The_beginning_of_the_period[0];
                    c1++;
                }
                else
                {
                    k = 1;
                }

                for (; k <= the_end_of_days; k++)
                {
                    number_of_products += P;
                    P = P + 1;
                }
                               
            }
        }
        Console.WriteLine("Суммарный объем продукции");
        Console.WriteLine(number_of_products);
    }   
}
