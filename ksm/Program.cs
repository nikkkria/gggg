internal class Program
{
    private static void Main(string[] args)
    {
        Questions[] question = new Questions[10];
        question[0] = new Questions("Когда родился Гояев Кирилл?", new string[] { "31.08.2007", "11.08.2008", "11.09.2001", "11.08.2007" }, 3);
        question[1] = new Questions("Кто из данных животных Дима?", new string[] { "Ёж", "Петух", "Фенек", "Кот" }, 1);
        question[3] = new Questions("Любимая фраза Ники при возмущении?", new string[] { "Чтоб их камазом переехало", "Ну и пошло оно всё", "Пиздец", "Как все достало" }, 0);
        question[2] = new Questions("В какой группе находятся Кирилл и Дима?", new string[] { "Фанаты Баяндиной", "Атнють не гипербола", "Казахские прошмандовки", "Светлый путь" }, 2);
        question[4] = new Questions("Кто снимался в военно-потриотическом фильме \"Истребитель\"?", new string[] { "Мой хороший друг Жданович Андрей", "Гояев Кирилл", "Командир взвода", "Витя Попов" }, 3);
        question[5] = new Questions("Кто самый конченый?", new string[] { "Ника", "Злата", "Дима", "Кирилл" }, 2);
        question[6] = new Questions("Какая самая вкусная часть тела на биологии?", new string[] { "Нога", "Лицо", "Казахские прошмандовки", "Светлый путь" }, 0);
        question[7] = new Questions("Без чего Злата не может жить?", new string[] { "Икра", "Чай", "Сухофрукты", "Кофе" }, 1);
        question[8] = new Questions("Вид птиц семейства бекасовых, гнездящийся в умеренном и субарктическом поясах Евразии:", new string[] { "Колибри", "Хохлатый питохуй", "Вальдшнеп", "Додо" }, 2);
        question[9] = new Questions("Что может рассмешить Диму?", new string[] { "Троллейбус", "Всё что угодно", "Оксид кремния", "Гояев Кирилл" }, 1);
        for (int i = 0; i < 10; i++)
        {
            ManageQuestion(question[i]);
        }
        return;
    }
    static void ManageQuestion (Questions question)
    {
        Console.WriteLine(question.Text);
        for (int j = 0; j < question.Answers.Length; j++)
        {
            Console.WriteLine($"{j + 1}.{question.Answers[j].Text}");
        }
            Console.Write("Please enter your answer: ");
            int answerNumber = int.Parse(Console.ReadLine());
            Answer chosenAnswer = question.Answers[answerNumber - 1];
            if (chosenAnswer.IsCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect! \n");
                return;
            }

        }
    }