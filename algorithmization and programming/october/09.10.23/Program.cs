using System;

public class Matrix
{
    static int Array(int n, int m)
    {
        int[,] array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine((i + 1) + " строка:");
            for (int j = 0; j < m; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------------------------");
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                return array[i, j];
            }
        }
    }
    


    public static void Main(string[] args)
    {
        Console.WriteLine("Введите кол-во строк:"); 
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();


        Console.WriteLine(Array(n,m));
        // 1 задача

        /****Console.WriteLine("1)");
        int min = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            min = Array[i,0] ;**/

        

    }
}