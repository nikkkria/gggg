using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        string znak = Console.ReadLine();
        while (znak != "+" && znak != "-" && znak != "*" && znak != "/") 
        { 
            Console.WriteLine("введите правильный знак операции");
            znak = Console.ReadLine();
        };
        int b = Convert.ToInt32(Console.ReadLine());

        


        //if (znak == "/") c = (double)a;
    }
}
