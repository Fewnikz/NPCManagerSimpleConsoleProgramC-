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
}