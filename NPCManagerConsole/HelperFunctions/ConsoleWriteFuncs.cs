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
    
    // ANSI Colors
    public void RGBAnsiColorNormalText(string r, string g, string b)
    {
        Console.Write($"\x1b[38;2;{r};{g};{b}m");
    }

    public void WelcomeMessage()
    {
        string userInput; 
        
        // Welcome message
        RGBAnsiColorNormalText("218", "109", "46");
        Console.WriteLine("╔────────────────────────╗");
        Console.WriteLine("  Welcome to NPC Manager ");
        Console.WriteLine("╚────────────────────────╝");
        
        // Greet message
        Console.ResetColor();
        Console.WriteLine("\nThis program can be used to manage your NPCs and create them");
        Console.WriteLine("Type the displayed numbers below, to choose what to do");
        
        // Options
        Console.WriteLine("╔───────────────────────────────────╗");
        RGBAnsiColorNormalText("255", "0", "0");
        Console.WriteLine("  Exit program - 0");
        RGBAnsiColorNormalText("10", "255", "50");
        Console.WriteLine("  Create NPC - 1");
        RGBAnsiColorNormalText("77", "224", "235");
        Console.WriteLine("  Show List of NPCs - 2");
        RGBAnsiColorNormalText("26", "37", "193");
        Console.WriteLine("  Show information of every NPC - 3");
        RGBAnsiColorNormalText("213", "226", "33");
        Console.WriteLine("  Show details of an NPC - 4");
        RGBAnsiColorNormalText("175", "32", "210");
        Console.WriteLine("  Edit an NPC - 5");
        Console.ResetColor();
        Console.WriteLine("╚───────────────────────────────────╝");
    }
}