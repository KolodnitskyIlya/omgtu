// Машина

using System;
class Car
{
    public string year;
    public string color;
    public string type;
    public string owner;
    public string healthcheck;

    public Car(string Year, string Color, string Type, string Owner, string Healthcheck)
    {
        year = Year;
        color = Color;
        type = Type;
        owner = Owner;
        healthcheck = Healthcheck;
    }

    public void Info()
    {
        Console.WriteLine($"{color} {type} {year} года. Имеет {owner}, тех.осмотр был в {healthcheck} году.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car[] cars = new Car[4] {
             new Car("1000", "Красная", "BMW", "Антон", "2000"),
             new Car("1200", "Синий", "MERSEDES", "Рома", "2001"),
             new Car("1400", "Черная", "BMW", "Антон", "2002"),
             new Car("1600", "Зеленая", "MERSEDES", "Вася", "2003"),
         };

        Console.WriteLine("Введите (1) для выборки по году выпуска, (2) по марке, (3) по году тех осмотра");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            string year = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].year == year)
                {
                    cars[i].Info();
                }
            }

        }
        else if (option == 2)
        {
            string type = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].type == type)
                {
                    cars[i].Info();
                }
            }

        }
        else if (option == 3)
        {
            string healthcheck = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].healthcheck == healthcheck)
                {
                    cars[i].Info();
                }
            }

        }
    }
}