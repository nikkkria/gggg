internal class Program
{
    private static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Nika\source\repos\gggg\ksm\Saves\");

        Console.WriteLine("Want to start a new game?");
        string wtf = Console.ReadLine();
        if (wtf == "Yes" || wtf == "yes" || wtf == "YES")
        {
            gameStart(0, dir.FullName);

        }
        else
        {
            Console.WriteLine("please choose file from list");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            string userFileName = Console.ReadLine();
            StreamReader sr = File.OpenText(dir + userFileName);
            int questionNumber = Convert.ToInt32(sr.ReadToEnd());
            sr.Close();
            gameStart (questionNumber, dir.FullName);
        }

        static bool ManageQuestion(Questions question)
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
                return true;
            }
            else
            {
                Console.Write("Incorrect!");
                return false;
            }
        }
        static void gameStart(int inputNumber, string dir)
        {
            Questions[] question = new Questions[10];
            question[0] = new Questions("1. Когда родился Гояев Кирилл?", new string[] { "31.08.2007", "11.08.2008", "11.09.2001", "11.08.2007" }, 3);
            question[1] = new Questions("2. Кто из данных животных Дима?", new string[] { "Ёж", "Петух", "Фенек", "Кот" }, 1);
            question[2] = new Questions("3. В какой группе находятся Кирилл и Дима?", new string[] { "Фанаты Баяндиной", "Атнють не гипербола", "Казахские прошмандовки", "Светлый путь" }, 2);
            question[3] = new Questions("4. Любимая фраза Ники при возмущении?", new string[] { "Чтоб их камазом переехало", "Ну и пошло оно всё", "Пиздец", "Как все достало" }, 0);
            question[4] = new Questions("5. Кто снимался в военно-потриотическом фильме \"Истребитель\"?", new string[] { "Мой хороший друг Жданович Андрей", "Гояев Кирилл", "Командир взвода", "Витя Попов" }, 3);
            question[5] = new Questions("6. Кто самый конченый?", new string[] { "Ника", "Злата", "Дима", "Кирилл" }, 2);
            question[6] = new Questions("7. Какая самая вкусная часть тела на биологии?", new string[] { "Нога", "Лицо", "Рука", "Живот" }, 0);
            question[7] = new Questions("8. Без чего Злата не может жить?", new string[] { "Икра", "Чай", "Сухофрукты", "Кофе" }, 1);
            question[8] = new Questions("9. Вид птиц семейства бекасовых, гнездящийся в умеренном и субарктическом поясах Евразии:", new string[] { "Колибри", "Хохлатый питохуй", "Вальдшнеп", "Додо" }, 2);
            question[9] = new Questions("10. Что может рассмешить Диму?", new string[] { "Троллейбус", "Всё что угодно", "Оксид кремния", "Гояев Кирилл" }, 1);

            for (int i = inputNumber; i < 10; i++)
            {
                bool result = ManageQuestion(question[i]);
                if (!result)
                {
                    break;
                }
                else if (i < 9)
                {
                    Console.WriteLine("do you wanna save your game?");
                    string saveGame = Console.ReadLine();
                    if (saveGame == "no" || saveGame == "NO" || saveGame == "No")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("please name your file");
                        FileInfo nameFile = new FileInfo(Console.ReadLine());
                        File.WriteAllText(dir + nameFile.Name,(i+1).ToString() );
                        break;

                    }
                }
            }

        }
    }
}
