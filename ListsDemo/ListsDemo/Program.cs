class Program
{
    static void Main(string[] args)
    {
        Console.Title = "=== Lists Demo ===";
        Console.WriteLine("Let's learn about lists.");

        List<string> inventory = new List<string>();
        
        // Array, you use .length but with a list, you use .count
        Console.WriteLine($"You currently have {inventory.Count}X items in your inventory.");
        
        inventory.Add("medallion");
        inventory.Add("fireproof cloak");
        inventory.Add("protective talisman");
        inventory.Insert(1,"bag of dried mushrooms");

        Console.WriteLine($"You currently have {inventory.Count}X items in your inventory.");
        Console.WriteLine($"Is a medallion currently in the list? {inventory.Contains("Medallion")}");
        
        // for (int i = 0; i < inventory.Count; i++)
        // {
        //     Console.WriteLine($"> {inventory[i]}");
        // }
        
        // inventory.ForEach(delegate(string s)
        // {
        //     Console.WriteLine($">>>{s}");
        // });
        //
        foreach (string item in inventory)
        {
            Console.WriteLine($"> {item}");
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}