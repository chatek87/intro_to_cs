class Program
{
    static void Main(string[] args)
    {
        Console.Title = "=== Lists Demo ===";
        Console.WriteLine("Let's learn about lists.");

        List<string> inventory = new List<string>();
        
        // Array, you use .length but with a list, you use .count
        Console.WriteLine($"You currently have {inventory.Count}X items in your inventory.");
        
        inventory.Add("A medallion");
        inventory.Add("A fireproof cloak");
        inventory.Add("A protective talisman");
        inventory.Insert(1,"A bag of dried mushrooms");

        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"> {inventory[i]}");
        }
        
        // foreach (string item in inventory)
        // {
        //     Console.WriteLine(inventory);
        // }
        
        Console.WriteLine($"You currently have {inventory.Count}X items in your inventory.");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}