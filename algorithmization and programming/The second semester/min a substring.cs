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
            StreamReader sr = new StreamReader(@"C:\Users\coloi\Рабочий стол\Apps\ConsoleApplication5\input100.txt");
            int min_c = int.MaxValue;
            string min_l = "";
            bool check = false;
            while (true)
            {
                string line = sr.ReadLine();
                if (line != null)
                {
                    int count = 0;
                    foreach (char symb in line)
                    {
                        if (symb == 'a')
                        {
                            count += 1;
                        }
                        else if (count != 0 && count < min_c)
                        {
                            min_c = Math.Min(min_c, count);
                            min_l = line;
                            count = 0;
                            check = true;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine(min_l);
            }
            else
            {
                Console.WriteLine("no a");
            }
            Console.ReadKey();
        }
    }
}