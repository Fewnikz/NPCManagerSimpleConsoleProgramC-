namespace NPCManagerConsole;

public class NPC
{
    // Information
    public string? MainName { get; set; }
    public string? LastName { get; set; }
    public short Age { get; set; }
    public string? Gender { get; set; }
    public string? Description { get; set; }
    public string? Note { get; set; }
    
    // Stats
    public short Strength { get; set; }
    public short Agility { get; set; }
    public short Endurance { get; set; }
}