﻿using System;
using System.Linq;

interface IMethods
{
    double Add(double a, double b);
    double Subtract(double a, double b);
    double Multiply(double a, double b);
    double Divide(double a, double b);
    double Root(double b, double e);
    double Sin(double n);
    double Cos(double n);
}

class Interfaces : IMethods
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new Exception("Zero");
        }
        return a / b;
    }

    public double Root(double b, double e)
    {
        if (e % 2 == 0 && b < 0)
        {
            throw new Exception("An even degree with a negative base");
        }
        return Math.Pow(b, 1.0 / e);
    }

    public double Sin(double n)
    {
        return Math.Sin(n);
    }

    public double Cos(double n)
    {
        return Math.Cos(n);
    }

    public delegate double Binary(double a, double b);
    public delegate double Unary(double n);

    public static void Main(string[] args)
    {
        Interfaces obj = new Interfaces();

        Console.WriteLine("What kind of operation do you want to perform?");
        Console.WriteLine();
        Console.WriteLine("0 - Addition");
        Console.WriteLine("1 - Subtraction");
        Console.WriteLine("2 - Multiplication");
        Console.WriteLine("3 - Division");
        Console.WriteLine("4 - Root extraction");
        Console.WriteLine("5 - The sine of the number");
        Console.WriteLine("6 - The cosine of the number");

        int choice = Convert.ToInt32(Console.ReadLine());
        Binary bin = new Binary(obj.Add);
        Unary un = new Unary(obj.Sin);

        switch (choice)
        {
            case 0:
                {
                    bin = new Binary(obj.Add);
                    break;
                }
            case 1:
                {
                    bin = new Binary(obj.Subtract);
                    break;
                }
            case 2:
                {
                    bin = new Binary(obj.Multiply);
                    break;
                }
            case 3:
                {
                    bin = new Binary(obj.Divide);
                    break;
                }
            case 4:
                {
                    bin = new Binary(obj.Root);
                    break;
                }
            case 5:
                {
                    un = new Unary(obj.Sin);
                    break;
                }
            case 6:
                {
                    un = new Unary(obj.Cos);
                    break;
                }
            default:
                Console.WriteLine("There is no such function");
                break;
        }

        if (choice >= 0 && choice <= 4)
        {
            Console.WriteLine("Enter two numbers:");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine(bin(a, b));
        }
        else if (choice >= 5 && choice <= 6)
        {
            Console.WriteLine("Enter one number:");

            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine(un(n));
        }
    }
}