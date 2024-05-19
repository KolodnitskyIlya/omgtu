using System;
using System.Linq;
using System.Collections.Generic;
using Test;

namespace Test;

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
        List<Account> Accounts = new List<Account>(){
            new Account(1, "Brandy Abbott", 85545, 50456),
            new Account(2, "Ashley Powell", 67123, 67123),
            new Account(3, "Stacy Thompson", 10400, 106400),
            new Account(4, "Carol Schmidt", 61234, 59321),
            new Account(4, "Amanda Maldonado", 55654, 1654)
        };

        Console.WriteLine("Счета с отрицательным балансом:");

        var query = from account in Accounts
                    where (account.income - account.expenses - account.tax < 0)
                    select account;

        foreach (Account account in query)
        {
            Console.WriteLine($" - {account.name}");
        }
        Console.WriteLine();

        var query2 = from account in Accounts
                     where (account.income - account.expenses - account.tax > 0)
                     select account;

        Console.WriteLine($"Количество счетов с положительным балансом: {query2.Count()} \n");

        //Account item = Accounts.MaxBy(x => x.income);

        var query3 = from account in Accounts
                     let x = Accounts.Max(x => x.income)
                     where (account.income == x)
                     select account;

        Console.WriteLine("Счета с максимальным балансом:");

        foreach (Account account in query3)
        {
            Console.WriteLine($" - {account.name}");
        }
        Console.WriteLine();

        double total_taxes = Accounts.Select(x => x.tax).ToList().Sum();
        Console.WriteLine($"Общая сумма налогов: {total_taxes}");
    }
}