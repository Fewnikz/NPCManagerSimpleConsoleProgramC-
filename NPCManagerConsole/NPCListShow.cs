namespace NPCManagerConsole;
using System.Text.Json;

public class NPCListShow
{
    List<NPC> npcs;

    public void ShowAllNPCs()
    {
        npcs = JsonSerializer.Deserialize<List<NPC>>(File.ReadAllText("npcs.json"));
        Console.Clear();
        Console.WriteLine($"Amount of NPCs {npcs.Count}");
        
        foreach (NPC npc in npcs)
        {
            Console.WriteLine($"NPC Name: {npc.MainName}");
        }
    }
}