using Utilities.MovementTypes;

namespace Utilities.Tests;

public class TransportModeTests
{
    [Fact]
    public void SeaTransportModeTest()
    {
        var sea = TransportModes.SEA;
        Assert.Equal(1, sea.Id);
        Assert.Equal("SEA", sea.Name);
        Assert.Equal("Sea", sea.Description);
        Assert.Equal(new List<PackingMode> { PackingModes.FCL, PackingModes.LCL, PackingModes.GRP, PackingModes.BREAKBULK }, sea.PackingModes);
    }

    [Fact]
    public void AirTransportModeTest()
    {
        var air = TransportModes.AIR;
        Assert.Equal(2, air.Id);
        Assert.Equal("AIR", air.Name);
        Assert.Equal("Air", air.Description);
        Assert.Equal(new List<PackingMode> { PackingModes.LSE }, air.PackingModes);
    }

    // TODO: add test methods for ROAD, RAIL, COURIER, POST, MULTIMODAL, PIPELINE, INLANDWATER, OTHER
}