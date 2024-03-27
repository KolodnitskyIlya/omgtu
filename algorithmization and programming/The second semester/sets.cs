//МНОЖЕСТВА

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Sets {
  public static void DisplaySet(SortedSet<double> set) {
    Console.Write("{");
    int count = 0;
    foreach (double num in set) {
      if (count == set.Count - 1) {
        Console.Write("{0}", num);
      } else {
        Console.Write("{0}, ", num);
      }
      count += 1;
    }
    Console.Write("}");
    Console.WriteLine();
  }

  public static void Main(string[] args) {
    SortedSet<double> mySetA = new SortedSet<double>() {1, 3, 5, 7, 9};
    SortedSet<double> mySetB = new SortedSet<double>() {0, 2, 4, 6, 8, 10};
    SortedSet<double> mySetC = new SortedSet<double>() {1, 2, 5, 6, 9, 10, 11, 12};

    Console.WriteLine("Множество #A:");
    DisplaySet(mySetA);
    Console.WriteLine();

    Console.WriteLine("Множество #B:");
    DisplaySet(mySetB);
    Console.WriteLine();

    Console.WriteLine("Множество #C:");
    DisplaySet(mySetC);
    Console.WriteLine();

    Console.WriteLine("Пересечение всех множеств:");
    DisplaySet(new SortedSet<double>(from x in mySetA.Intersect(mySetB).Intersect(mySetC) select x));
    Console.WriteLine();

    Console.WriteLine("Объединение всех множеств:");
    SortedSet<double> union = new SortedSet<double>(from x in mySetA.Union(mySetB).Union(mySetC) select x);
    DisplaySet(union);
    Console.WriteLine();

    Console.WriteLine("Дополнение множества #A:");
    DisplaySet(new SortedSet<double>(from x in union.Except(mySetA) select x));
    Console.WriteLine();

    Console.WriteLine("Дополнение множества #B:");
    DisplaySet(new SortedSet<double>(from x in union.Except(mySetB) select x));
    Console.WriteLine();

    Console.WriteLine("Дополнение множества #C:");
    DisplaySet(new SortedSet<double>(from x in union.Except(mySetC) select x));
  }
}
