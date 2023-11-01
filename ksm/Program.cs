internal class Program
{
    private static void Main(string[] args)
    {
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
        answers[0] = new[] { "A: 31.08.2007", "B: 11.08.2008", "C: 11.09.2001", "D: 11.08.2007" };
        answers[1] = new[] { "A: Ёж", "B: Петух", "C: Фенек", "D: Кот" };
        answers[2] = new[] { "A: Фанаты Баяндиной", "B: Атнють не гипербола", "C: Казахские прошмандовки", "D: Светлый путь" };
        answers[3] = new[] { "A: Чтоб их камазом переехало", "B: Ну и пошло оно всё", "C: Пиздец", "D: Как все достало" };
        answers[4] = new[] { "A: Мой хороший друг Жданович Андрей", "B: Гояев Кирилл", "C: Командир взвода", "D: Витя Попов" };
        answers[5] = new[] { "A: Ника", "B: Злата", "C: Дима", "D: Кирилл" };
        answers[6] = new[] { "A: Нога", "B: Лицо", "C: Рука", "D: Живот" };
        answers[7] = new[] { "A: Икра", "B: Чай", "C: Сухофрукты", "D: Кофе" };
        answers[8] = new[] { "A: Колибри", "B: Хохлатый питохуй", "C: Вальдшнеп", "D: Додо" };
        answers[9] = new[] { "A: Троллейбус", "B: Всё что угодно", "C: Оксид кремния", "D: Гояев Кирилл" };
        string[] correctAnswers = new string[10];
        correctAnswers[0] = "D";
        correctAnswers[1] = "B";
        correctAnswers[2] = "C";
        correctAnswers[3] = "A";
        correctAnswers[4] = "D";
        correctAnswers[5] = "C";
        correctAnswers[6] = "A";
        correctAnswers[7] = "B";
        correctAnswers[8] = "C";
        correctAnswers[9] = "B";
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
            string? ans = Console.ReadLine();
            Console.WriteLine();
            bool result = true;
            if (result != correctAnswers[i].Contains(ans))
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
