internal class Program
{
    private static void Main(string[] args)
    {
        int answer = 0;
        string[] questions = new string[10];
        questions[0] = "Когда родился Гояев Кирилл?";
        questions[1] = "Кто из данных животных Дима?";
        questions[2] = "В какой группе находятся Кирилл и Дима?";
        questions[3] = "Любимая фраза Ники при возмущении?";
        questions[4] = "Кто снимался в военно-потриотическом фильме \"Истребитель\"?";
        questions[5] = "Кто самый конченый?";
        questions[6] = "Какая самая вкусная часть тела на биологии?";
        questions[7] = "Без чего Злата не может жить?";
        questions[8] = "Вид птиц семейства бекасовых, гнездящийся в умеренном и субарктическом поясах Евразии:";
        questions[9] = "Что может рассмешить Диму?";
        string[][] answers = new string[10][];
        answers[0] = new[] { "1. 31.08.2007", "2. 11.08.2008", "3. 11.09.2001", "4. 11.08.2007" };
        answers[1] = new[] { "1. Ёж", "2. Петух", "3. Фенек", "4. Кот" };
        answers[2] = new[] { "1. Фанаты Баяндиной", "2. Атнють не гипербола", "3. Казахские прошмандовки", "4. Светлый путь" };
        answers[3] = new[] { "1. Чтоб их камазом переехало", "2. Ну и пошло оно всё", "3. Пиздец", "4. Как все достало" };
        answers[4] = new[] { "1. Мой хороший друг Жданович Андрей", "2. Гояев Кирилл", "3. Командир взвода", "4. Витя Попов" };
        answers[5] = new[] { "1. Ника", "2. Злата", "3. Дима", "4. Кирилл" };
        answers[6] = new[] { "1. Нога", "2. Лицо", "3. Рука", "4. Живот" };
        answers[7] = new[] { "1. Икра", "2. Чай", "3. Сухофрукты", "4. Кофе" };
        answers[8] = new[] { "1. Колибри", "2. Хохлатый питохуй", "3. Вальдшнеп", "4. Додо" };
        answers[9] = new[] { "1. Троллейбус", "2. Всё что угодно", "3. Оксид кремния", "4. Гояев Кирилл" };
        int[] correctAnswers = new int[10];
        correctAnswers[0] = 4;
        correctAnswers[1] = 2;
        correctAnswers[2] = 3;
        correctAnswers[3] = 1;
        correctAnswers[4] = 4;
        correctAnswers[5] = 3;
        correctAnswers[6] = 1;
        correctAnswers[7] = 2;
        correctAnswers[8] = 3;
        correctAnswers[9] = 2;
        Console.WriteLine("Приветствую вас! Вы попали в игру «Как стать миллионером»! И сегодня у вас действительно есть шанс им стать! Но, для начала, представьтесь.");
        string? name = Console.ReadLine();
        Console.WriteLine($"Что ж, {name}, здравствуйте." +
            $" Сегодня вам необходимо ответить на 10 вопросов, и если ваши ответы будут правильными, то вы выиграли! Ну а если нет.. то мы с вами попрощаемся.");
        Console.WriteLine("Ну что, поехали!" + "\n");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Вопрос " + (i + 1) + ": " + questions[i] + "\n");
            for (int g = 0; g < 4; g++)
            {
                Console.WriteLine(answers[i][g]);
            }
            Console.WriteLine();
            bool answer_ok = false;
            do
            {
                Console.Write("Введите номер ответа: ");
                string answer_st = Console.ReadLine();
                Console.WriteLine();
                answer_ok = int.TryParse((answer_st), out answer);
                if (!answer_ok)
                {
                    Console.WriteLine("Прошу, не балуйся и введи нормальный ответ. \n");
                }
            } while (!answer_ok);

            if (answer != correctAnswers[i])
            {
                Console.WriteLine("Извини, но это неправильный ответ. Вы проиграли! Увидимся в другой раз.");
                return;

            }
            else if (i < 9)
            {
                Console.WriteLine("Молодец, продолжаем игру! \n");
            }


        }
        Console.WriteLine("Поздравляю вас, вы прошли игру! Можете приехать по адресу г. Минск, ул. Купревича 3в и забрать свой приз! А у нас на этом всё, до свидания!");
    }
}
  
