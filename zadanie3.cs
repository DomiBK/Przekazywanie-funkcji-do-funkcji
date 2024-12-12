using System;
using System.Collections.Generic;
using System.Linq;

// Definicja delegata reprezentującego transformację
public delegate int Transform(int number);

class Program
{
    static void Main()
    {        
        List<int> numbers = Enumerable.Range(1, 5).ToList();
        Console.WriteLine("Kwadrat liczb:");
        PrintMappedNumbers(numbers, Square);

        Console.WriteLine("\nLiczby podwojone:");
        PrintMappedNumbers(numbers, DoubleNumber);

        Console.WriteLine("\nLiczby zmniejszone o 1:");
        PrintMappedNumbers(numbers, SubtractOne);
    }

    // Funkcje mapowania
    static int Square(int x) => x * x;
    static int DoubleNumber(int x) => x * 2;
    static int SubtractOne(int x) => x - 1;

    // Funkcja mapująca liczby
    static List<int> Map(List<int> numbers, Transform transform)
    {        
        return numbers.Select(x => transform(x)).ToList(); 
    }

    static void PrintMappedNumbers(List<int> numbers, Transform transform)
    {
        var mappedNumbers = Map(numbers, transform);
        Console.WriteLine(string.Join(", ", mappedNumbers));
    }
}
