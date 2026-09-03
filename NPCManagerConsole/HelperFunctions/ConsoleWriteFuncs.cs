namespace NPCManagerConsole.HelperFunctions;

public class ConsoleWriteFuncs
{
    public string InputNPCInfo (string writeText)
    {
        Console.WriteLine($"Enter {writeText}:");
        string value = Console.ReadLine() ?? string.Empty;
        Console.Clear();
        return value;
    }

    public void WelcomeMessage()
    {
        string userInput; 
        
        // Welcome message
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("######################");
        Console.WriteLine("Welcome to NPC Manager");
        Console.WriteLine("######################");
        
        // Greet message
        Console.ResetColor();
        Console.WriteLine("\nThis program can be used to manage your NPCs and create them");
        Console.WriteLine("Type the displayed numbers below, to choose what to do \n");
        
        // Options
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Exit program - 0");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Create NPC - 1");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Show List of NPCs - 2");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Show details of an NPC - 3");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Edit an NPC - 4");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Show information of every NPC - 5");
        Console.ResetColor();
    }
}