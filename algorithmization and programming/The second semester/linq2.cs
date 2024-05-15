using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int NumberSum(int number)
        {
            return number.ToString().ToArray().Aggregate<char, int>(0, (sum, el) => sum += int.Parse(el + ""));
        }

        static void Main(string[] args)
        {
            int[] elements = new int[] { 345, 123, 45, 11, 46, 1253, 439, 5654, 3763 };
            elements
                .Where(e => NumberSum(e) % 2 == 0)
                .ToList()
                .ForEach(e => Console.Write(e + " "));
        }
    }
}