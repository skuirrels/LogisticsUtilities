namespace Utilities.MovementTypes;

public record TransportMode(
    int Id,
    string Name,
    string Description,
    List<PackingMode> PackingModes);



public class TransportModes
{
    public static readonly TransportMode SEA = new(1, "SEA", "Sea", new List<PackingMode> { PackingModes.FCL, PackingModes.LCL, PackingModes.GRP, PackingModes.BREAKBULK });
    public static readonly TransportMode AIR = new(2, "AIR", "Air", new List<PackingMode> { PackingModes.LSE });
    public static readonly TransportMode ROAD = new(3, "ROAD", "Road", new List<PackingMode> { PackingModes.FTL, PackingModes.LTL, PackingModes.FLT, PackingModes.LDT });
    public static readonly TransportMode RAIL = new(4, "RAIL", "Rail", new List<PackingMode> { PackingModes.FCL, PackingModes.LCL, PackingModes.GRP });
    public static readonly TransportMode COURIER = new(5, "COURIER", "Courier", new List<PackingMode> { PackingModes.OBC, PackingModes.UNA });
    public static readonly TransportMode POST = new(6, "POST", "Post", new List<PackingMode> { PackingModes.LSE });
    public static readonly TransportMode MULTIMODAL = new(7, "MULTIMODAL", "Multimodal", new List<PackingMode> { PackingModes.FCL, PackingModes.LCL, PackingModes.GRP, PackingModes.FTL, PackingModes.LTL });
    public static readonly TransportMode PIPELINE = new(8, "PIPELINE", "Pipeline", new List<PackingMode> { PackingModes.BULK });
    public static readonly TransportMode INLANDWATER = new(9, "INLANDWATER", "Inland Water", new List<PackingMode> { PackingModes.FCL, PackingModes.LCL, PackingModes.GRP });
    public static readonly TransportMode OTHER = new(10, "OTHER", "Other", new List<PackingMode> { PackingModes.OTHER});
}