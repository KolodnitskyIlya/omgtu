using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader str_1 = new StreamReader(@"C:\Users\coloi\Рабочий стол\Apps\ConsoleApplication5\input100.txt");
            StreamReader str_2 = new StreamReader(@"C:\Users\coloi\Рабочий стол\Apps\ConsoleApplication5\input200.txt");

            int data1 = Convert.ToInt32(str_1.ReadLine());
            int data2 = Convert.ToInt32(str_2.ReadLine());
            int check = 0;
            while (true)
            {
                if (data1 < data2)
                {
                    Console.WriteLine(data1);
                    string read1 = str_1.ReadLine();
                    if (read1 != null)
                    {
                        data1 = Convert.ToInt32(read1);
                    }
                    else { check = 1; break; }

                }
                else
                {
                    Console.WriteLine(data2);
                    string read2 = str_2.ReadLine();
                    if (read2 != null)
                    {
                        data2 = Convert.ToInt32(read2);
                    }
                    else { check = 2; break; }
                }
            }

            if (check == 2)
            {
                Console.WriteLine(data1);
                while (true)
                {
                    string read1 = str_1.ReadLine();
                    if (read1 != null)
                    {
                        data1 = Convert.ToInt32(read1);
                        Console.WriteLine(data1);
                    }
                    else { break; }
                }
            }

            else if (check == 1)
            {
                Console.WriteLine(data2);
                while (true)
                {
                    string read2 = str_2.ReadLine();
                    if (read2 != null)
                    {
                        data2 = Convert.ToInt32(read2);
                        Console.WriteLine(data2);
                    }
                    else 
                    { 
                        break; 
                    }
                }
            }

            Console.ReadKey();
        }
    }
}