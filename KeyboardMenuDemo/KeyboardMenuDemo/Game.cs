namespace KeyboardMenuDemo;
using static System.Console;

class Game
{
    public void Start()
    {
        Title = "=== Paint Drying ===";
        RunMainMenu();
    }

    private void RunMainMenu()
    {
        string prompt = "(ASCII ART HERE)";
        string[] options = { "Play", "About", "Exit" };
        Menu mainMenu = new Menu(prompt, options);
        int selectedIndex = mainMenu.Run();
        
        switch (selectedIndex)
        {
            case 0:
                RunFirstChoice();
                break;
            case 1:
                DisplayAboutInfo();
                break;
            case 2:
                ExitGame();
                break;
        }
    }

    private void ExitGame()
    {
        WriteLine("\nPress any key to exit...");
        ReadKey(true);
        Environment.Exit(0); 
    }

    private void DisplayAboutInfo()
    {
        Clear();
        WriteLine("This game was made by blahBlah");
        WriteLine("Press any key to return to the menu");
        ReadKey(true);
        RunMainMenu();
    }

    private void RunFirstChoice()
    {
        string prompt = "what color paint?";
        string[] options = { "Red", "Green", "Blue", "Yellow" };
        Menu colorMenu = new Menu(prompt, options);
        int selectedIndex = colorMenu.Run();

        //BackgroundColor = ConsoleColor.White;   
        switch (selectedIndex)
        {
            case 0:
                ForegroundColor = ConsoleColor.Red;
                WriteLine("lkajsdlkasdjfljasdfljasdfljkasdflkjasdlfkjadsclmaflgvbfg");
                break;
            case 1:
                ForegroundColor = ConsoleColor.Green;
                WriteLine("lkajsdlkasdjfljasdfljasdfljkasdflkjasdlfkjadsclmaflgvbfg");
                break;
            case 2:
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("lkajsdlkasdjfljasdfljasdfljkasdflkjasdlfkjadsclmaflgvbfg");
                break;
            case 3:
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("lkajsdlkasdjfljasdfljasdfljkasdflkjasdlfkjadsclmaflgvbfg");
                break;
        }
        WriteLine("Press any key to return to Main Menu");
        ReadKey(true);

        ResetColor();
        RunMainMenu();
    }
}
