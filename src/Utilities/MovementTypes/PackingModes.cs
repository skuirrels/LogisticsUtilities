namespace Utilities.MovementTypes;


public record PackingMode(
    int Id,
    string Name,
    string Description);

public static class PackingModes
{
    public static readonly PackingMode FCL = new(1, "FCL", "Full Container Load");
    public static readonly PackingMode LCL = new(2, "LCL", "Less than Container Load");
    public static readonly PackingMode GRP = new(3, "GRP", "Groupage");
    public static readonly PackingMode FTL = new(4, "FTL", "Full Truck Load");
    public static readonly PackingMode LTL = new(5, "LTL", "Less than Truck Load");
    public static readonly PackingMode FLT = new(6, "FLT", "Full Load Trailer");
    public static readonly PackingMode LDT = new(7, "LDT", "Less than Load Trailer");
    public static readonly PackingMode BULK = new(8, "BULK", "Bulk");
    public static readonly PackingMode BREAKBULK = new(9, "BREAKBULK", "Break Bulk");
    public static readonly PackingMode RORO = new(10, "RORO", "Roll On Roll Off");
    public static readonly PackingMode LSE = new(11, "LSE", "Loose");
    public static readonly PackingMode OTHER = new(12, "OTHER", "Other");
    
}