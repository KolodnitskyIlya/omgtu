using System;
class HelloWorld
{
    static void Main()
    {
        
        Random number = new Random();

        // берет рандомный диапазон от 0 до 100000 
        int N = number.Next(0,100001);

        // число, которое нужно угадать
        int random_number = number.Next(N+1);

        Console.WriteLine($"Программа загадала случайное число от 0 до {N}. Попробуй угадать)");

        // рандомное кол-во попыток от 10 до 35
        int attempt = number.Next(10,36);

        Console.WriteLine();

        Console.WriteLine($"Даю тебе {attempt} попыток");

        Console.WriteLine();

        //кол-во попыток
        int cnt = 1;

        //вводим переменную для того, чтобы в дальнейшем ее использовать
        int your_number = -1;

        //угадываем с теми попытками которые даст программа
        for (int i = attempt; i > 0; i--, cnt++)
        {          

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"У тебя осталось {i} попыток");

            //вводим свое число
            your_number = Convert.ToInt32(Console.ReadLine());

            if (your_number == random_number)
            {
                Console.WriteLine();
                Console.WriteLine($"Ура!!! Вы смогли угадать число за {cnt} попыток");
                break;
            }

            else if (your_number < random_number)
            {
                Console.WriteLine("Слишком мало. Возьмите побольше.");
            }

            else
            {
                Console.WriteLine("Слишком много. Возьмите поменьше.");
            }
            
            //если попытки закончились выводим сообщение
            if (i - 1 == 0)           
            {
                Console.WriteLine();
                Console.WriteLine($"Увы, вы не смогли угадать число за {attempt} попыток. Но ничего страшного, пытайтесь еще!!! Вы справитесь!!!!!!!!");
                cnt--;
            }
            
        }

        //продолжаем угадывать если попытки закончились
        while (your_number != random_number)
        {

            Console.WriteLine("-----------------------------------");

            //вводим свое число
            your_number = Convert.ToInt32(Console.ReadLine());

            if (your_number == random_number)
            {
                Console.WriteLine();
                Console.WriteLine($"Ура!!! Вы смогли угадать число за {cnt+1} попыток");
                break;
            }

            else if (your_number < random_number)
            {
                Console.WriteLine("Слишком мало. Возьмите побольше.");
            }

            else
            {
                Console.WriteLine("Слишком много. Возьмите поменьше.");
            }

            cnt++;

            Console.WriteLine($"Вы уже потратили {cnt} попыток");

        }

    }
}