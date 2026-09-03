using NPCManagerConsole;
using NPCManagerConsole.HelperFunctions;

class Program
{
    static void Main(string[] args)
    {
        // Initiate all the objects
        NPCCreator creator = new NPCCreator();
        ConsoleWriteFuncs consoleWriteFuncs = new ConsoleWriteFuncs();
        
        consoleWriteFuncs.WelcomeMessage();
        string userInput = Console.ReadLine() ?? string.Empty;
        if (userInput == "1")
        {
            creator.CreateNPC();
        }
    }
}