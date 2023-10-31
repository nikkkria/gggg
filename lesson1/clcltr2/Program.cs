using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int c = 0;
        int a = 0;
        double C;
        bool firstOperand_ok = false;
        do
        {
            Console.WriteLine("please enter first operand");
            string a_string = Console.ReadLine();
            firstOperand_ok = int.TryParse((a_string), out a);
            if (!firstOperand_ok)
            {
                Console.WriteLine("sorry, I don't understand that number");
            }

        } while (!firstOperand_ok);

        bool opsign_ok = false;
        string znak = " ";
        do
        {
            Console.WriteLine("please enter operation sign");
            znak = Console.ReadLine();
            if (znak != "+" && znak != "-" && znak != "*" && znak != "/")
            {
                Console.WriteLine("sorry, I don't understand that sign");
                opsign_ok = false;
            }

        } while (opsign_ok);

        int b = 0;
        bool secondOperand_ok = false;
        do 
        {
            Console.WriteLine("please enter second operand");
            string b_string = Console.ReadLine();
            secondOperand_ok = int.TryParse((b_string), out b);
            if (!secondOperand_ok) 
            {
            Console.WriteLine("sorry, I don't understand that number");
            }
            
        } while (!secondOperand_ok) ; 
        
        
        
         if (znak == "/") if (b == 0) {
            Console.WriteLine("sorry I can't divide by zero");
            return; } 
        else {
                double A = Convert.ToDouble(a);
                double B = Convert.ToDouble(b);
                
               C = A / B;
               Console.WriteLine("result:"  + C);

            }  
       
        else { if (znak == "+") c = a + b;
        else if (znak == "-") c = a - b;
        else if (znak == "*") c = a * b;


            {

                Console.WriteLine("result:" + c);
                return;
            }
        }
    }
}

