namespace NPCManagerConsole;
using System.Text.Json;

public class NPCListShow
{
    List<NPC> npcs;

    public void ShowAllNPCs()
    {
        // Deserialize json file with all NPCs
        npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json"));
        
        // Clears the console and shows how many NPCs there are
        Console.Clear();
        Console.WriteLine($"Amount of NPCs {npcs.Count}");
        
        // Shows all the NPCs names
        foreach (NPC npc in npcs)
        {
            Console.WriteLine($"NPC Name: {npc.MainName}");
        }
    }
}