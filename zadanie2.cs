using System;
using System.Collections.Generic;
using System.Linq;

// Definicja delegata reprezentującego warunek filtrowania
public delegate bool FilterCondition(int number);


class Program
{
    static void Main()
    {
        List<int> numbers = Enumerable.Range(1, 20).ToList();

        Console.WriteLine("Liczby parzyste:");
        PrintFilteredNumbers(numbers, number => number % 2 == 0);

        Console.WriteLine("\nLiczby większe od 10:");
        PrintFilteredNumbers(numbers, number => number > 10);

        Console.WriteLine("\nLiczby mniejsze niż 0:");
        PrintFilteredNumbers(numbers, number => number < 0);
    }

    static void PrintFilteredNumbers(List<int> numbers, FilterCondition condition)
    {
        var filteredNumbers = FilterNumbers(numbers, condition);
        Console.WriteLine(string.Join(", ", filteredNumbers));
    }

    // Funkcja filtrowania liczb
    static List<int> FilterNumbers(List<int> numbers, FilterCondition condition)
    {
        return numbers.Where(number => condition(number)).ToList();
    }
}




