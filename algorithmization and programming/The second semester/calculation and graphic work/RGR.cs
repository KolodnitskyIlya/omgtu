using System;

class InteractiveMenu
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Информация об авторе");
            Console.WriteLine("2. Польская запись");
            Console.WriteLine("3. Скобки");
            Console.WriteLine("4. Выход из меню");

            Console.Write("Выберите пункт меню: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAuthorInfo();
                    break;
                case 2:
                    PolishNotation();
                    break;
                case 3:
                    Brackets();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowAuthorInfo()
    {
        Console.Clear();
        Console.WriteLine("Информация об авторе:");
        Console.WriteLine("Автор: Колодницкий Илья");
        Console.WriteLine("Группа: ФИТ-232");
        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад...");
        Console.ReadKey();
        Main(null);
    }

    static void PolishNotation()
    {
        Console.Clear();
        Console.WriteLine("Польская запись:");

        Console.WriteLine("Введите выражение в обратной польской нотации:");
        string str = Console.ReadLine();

        var notation = str.Split();
        string[] operations = new string[] { "+", "-", "*", "/" };

        Stack<double> stack = new Stack<double>();

        bool valid = true;

        foreach (string elem in notation)
        {
            bool isDouble = double.TryParse(elem, out double number);
            if (isDouble)
            {
                stack.Push(number);
            }
            else if (Array.IndexOf(operations, elem) != -1)
            {
                if (stack.Count < 2)
                {
                    valid = false;
                    break;
                }

                double n1 = stack.Pop();
                double n2 = stack.Pop();

                if (elem == "+")
                {
                    stack.Push(n2 + n1);
                }
                else if (elem == "-")
                {
                    stack.Push(n2 - n1);
                }
                else if (elem == "*")
                {
                    stack.Push(n2 * n1);
                }
                else if (elem == "/")
                {
                    if (n1 == 0)
                    {
                        throw new DivideByZeroException("Нельзя делить на ноль!");
                    }
                    else
                    {
                        stack.Push(n2 / n1);
                    }
                }
            }
        }

        if (stack.Count != 1)
        {
            valid = false;
        }

        if (valid)
        {
            Console.WriteLine("Запись верна!");
            Console.WriteLine($"Результат: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine("Запись НЕВЕРНА!");
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад...");
        Console.ReadKey();
        Main(null);
    }

    static void Brackets()
    {
        Console.Clear();
        Console.WriteLine("Скобки:");
        Console.WriteLine("Введите строку со скобками:");
        string str = Console.ReadLine();
        char[] parens = new char[] { '(', ')', '[', ']', '{', '}' };

        Stack<char> stack = new Stack<char>();

        foreach (char c in str)
        {
            int index = Array.IndexOf(parens, c);
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (index != -1)
            {
                if (stack.Count > 0 && stack.Peek() == parens[index - 1])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
        }

        if (stack.Count > 0)
        {
            Console.WriteLine("Скобки расставленны НЕВЕРНО!");
        }
        else
        {
            Console.WriteLine("Все верно!");
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад...");
        Console.ReadKey();
        Main(null);
    }
}