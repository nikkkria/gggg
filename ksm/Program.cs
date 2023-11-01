internal class Program
{
    private static void Main(string[] args)
    {
        string[] questions = new string[10];
        questions[0] = "Когда родился Гояев Кирилл?";
        questions[1] = "Кто из данных животных Дима?";
        questions[2] = "";
        questions[3] = "";
        questions[4] = "";
        questions[5] = "";
        questions[6] = "";
        questions[7] = "";
        questions[8] = "";
        questions[9] = "";
        string[][] answers = new string[10][];
        answers[0] = new string[] { "A:31.08.2007", "B:11.08.2008", "C:11.09.2001", "D:11.08.2007" };
        answers[1] = new string[] { "A:ёж", "B:петух", "C:фенек", "D:кот" };
        answers[2] = new string[] { "A:", "B:", "C:", "D:" };
        answers[3] = new string[] { "A:", "B:", "C:", "D:" };
        answers[4] = new string[] { "A:", "B:", "C:", "D:" };
        answers[5] = new string[] { "A:", "B:", "C:", "D:" };
        answers[6] = new string[] { "A:", "B:", "C:", "D:" };
        answers[7] = new string[] { "A:", "B:", "C:", "D:" };
        answers[8] = new string[] { "A:", "B:", "C:", "D:" };
        answers[9] = new string[] { "A:", "B:", "C:", "D:" };
        int [] correctAnswers = new int[10];
        correctAnswers[0] = 4;
        correctAnswers[1] = 2;


        Console.WriteLine("Приветствую вас! Вы попали в игру «Как стать миллионером»! И сегодня у вас действительно есть шанс им стать! Но, для начала, представьтесь.");
        string? name = Console.ReadLine();
        Console.WriteLine($"Что ж, {name}, здравствуйте." +
            $" Сегодня вам необходимо ответить на 10 вопросов, и если ваши ответы будут правильными, то вы выиграли! Ну а если нет.. то мы с вами попрощаемся.");
        Console.WriteLine("Ну что, поехали!");
        for ( int i = 0; i < 10; i++ )
        {
            Console.WriteLine(checkAnswer);
        }
        
        static string checkAnswer(string answer)
    {
        Console.WriteLine(questions[0]);

    }    
}


    }
  
