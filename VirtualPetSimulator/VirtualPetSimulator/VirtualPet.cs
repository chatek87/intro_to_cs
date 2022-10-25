using static System.Console;
namespace VirtualPetSimulator;

class VirtualPet
{
    // Field
    // public   = access modifier
    // string   = type
    // Name     = identifier
    public string FullName;
    public int Age;
    public double HungerLevel;
    public string Species;
    public bool IsAwake;
    private int experiencePoints;

    public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
    {
        //WriteLine("Pet being constructed");
        FullName = petName;
        Age = petAge;   
        Species = petSpecies;   
        IsAwake = petIsAwake;   

    }

    // Method definition:
    public void Greet()
    {
        WriteLine($"My name is {FullName}, the {Species}!");
        WriteLine($"I am {Age} years old.");
        WriteLine($"Is awake? {IsAwake}.");
    }

    public void Sleep()
    {
        IsAwake = false;
        WriteLine($"{FullName} is now happily snoring... Zzzzz");
    }

    // One input (a.K.A. a parameter)
    public void Eat(string foodName)
    {
        WriteLine($"{FullName} is now eating {foodName}.");
    }

    public void Play()
    {

    }

    public void Speak()
    {

    }
}

