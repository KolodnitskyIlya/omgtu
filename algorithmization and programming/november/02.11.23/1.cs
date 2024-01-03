//На вход подается строка.
//Определить наибольшую длину подстроки палиндрома.

using System.Reflection.Metadata;
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");

        string s = Console.ReadLine();

        int cnt_max = 0; //наибольшая длина подстроки палиндрома
        int cnt = 0; //вторичный счетчик

        for (int i = 0; i < s.Length; i++)
        {
            
            char c = s[i]; //берем символ и ищем его в строке

            for (int j = i + 1; j < s.Length; j++)
            {
                if (c == s[j] && s[j] != ' ') //не должно быть пробелов в подстроке
                {
                    int sr_min = i;
                    int sr_max = j;

                    for (; sr_min < sr_max; sr_min++, sr_max--)
                    {
                        if (s[sr_min] == s[sr_max] && s[sr_min] != ' ')
                        {
                            cnt += 2;
                        }
                        else
                        {
                            cnt = 0; //обнуляем вторичный счетчик
                        }
                    }
                    if (sr_max == sr_min)
                    {
                        cnt++; //добавляем символ, если длина подстроки доджна быть нечетной
                    }
                    if (s[sr_min] == ' ') //не должно быть пробелов в подстроке
                    {
                        cnt = 0; //обнуляем вторичный счетчик
                    }
                    if (cnt >= cnt_max)
                    {
                        cnt_max = cnt; //сравниваем вторичный счетчик с наибольшей длиной подстроки
                    }
                    
                }
                cnt = 0; //обнуляем вторичный счетчик
            }
        }
        Console.WriteLine($"Наибольшая длина подстроки палиндрома: {cnt_max}");
    }
}




