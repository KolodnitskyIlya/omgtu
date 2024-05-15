using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> data = new List<string>(new string[] { "1345", "12345678", "123456", "1234567", "12347", "123489", "134", "12378" });
            var el = from e in data
                     where e.Length % 2 == 0
                     select e;

            foreach (var e in el)
                Console.Write(e + " ");

            Console.WriteLine();
            int i = 1;
            while (i < data.Count)
                data.RemoveAt(i++);

            foreach (var e in el)
                Console.Write(e + " ");

        }
    }
}