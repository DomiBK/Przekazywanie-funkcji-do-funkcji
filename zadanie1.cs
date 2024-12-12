using System;

// Definicja delegata reprezentującego operację matematyczną
public delegate int MathOperation(int a, int b);

class Program
{
    static void Main()
    {
        // Wywołanie funkcji PerformOperation dla każdej z operacji
        Console.WriteLine(PerformOperation(10, 5, Add));
        Console.WriteLine(PerformOperation(10, 5, Subtract));
        Console.WriteLine(PerformOperation(10, 5, Multiply));
        Console.WriteLine(PerformOperation(10, 5, Divide));
    }

    // Funkcja wykonywająca operację matematyczną
    static int PerformOperation(int a, int b, MathOperation operation)
    {
        return operation(a, b);
    }

    // Funkcje reprezentujące poszczególne operacje matematyczne
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;
    static int Multiply(int x, int y) => x * y;
    static int Divide(int x, int y) => x / y;
}
