using static System.Console;
namespace BooleanLogicalOperatorsDemo;

class RPSGame
{
    public void Play()
    {
        Title = "=== RPS Game ===";

        WriteLine("Let's play some RPS!");
        
        
        WriteLine("\"rock\", \"paper\", or \"scissors\"?");
        Write("Enter your move: ");        
        string playerMove = ReadLine();
        while (playerMove != "rock" && playerMove != "paper" && playerMove != "scissors")
        {
            WriteLine("that's not a valid move.");
            Write("Enter your move: ");
            playerMove = ReadLine();
        }

        string computerMove = RandomRPS();

        WriteLine(FindWinner(playerMove, computerMove));

        WriteLine("Press any key to exit...");
        ReadKey();        
    }

    public string RandomRPS()
    {
        Random rand = new Random();
        int result = rand.Next(0, 3);
        
        if (result == 0)
        {
            return "rock";
        }
        else if (result == 1)
        {
            return "paper";
        }
        else
        {
            return "scissors";
        }

    }

    public string FindWinner(string player1Move, string player2Move)
    {
        string result;
        // Tie condition
        if (player1Move == player2Move)
        {
            result = "Draw";
            return result;
        }
        // player1 wins conditions
        else if ((player1Move == "rock" && player2Move == "scissors") || (player1Move == "paper" && player2Move == "rock") || (player1Move == "scissors" && player2Move == "rock"))
        {
            result = "You win!";
            return result;
        }
        else
        {
            result = "You lose :/";
            return result;
        }

    }
}
