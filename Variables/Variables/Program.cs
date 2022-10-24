class Program
{
    static void Main(string[] args)
    {
        // Variables can be useful for info that you need in multiple places:
        string title = "=== Variables Demo ===";
        Console.Title = title;
        Console.WriteLine(title);

        // Variables enable us to work with user input:
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        // The following ways to concatenate are equivalent:
        Console.WriteLine("Welcome to my silly app, " + name + ".");
        Console.WriteLine($"Welcome to my silly app, {name}.");

        int playerScore = 0;
        // We can concatenated a string and a number together
        Console.WriteLine("Your score is: " + playerScore);
        // We can also do math:
        Console.WriteLine(playerScore + 1);

        double itemCost = 10.25;
        Console.WriteLine("The item's cost is: " + itemCost);

        // Don't do this - type mismatch.
        //int badInt = 44.5;
        // Don't do this - int can only hold numbers of a certain size.
        //int reallyBigNum = 100000000000000000000000000000;

        string quoteOfTheDay = "Perfect is the enemy of good.";
        Console.WriteLine("Here is a quote for you: " + quoteOfTheDay);

        // Declaration - create the variable, without assigning a value.
        string message;
        // Initialization - putting the 1st value into the variable.
        message = $"Hope you've enjoyted this weird app, {name}!";
        Console.WriteLine(message);

        Console.WriteLine("");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
