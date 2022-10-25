using static System.Console;
namespace TriviaGame;

public class Game
{
    private string gameTitleArt = @"
                /||\ A                     
    R         i ||||                      
      i    V    ||||                      
  t             |||| /|\               
           /|\  |||| |||                 
           |||  |||| |||Q                
           |||  |||| |||            
           |||  |||| /|| U              
           |||  |||||||/          
           ||\._||||~~'     e      
           \||||||||             
            `~~~||||            
                ||||         S   
                ||||           t
~~~~~~~~~~~~~~~~||||~~~~~~~~~~~~~~
  \/..__..--  . |||| \/  .  ..
\/         \/ \/    \/
        .  \/              \/    .
. \/             .   \/     .
   __...--..__..__       .     \/
\/  .   .    \/     \/    __..--..
";
    private string gameTitle = "Trivia Quest";
    private string description = "Battle your friends for top score in trivia!";
    private Player currentPlayer;
    private TriviaItem unicornTrivia;
    
    // Constructor:
    public Game()
    {
        string unicornQuestion = "The National Animal of Scotland is the Unicorn - true or false?";
        unicornTrivia = new TriviaItem(unicornQuestion, "true");
    }
    public void Play()
    {
        Title = gameTitle;

        WriteLine(gameTitleArt);
        WriteLine($"Welcome to {gameTitle}");
        WriteLine(description);
        WriteLine("");

        Write("\nWhat is your name: ");
        string playerName = ReadLine();
        currentPlayer = new Player(playerName);
        WriteLine($"Hello, {currentPlayer.Name} welcome to {gameTitle}!");
        WriteLine($"Your starting score is {currentPlayer.Score}.");

        WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        unicornTrivia.AskQuestion();
        WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
        WriteLine("\nPress any key to exit...");
        ReadKey();
    }
}