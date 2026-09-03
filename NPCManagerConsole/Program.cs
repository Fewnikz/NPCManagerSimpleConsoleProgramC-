using NPCManagerConsole;
using NPCManagerConsole.HelperFunctions;

class Program
{
    static void Main(string[] args)
    {
        // Initiate all the objects
        ConsoleWriteFuncs consoleWriteFuncs = new ConsoleWriteFuncs();
        UserInput userInput = new UserInput();
        
        // Calling the methods
        consoleWriteFuncs.WelcomeMessage();
        userInput.MenuOptions();
    }
}