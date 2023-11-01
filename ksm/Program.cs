internal class Program
{
    private static void Main(string[] args)
    {
        int answer = 0;
        string[] questions = new string[10];
        questions[0] = "1. Когда родился Гояев Кирилл?";
        questions[1] = "2. Кто из данных животных Дима?";
        questions[2] = "3. В какой группе находятся Кирилл и Дима?";
        questions[3] = "";
        questions[4] = "";
        questions[5] = "";
        questions[6] = "";
        questions[7] = "";
        questions[8] = "";
        questions[9] = "";
        string[][] answers = new string[10][];
        answers[0] = new[] { "1:31.08.2007", "2:11.08.2008", "3:11.09.2001", "4:11.08.2007" };
        answers[1] = new[] { "A:ёж", "B:петух", "C:фенек", "D:кот" };
        answers[2] = new[] { "1.Фанаты Баяндиной", "2. Атнють не гипербола", "3. Казахские прошмандовки", "4. Светлый путь" };
        answers[3] = new[] { "", "", "", "" };
        answers[4] = new[] { "", "", "", "" };
        answers[5] = new[] { "", "", "", "" };
        answers[6] = new[] { "", "", "", "" };
        answers[7] = new[] { "", "", "", "" };
        answers[8] = new[] { "", "", "", "" };
        answers[9] = new[] { "", "", "", "" };
        int[] correctAnswers = new int[10];
        correctAnswers[0] = 4;
        correctAnswers[1] = 2;
        correctAnswers[2] = 3;
        correctAnswers[3] = 1;
        correctAnswers[4] = 1;
        correctAnswers[5] = 1;
        correctAnswers[6] = 1;
        correctAnswers[7] = 1;
        correctAnswers[8] = 1;
        correctAnswers[9] = 1;
        Console.WriteLine("Приветствую вас! Вы попали в игру «Как стать миллионером»! И сегодня у вас действительно есть шанс им стать! Но, для начала, представьтесь.");
        string? name = Console.ReadLine();
        Console.WriteLine($"Что ж, {name}, здравствуйте." +
            $" Сегодня вам необходимо ответить на 10 вопросов, и если ваши ответы будут правильными, то вы выиграли! Ну а если нет.. то мы с вами попрощаемся.");
        Console.WriteLine("Ну что, поехали!");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(questions[i]);
            for (int g = 0; g < 4; g++)
            {
                Console.WriteLine(answers[i][g]);
            }
            bool firstOperand_ok = false;
            do { 
            string answer_st = Console.ReadLine();
            firstOperand_ok = int.TryParse((answer_st), out answer);
            if (!firstOperand_ok)
            {
                Console.WriteLine("не балуйся");
            }
            } while (!firstOperand_ok);
            if (answer != correctAnswers[i])
            {
                Console.WriteLine("прости,но это неправильно. пока");
                return;
                
            }
            else
            {
                Console.WriteLine("молодец,продолжаем!");
            }
            //Console.WriteLine(answer);

            //int trueAnswer = parseAnswer;
            //if (answer == answers[i][4]) Console.WriteLine("hhhh");

        }

    }
    //static int parseAnswer(string ch)
    //{
        //bool firstOperand_ok = false;
        //string answer = Console.ReadLine();
        //firstOperand_ok = int.TryParse((answer), out );
        //if (!firstOperand_ok)
        //{
        //Console.WriteLine("sorry, I don't understand that number");
        //}
    }
  
