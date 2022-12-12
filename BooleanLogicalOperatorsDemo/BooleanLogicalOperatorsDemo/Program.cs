using static System.Console;

namespace BooleanLogicalOperatorsDemo;

class Program
{
    static void Main(string[] args)
    {
        var game = new RPSGame();
        game.Play();



        //WriteLine("=== Boolean Logical Operators ===");

        //// NOT operator, uniary (has one input)
        //bool hasMap = !true;
        //WriteLine($"Has map? {hasMap}");
        //WriteLine($"NOT has map? {!hasMap}");
        //WriteLine($"NOT has map? {hasMap == false}");
        //if (!hasMap)
        //{
        //    WriteLine("You can't get out of the maze without the map.");
        //}

        //// AND operator, binary (has two inputs)
        //int petHappinessLevel = 100;
        //int petHungerLevel = 0;
        //WriteLine($"Happy pet: {petHappinessLevel > 80}");
        //WriteLine($"Satisfied pet: {petHungerLevel < 80}");
        //WriteLine($"Good pet parent: {petHappinessLevel  > 80 && petHungerLevel < 10}");


     }
}
    