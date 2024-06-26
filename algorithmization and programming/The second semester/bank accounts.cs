using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Account
    {
        public int ID;
        public string name;
        public int income;
        public int expenses;
        public double tax;

        public Account(int ID, string name, int income, int expenses)
        {
            this.ID = ID;
            this.name = name;
            this.income = income;
            this.expenses = expenses;
            tax = income * 0.05;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            List<Account> accounts = new List<Account>(){
                new Account(1, "Brandy Abbott", 85545, 50456),
                new Account(2, "Ashley Powell", 67123, 67123),
                new Account(3, "Stacy Thompson", 10400, 106400),
                new Account(4, "Carol Schmidt", 61234, 59321),
                new Account(5, "Amanda Maldonado", 55654, 1654)
            };

            Console.WriteLine("Счета с отрицательным балансом:");

            var query = from account in accounts
                        where (account.income - account.expenses - account.tax < 0)
                        select account;

            foreach (Account account in query)
            {
                Console.WriteLine($" - {account.name}");
            }
            Console.WriteLine();

            var query2 = from account in accounts
                         where (account.income - account.expenses - account.tax > 0)
                         select account;

            Console.WriteLine($"Количество счетов с положительным балансом: {query2.Count()} \n");

            double maxIncome = accounts.Max(x => x.income);
            var query3 = from account in accounts
                         where account.income == maxIncome
                         select account;

            Console.WriteLine("Счета с максимальным балансом:");

            foreach (Account account in query3)
            {
                Console.WriteLine($" - {account.name}");
            }
            Console.WriteLine();

            double totalTaxes = accounts.Sum(x => x.tax);
            Console.WriteLine($"Общая сумма налогов: {totalTaxes}");
        }
    }
}
