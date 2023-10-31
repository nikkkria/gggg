using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 6; int b = 1; int d = 2;
        int c = (a * a - b) / d;
        Console.WriteLine("Результат вычисления: {0}", c);
    }
}