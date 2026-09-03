using NPCManagerConsole.HelperFunctions;

namespace NPCManagerConsole;

public class UserInput
{
    // Initiate all the objects
    NPCCreator creator = new NPCCreator();
    NPCListShow npcListShow = new NPCListShow();
    ConsoleWriteFuncs consoleWriteFuncs = new ConsoleWriteFuncs();

    public void MenuOptions()
    {
        // Lets the user type input for the input
        string userInput = Console.ReadLine() ?? string.Empty;
        
        do
        {
            // Checks what option the user has typed
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
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                userInput = string.Empty;
                Console.Clear();
                continue;
            }
            
            // Asks the user again to type the option they want to choose
            consoleWriteFuncs.WelcomeMessage();
            userInput = Console.ReadLine() ?? string.Empty;
        } while (userInput != "0");
    }
}