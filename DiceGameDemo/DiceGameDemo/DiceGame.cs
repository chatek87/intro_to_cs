using static System.Console;

namespace DiceGameDemo
{
    class DiceGame
    {
        private string _gameName; 
        private int _score;
        private Random _randomGenerator;
        
        public DiceGame()
        {
            // This is the constructor.
            _score = 0;
            _gameName = "Rick Rolls";
            _randomGenerator = new Random();
        }

        public void Start()
        {
            // Method that starts the game running.
            Title = _gameName;
            WriteLine($"=== {_gameName} ===");
            WriteLine("\nInstructions:");
            WriteLine("\t>I will roll a die each round.");
            WriteLine("\t>You will guess if it's high or low.");
            WriteLine("\t>If you get it right, I'll give you a point.");

            WriteLine("\n\nReady to play? (yes/no)");
            AskToPlay();
        }

        private void PlayRound() 
        {
            // Method that runs one round of rolling and guessing.
            Clear();
            WriteLine("I'm about to roll...");
            WriteLine("Is it going to be low (1, 2, 3) or high (4, 5, 6)?");

            string response = ReadLine().Trim().ToLower();
            Clear();
            WriteLine($"You guessed {response}.");   

            int _roll = _randomGenerator.Next(1, 7);
            WriteLine($"{_roll} was rolled.");

            if (response == "low" && _roll < 4)
            {
                Win();
            }
            else if (response == "high" && _roll >= 4)
            {
                Win();
            }
            else
            {
                Lose();
            }
        }

        private void Win()
        {
            // Method that increments the score and lets the player know they won.
            WriteLine("Nice one!\n+1!");
            _score += 1;
            WriteLine($"Current score: {_score}");
            WriteLine("");
            WriteLine("Would you like to play again?");
            AskToPlay();
        }

        private void Lose()
        {
            // Method that lets the player know they lost.
            WriteLine("Sorry, buddy. No dice, so to speak.");
            WriteLine($"Current score: {_score}");
            WriteLine("");
            WriteLine("Would you like to play again?");
            AskToPlay();
        }

        private void AskToPlay()
        {   
            string playResponse = ReadLine().Trim().ToLower();
            while (playResponse != "yes" && playResponse != "no")
            {
                WriteLine("Please enter a valid response");
                playResponse = ReadLine().Trim().ToLower();
            }
            if (playResponse == "yes")
            {
                WriteLine("Great, let's play!");
                PlayRound();
            }
            else
            {
                WriteLine("Dang - okay, maybe another time" +
                    ".");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
            // Method that asks the player if they want to play another round.a
        }
    }
}
