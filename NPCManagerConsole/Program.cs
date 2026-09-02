using NPCManagerConsole;

class Program
{
    static void Main(string[] args)
    {
        NPC npc = new NPC();
        NPCCreator creator = new NPCCreator();
        creator.CreateNPC();
    }
}