using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void DisplayHelp()
    {
        Console.WriteLine("'?' - Display help");
        Console.WriteLine("'!' - Exit the program");
        Console.WriteLine("'1' - Count the number of elements in the array");
        Console.WriteLine("'2' - Binary search for an element in the array");
        Console.WriteLine("'3' - Create a copy of the array (output full)");
        Console.WriteLine("'4' - Find the index of a specific number in the array");
        Console.WriteLine("'5' - Insert into the array");
        Console.WriteLine("'6' - Reverse the array");
        Console.WriteLine("'7' - Sort the array");
        Console.WriteLine("'8' - Add to the array ");
    }

    static void DisplayArrayList(ArrayList arrayList)
    {
        foreach (double elem in arrayList)
        {
            Console.Write("{0} ", elem);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Операции над ArrayList");
        Console.WriteLine();
        Console.WriteLine("Введите элементы ArrayList через пробел:");
        var array = Console.ReadLine()
          .Split(" ")
          .Select(s => Convert.ToDouble(s))
          .ToArray();

        var arlist = new ArrayList();
        arlist.AddRange(array);

        Console.WriteLine();
        DisplayHelp();
        Console.WriteLine();

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Array:");
            DisplayArrayList(arlist);
            Console.WriteLine();
            string command = Console.ReadLine();

            switch (command)
            {
                case "?":
                    DisplayHelp();
                    break;
                case "!":
                    {
                        running = false;
                    }
                    break;
                case "1":
                    {
                        Console.WriteLine("Count:");
                        Console.WriteLine(arlist.Count);
                    }
                    break;
                case "2":
                    {
                        var newArrayList = new ArrayList(arlist);
                        Console.WriteLine("Отсортированный ArrayList:");
                        newArrayList.Sort();
                        DisplayArrayList(newArrayList);

                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double binSearched = newArrayList.BinarySearch(number);
                        Console.WriteLine();
                        Console.WriteLine("Индекс искомого числа в отсортированном множестве:");
                        Console.WriteLine(binSearched);
                    }
                    break;
                case "3":
                    {
                        var newArrayList = new ArrayList(arlist);

                        Console.WriteLine("Копия множества:");
                        DisplayArrayList(newArrayList);
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Поиск индекса данного числа");
                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double found = arlist.IndexOf(number);
                        Console.WriteLine();
                        Console.WriteLine("Индекс:");
                        Console.WriteLine(found);
                    }
                    break;
                case "5":
                    {
                        Console.WriteLine("Вставляем число в ArrayList");
                        Console.WriteLine("Введите индекс:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число:");
                        double number = Convert.ToDouble(Console.ReadLine());

                        arlist.Insert(index, number);

                        Console.WriteLine();
                        Console.WriteLine("ArrayList со вставленным числом:");
                        DisplayArrayList(arlist);
                    }
                    break;
                case "6":
                    {
                        Console.WriteLine("Reversed ArrayList:");
                        arlist.Reverse();
                        DisplayArrayList(arlist);
                    }
                    break;
                case "7":
                    {
                        arlist.Sort();
                        DisplayArrayList(arlist);
                    }
                    break;
                case "8":
                    {
                        Console.WriteLine("Введите число для добавления:");
                        double number = Convert.ToDouble(Console.ReadLine());
                        arlist.Add(number);
                        Console.WriteLine();
                        Console.WriteLine("ArrayList с добавленным числом:");
                        DisplayArrayList(arlist);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Некорректная команда. Введите '?' для вывода списка команд.");
                    }
                    break;
            }
        }
    }
}