using static System.Console;
namespace ConditionalsDemo;

class Program
{
    static void Main(string[] args)
    {
        BackgroundColor = ConsoleColor.DarkBlue;
        ForegroundColor = ConsoleColor.Yellow;
        Clear();

        Title = "=== Conditionals Demo ===";

        WriteLine("Clothing recommendations for the weather:");
        // Operators
        int temp = 0;
        temp += 1;
        WriteLine($"Is the temp 0? {temp == 0}");
        WriteLine($"Is the temp anything but 0? {temp != 0}");
        // Comparison operators: < > <= >=
        WriteLine($"Is the temp less than 32? {temp < 32}");
        // Int inputs
        // Branching logic

        WriteLine("\nPress any key to exit...");
        ReadKey();
    }
}