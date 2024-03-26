//АЛГОРИТМ КРУСКАЛА

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        static bool check(string s, int nCheck)
        {
            string[] numbers = s.Split(' ');

            foreach (string n in numbers) {
                int number;
                if (int.TryParse(n, out number)) {
                    if (number == nCheck) {
                        return true;
                    }
                }
            }
            return false;
        }

        List<string> Array = new List<string>();
        string input = "1", inputR;

        Console.Write("Введите кол-во вершин: ");
        int number_of_vertices = Convert.ToInt32((Console.ReadLine()));
        string[] arr = new string[number_of_vertices];

        Console.WriteLine("Введите две вершины и вес ребра м/д ними(Пр: 1 2 22). Для выхода отправьте пустую строчку.");

        while (!string.IsNullOrWhiteSpace(input))
        {
            int num1 = 0, num2 = 0;
            Console.Write("Введите значения: ");
            input = Console.ReadLine();

            inputR = input.Replace(" ", "");

            string[] numbers = input.Split(' ');
            Console.WriteLine(numbers[0]);
            if (!string.IsNullOrWhiteSpace(inputR)) {
                num1 = Convert.ToInt32((numbers[0]));
                num2 = Convert.ToInt32((numbers[1]));
            } if (!string.IsNullOrWhiteSpace(inputR) && num1 != num2)
                Array.Add(input);
        }
        List<string> sortArr = Array.OrderBy(s => Convert.ToInt32((s.Split(' ')[2]))).ToList();

        int sum = 0;
        foreach (string n1 in sortArr)
        {
            bool flag = true;
            string[] numbers = n1.Split(' ');
            int num1 = Convert.ToInt32((numbers[0]));
            int num2 = Convert.ToInt32((numbers[1]));
            int num3 = Convert.ToInt32((numbers[2]));

            number_of_vertices = 0;
            while (flag)
            {
                if (arr[number_of_vertices] == null || arr[number_of_vertices].Length == 0) {
                    arr[number_of_vertices] += $" {Convert.ToString(num1)} {Convert.ToString(num2)}";
                    sum += num3;
                    flag = false;
                } else if ((!check(arr[number_of_vertices], num1) && check(arr[number_of_vertices], num2))) {
                    arr[number_of_vertices] += $" {Convert.ToString(num1)}";
                    sum += num3;
                    flag = false;
                } else if ((check(arr[number_of_vertices], num1) && !check(arr[number_of_vertices], num2))) {
                    arr[number_of_vertices] += $" {Convert.ToString(num2)}";
                    sum += num3;
                    flag = false;
                } else if (!check(arr[number_of_vertices], num1) && !check(arr[number_of_vertices], num2))
                    number_of_vertices++;
                else { flag = false; }
            }

            for (int x = 0; x < arr.Length; x++)
            {
                string strN = arr[x];
                if (strN != null && strN != "") {
                    string editStrNumber = "";
                    if (strN.Length > 1)
                        editStrNumber = strN.Substring(1);
                    string[] strArray = editStrNumber.Split(" ");
                    foreach (string n in strArray) {
                        for (int y = 0; y < arr.Length; y++) {
                            string strN2= arr[y];
                            if (strN2!= null && strN != strN2) {
                                string editStrNumber2 = "";
                                if (strN2.Length > 1) {
                                    editStrNumber2 = strN2.Substring(1);
                                }
                                int num;
                                if (int.TryParse(n, out num) && editStrNumber != editStrNumber2 && check(editStrNumber2, num)) {
                                    arr[x] += $" {arr[y]}";
                                    arr[y] = "";
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine($"Минимальная сумма: {sum}");
    }
}

//ПРИМЕР
/*9
1 2 15
1 5 14
1 4 23
2 3 19
2 4 16
2 5 15
3 5 14
3 6 26
4 5 25
4 7 23
4 8 20
5 6 24
5 8 27
5 9 18
7 8 14
8 9 18*/


