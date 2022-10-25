using static System.Console;
namespace VirtualPetSimulator;

class Program
{
    static void Main(string[] args)
    {
        World myWorld = new World();
        myWorld.Run();
    }
}