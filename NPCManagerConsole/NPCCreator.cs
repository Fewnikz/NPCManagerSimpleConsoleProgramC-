using NPCManagerConsole.HelperFunctions;

namespace NPCManagerConsole;
using System.Text.Json;

public class NPCCreator
{
    private NPC newNPC = new NPC();
    private List<NPC> npcs;
    
    private ConsoleWriteFuncs _consoleWriteFuncs = new ConsoleWriteFuncs();
        
    // Method that asks the user to enter all the info for the NPC
    // And returns the NPC object with the new values
    private void InputNPCInfo()
    {
        Console.Clear();
        Console.WriteLine("Enter NPC Info. \nLeave any fields blank if they are not needed");
        
        // NPC Info
        newNPC.MainName = _consoleWriteFuncs.InputNPCInfo("NPC Name");
        newNPC.LastName = _consoleWriteFuncs.InputNPCInfo("NPC Last Name");
        newNPC.Age = Convert.ToInt16(_consoleWriteFuncs.InputNPCInfo("NPC Age"));
        newNPC.Gender = _consoleWriteFuncs.InputNPCInfo("NPC Gender");
        newNPC.Description = _consoleWriteFuncs.InputNPCInfo("NPC Description");
        newNPC.Note = _consoleWriteFuncs.InputNPCInfo("NPC Note");
        
        // NPC Stats
        newNPC.Strength = Convert.ToInt16(_consoleWriteFuncs.InputNPCInfo("NPC Strength"));
        newNPC.Agility = Convert.ToInt16(_consoleWriteFuncs.InputNPCInfo("NPC Agility"));
        newNPC.Endurance = Convert.ToInt16(_consoleWriteFuncs.InputNPCInfo("NPC Endurance"));
    }

    // Method for creating a new NPC
    public void CreateNPC()
    {
        InputNPCInfo();
        JsonSerializerOptions serializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        try
        {
            npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json"), serializerOptions) ?? [];
        }
        catch
        {
            Console.WriteLine("Could not read npcs.json \n Creating new json file...");
            File.WriteAllText("npcs.json", "[]");
            npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json"), serializerOptions) ?? [];
        }
        
        Console.WriteLine(newNPC.MainName);
        
        npcs.Add(newNPC);
        string jsonFile = JsonSerializer.Serialize(npcs, serializerOptions);
        File.WriteAllText("npcs.json", jsonFile);
    }
}