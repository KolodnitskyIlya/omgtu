using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // На вход подается текст. 
        // 1) Определить кол-во четных цифр в строке.
        // 2) Определить является ли строка палиндромом.
        
        
        Console.WriteLine("Введите строку:");
        string text = Console.ReadLine();
        
        int count_chet = 0; // счетник кол-ва четных цифр в строке
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '0' || text[i] == '2' || text[i] == '4' || text[i] == '6' || text[i] == '8')
            {
                count_chet++;
            } 
        }
        Console.WriteLine("1) Кол-во четных цифр в строке: " + count_chet);
        
        
        bool f = true;
        
        for (int i = 0; i < (text.Length / 2); i++)
        {
            if (text[i] == text[text.Length - i - 1])
            {
                continue;
            }
            else
            {
                f = false;
                Console.WriteLine("2) Строка не является палиндромом!!!");
                break;
            }
        }
        if (f == true)
        {
            Console.WriteLine("2) Строка - палиндром!!!");
        }
    }
}