class Questions
{
    public Questions(string text, string[] answers, int correctAnswer)
    {
        Text = text;
        Answers = new Answer[answers.Length];
        for (int i = 0; i < answers.Length;i++)
        {
            Answers[i] = new Answer(answers[i], i == correctAnswer);
        }
    }
    public string Text;
    public Answer[] Answers;
}
