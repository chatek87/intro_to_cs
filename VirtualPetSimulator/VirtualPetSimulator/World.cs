using static System.Console;
namespace VirtualPetSimulator;

class World
{
    public void Run()
    {
        Title = "=== Virtual Pet Simulator ===";
        WriteLine(@"
        _      _               _     ___     _   
 /\   /(_)_ __| |_ _   _  __ _| |   / _ \___| |_ 
 \ \ / / | '__| __| | | |/ _` | |  / /_)/ _ \ __|
  \ V /| | |  | |_| |_| | (_| | | / ___/  __/ |_ 
   \_/ |_|_|   \__|\__,_|\__,_|_| \/    \___|\__|");

        WriteLine("Welcome to the pet simulator!");
        WriteLine("");

        // VirtualPet           = a new type
        // Leo                  = identifier (variable)
        // new VirtualPet();    = constructs a VirtualPet object
        VirtualPet leoTheCat = new VirtualPet("Leo", 12, "Cat", true);
        //leoTheCat.experiencePoints = 10;
        // ^This causes an error because "experiencePoints" is private
        WriteLine("> Pet 1");
        leoTheCat.Greet();  // Invoke Greet(). 
        leoTheCat.Eat("some dry food");
        WriteLine("");

        VirtualPet juniorTheParrot = new VirtualPet("Junior", 50, "Parrot", false);
        WriteLine("> Pet 2");
        juniorTheParrot.Greet();
        juniorTheParrot.Eat("a worm");
        juniorTheParrot.Sleep();
        WriteLine("");

        WriteLine("Press any key to exit...");
        ReadKey();
    }
}

