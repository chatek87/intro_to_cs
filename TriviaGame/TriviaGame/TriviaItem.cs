using static System.Console;
namespace TriviaGame;

class TriviaItem
{
    private string _question;
    private string _answer;

    public TriviaItem(string triviaQuestion, string triviaAnswer)
    {
        _question = triviaQuestion;
        _answer = triviaAnswer;  

    }

    public void AskQuestion()
    {
        // TODO: this should display the question, get a response,
        // and display the correct answer.
        WriteLine(_question);
        Write("What's your answer: ");
        string playerAnswer = ReadLine();
        WriteLine($"You answered: \"{playerAnswer}\".");
        WriteLine($"The correct answer was: {_answer}");
    }
}
