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
        Assert.Equal([PackingModes.FCL, PackingModes.LCL, PackingModes.GRP, PackingModes.BREAKBULK], sea.PackingModes);
    }

    [Fact]
    public void AirTransportModeTest()
    {
        var air = TransportModes.AIR;
        Assert.Equal(2, air.Id);
        Assert.Equal("AIR", air.Name);
        Assert.Equal("Air", air.Description);
        Assert.Equal([PackingModes.LSE], air.PackingModes);
    }

    // TODO: add test methods for ROAD, RAIL, COURIER, POST, MULTIMODAL, PIPELINE, INLANDWATER, OTHER

    [Fact]
    public void RoadTransportModeTest()
    {
        var road = TransportModes.ROAD;
        Assert.Equal(3, road.Id);
        Assert.Equal("ROAD", road.Name);
        Assert.Equal("Road", road.Description);
        Assert.Equal([PackingModes.FTL, PackingModes.LTL, PackingModes.FLT, PackingModes.LDT], road.PackingModes);
    }

    [Fact]
    public void RailTransportModeTest()
    {
        var rail = TransportModes.RAIL;
        Assert.Equal(4, rail.Id);
        Assert.Equal("RAIL", rail.Name);
        Assert.Equal("Rail", rail.Description);
        Assert.Equal([PackingModes.FCL, PackingModes.LCL, PackingModes.GRP], rail.PackingModes);
    }

    [Fact]
    public void CourierTransportModeTest()
    {
        var courier = TransportModes.COURIER;
        Assert.Equal(5, courier.Id);
        Assert.Equal("COURIER", courier.Name);
        Assert.Equal("Courier", courier.Description);
        Assert.Equal([PackingModes.OBC, PackingModes.UNA], courier.PackingModes);
    }

    [Fact]
    public void PostTransportModeTest()
    {
        var post = TransportModes.POST;
        Assert.Equal(6, post.Id);
        Assert.Equal("POST", post.Name);
        Assert.Equal("Post", post.Description);
        Assert.Equal([PackingModes.LSE], post.PackingModes);
    }

    [Fact]
    public void MultimodalTransportModeTest()
    {
        var multimodal = TransportModes.MULTIMODAL;
        Assert.Equal(7, multimodal.Id);
        Assert.Equal("MULTIMODAL", multimodal.Name);
        Assert.Equal("Multimodal", multimodal.Description);
        Assert.Equal([PackingModes.FCL, PackingModes.LCL, PackingModes.GRP, PackingModes.FTL, PackingModes.LTL], multimodal.PackingModes);
    }

    [Fact]
    public void PipelineTransportModeTest()
    {
        var pipeline = TransportModes.PIPELINE;
        Assert.Equal(8, pipeline.Id);
        Assert.Equal("PIPELINE", pipeline.Name);
        Assert.Equal("Pipeline", pipeline.Description);
        Assert.Equal([PackingModes.BULK], pipeline.PackingModes);
    }

    [Fact]
    public void InlandWaterTransportModeTest()
    {
        var inlandWater = TransportModes.INLANDWATER;
        Assert.Equal(9, inlandWater.Id);
        Assert.Equal("INLANDWATER", inlandWater.Name);
        Assert.Equal("Inland Water", inlandWater.Description);
        Assert.Equal([PackingModes.FCL, PackingModes.LCL, PackingModes.GRP], inlandWater.PackingModes);
    }

    [Fact]
    public void OtherTransportModeTest()
    {
        var other = TransportModes.OTHER;
        Assert.Equal(10, other.Id);
        Assert.Equal("OTHER", other.Name);
        Assert.Equal("Other", other.Description);
        Assert.Equal([PackingModes.OTHER], other.PackingModes);
    }
}