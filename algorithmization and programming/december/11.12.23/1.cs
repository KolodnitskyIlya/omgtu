using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите время восхода: (7:30)");
        string sun_r = Console.ReadLine();

        Console.WriteLine("Введите время заката: (22:30)");
        string sun_t = Console.ReadLine();

        Console.WriteLine("Введите скорость: (км\\ч)");
        double speed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите количество остановок:");
        int stop_amount = Convert.ToInt32(Console.ReadLine());

        double[] stops = new double[stop_amount];

        Console.WriteLine("Введите расстояния до остановок:");

        for (int i = 0; i < stop_amount; i += 1)
        {
            stops[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sun_r_h = Convert.ToDouble(sun_r.Split(':')[0]);

        double sun_r_m = Convert.ToDouble(sun_r.Split(':')[1]) / 60;

        double sunr = sun_r_h + sun_r_m;

        double sun_s_h = Convert.ToDouble(sun_t.Split(':')[0]);

        double sun_s_m = Convert.ToDouble(sun_t.Split(':')[1]) / 60;

        double suns = sun_s_h + sun_s_m;

        double available_time = suns - sunr;
        double distance = speed * available_time;

        int day_count = 0;
        int pointer = 0;
        int step = 1;
        double position = 0;

        while (pointer + step < stop_amount)
        {
            if (stops[pointer + step] - position <= distance)
            {
                step += 1;
            }
            else
            {
                pointer += step;
                position = stops[pointer - 1];
                step = 1;
                day_count += 1;
                Console.Write("{0} ", pointer);
            }
        }

        Console.WriteLine();
        Console.WriteLine(day_count);
    }
}