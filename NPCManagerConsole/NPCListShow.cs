namespace NPCManagerConsole;
using System.Text.Json;

public class NPCListShow
{
    List<NPC> npcs;

    public void ShowAllNPCs()
    {
        // Deserialize json file with all NPCs
        npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json")) ?? [];
        
        // Clears the console and shows how many NPCs there are
        Console.Clear();
        Console.WriteLine($"Amount of NPCs: {npcs.Count}");
        
        // Shows all the NPCs names
        foreach (NPC npc in npcs)
        {
            Console.WriteLine($"NPC Name: {npc.MainName}");
        }
    }

    public void ShowAllNPCsDetailed()
    {
        // Deserialize json file with all NPCs
        npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json")) ?? [];
        
        // Clears the console and shows how many NPCs there are
        Console.Clear();
        Console.WriteLine($"Amount of NPCs {npcs.Count}");
        
        // Shows all the NPCs names
        foreach (NPC npc in npcs)
        {
            // Shows all the NPCs info
            Console.WriteLine($"NPC Info:");
            Console.WriteLine($"\tNPC Name: {npc.MainName}");
            Console.WriteLine($"\tNPC Last Name: {npc.LastName}");
            Console.WriteLine($"\tNPC Age: {npc.Age}");
            Console.WriteLine($"\tNPC Gender: {npc.Gender}");
            Console.WriteLine($"\tNPC Description: {npc.Description}");
            Console.WriteLine($"\tNPC Note: {npc.Note}");
            
            // Shows all the NPCs stats
            Console.WriteLine($"NPC Stats:");
            Console.WriteLine($"\tNPC Strength: {npc.Strength}");
            Console.WriteLine($"\tNPC Agility: {npc.Agility}");
            Console.WriteLine($"\tNPC Endurance: {npc.Endurance}\n");
        }
    }
}