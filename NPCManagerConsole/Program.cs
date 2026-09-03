using NPCManagerConsole;
using NPCManagerConsole.HelperFunctions;

class Program
{
    static void Main(string[] args)
    {
        // Initiate all the objects
        NPCCreator creator = new NPCCreator();
        NPCListShow npcListShow = new NPCListShow();
        ConsoleWriteFuncs consoleWriteFuncs = new ConsoleWriteFuncs();
        
        consoleWriteFuncs.WelcomeMessage();
        string userInput = Console.ReadLine() ?? string.Empty;
        if (userInput == "0")
        {
            Environment.Exit(0);
        }
        if (userInput == "1")
        {
            creator.CreateNPC();
        }
        if (userInput == "2")
        {
            npcListShow.ShowAllNPCs();
        }
    }
}