using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void DisplayCommands()
    {
        Console.WriteLine("'?' - Display help");
        Console.WriteLine("'!' - Exit the program");
        Console.WriteLine("'1' - Count the number of elements in the array");
        Console.WriteLine("'2' - Binary search for an element in the array");
        Console.WriteLine("'3' - Create a copy of the array (output full)");
        Console.WriteLine("'4' - Find the index of a specific number in the array");
        Console.WriteLine("'5' - Find the index of the last occurrence of a number in the array");
        Console.WriteLine("'6' - Find the index of the first occurrence of a number in the array");
        Console.WriteLine("'7' - Reverse the array");
        Console.WriteLine("'8' - Resize the array");
        Console.WriteLine("'9' - Sort the array");
    }
    static void DisplayArray(double[] array)
    {
        foreach (double elem in array)
        {
            Console.Write("{0} ", elem);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Операции над Array");
        Console.WriteLine();
        Console.WriteLine("Введите элементы Array через пробел:");
        double[] array = Console.ReadLine()
          .Split(" ")
          .Select(s => Convert.ToDouble(s))
          .ToArray();
        Console.WriteLine();
        DisplayCommands();
        Console.WriteLine();

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Array:");
            DisplayArray(array);
            Console.WriteLine();
            string command = Console.ReadLine();

            switch (command)
            {
                case "?":
                    DisplayCommands();
                    break;
                case "!":
                    {
                        running = false;
                    }
                    break;
                case "1":
                    {
                        Console.WriteLine("Count:");
                        Console.WriteLine(array.Count());
                    }
                    break;
                case "2":
                    {
                        double[] newArray = (double[])array.Clone();
                        Array.Sort(newArray); Console.WriteLine("Отсортированный Array:");
                        DisplayArray(newArray);

                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double binSearched = Array.BinarySearch(newArray, number);
                        Console.WriteLine();
                        Console.WriteLine("Индекс искомого числа в отсортированном множестве:");
                        Console.WriteLine(binSearched);
                    }
                    break;
                case "3":
                    {
                        double[] newArray = (double[])array.Clone();
                        Console.WriteLine("Копия Array (полная):");
                        DisplayArray(newArray);
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        int foundIndex = Array.FindIndex(array, x => x == number);
                        Console.WriteLine();
                        if (foundIndex != -1)
                        {
                            Console.WriteLine("Индекс первого вхождения числа в Array:");
                            Console.WriteLine(foundIndex);
                        }
                        else
                        {
                            Console.WriteLine("Число не найдено в Array.");
                        }
                    }
                    break;
                case "5":
                    {
                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        int foundLastIndex = Array.FindLastIndex(array, x => x == number);
                        Console.WriteLine();
                        if (foundLastIndex != -1)
                        {
                            Console.WriteLine("Индекс последнего вхождения числа в Array:");
                            Console.WriteLine(foundLastIndex);
                        }
                        else
                        {
                            Console.WriteLine("Число не найдено в Array.");
                        }
                    }
                    break;
                case "6":
                    {
                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        int index = Array.IndexOf(array, number);
                        Console.WriteLine();
                        if (index != -1)
                        {
                            Console.WriteLine("Индекс первого вхождения числа в Array:");
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("Число не найдено в Array.");
                        }
                    }
                    break;
                case "7":
                    {
                        Array.Reverse(array);
                        Console.WriteLine("Array после реверса:");
                        DisplayArray(array);
                    }
                    break;
                case "8":
                    {
                        Console.WriteLine("Введите новый размер массива:");
                        int newSize = Convert.ToInt32(Console.ReadLine());
                        Array.Resize(ref array, newSize);
                        Console.WriteLine("Array после изменения размера:");
                        DisplayArray(array);
                    }
                    break;
                case "9":
                    {
                        Array.Sort(array);
                        Console.WriteLine("Отсортированный Array:");
                        DisplayArray(array);
                    }
                    break;
                default:
                    Console.WriteLine("Некорректная команда. Введите '?' для вывода списка команд.");
                    break;
            }
        }
    }
}

