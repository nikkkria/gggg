internal class Program
{
    private static void Main(string[] args)
    {
        int[] numb1 = operations("Please enter first operand: ");
        int[] numb2 = operations("Please enter second operand: ");
        if (numb1[1] + numb2[1] >= 10 )
        {
            int[] result = { (numb1[0]  + numb2[0] ) + 1, (numb1[1] + numb2[1]) -10 };
            Console.WriteLine(result[0]*10 + result[1]) ;
        }
        else
        {
            int[] result = { numb1[0] + numb2[0], numb1[1] + numb2[1]};
            Console.WriteLine(result[0] * 10 + result[1]);
        }
    }
    static int[] operations (string wtf)
    {
        Console.WriteLine(wtf);
        string? input = Console.ReadLine();
        int number = int.Parse(input);
        int[] num = { number / 10, number % 10 };
        return num;
    }
}