namespace Utilities.ChargeableWeight;

public class ChargeableWeight
{
    public static decimal CalculateChargeableWeight(decimal volume, decimal weight, decimal volumetricConversionFactor, bool returnVolume = false)
    {
        var volumeWeight = volume / volumetricConversionFactor * 1000;
        var chargeableWeight = volumeWeight > weight ? volumeWeight : weight;
 
        if (returnVolume)
        {
            return chargeableWeight / 1000;
        }
 
        return chargeableWeight;
    }
 
    public static decimal CalculateChargeable(TransportMode transportMode, decimal volume, decimal weight, bool returnVolume = false)
    {
        var factor = transportMode switch
        {
            TransportMode.Sea => 1m,
            TransportMode.Road => 2.265m,
            TransportMode.Air => 6m,
            _ => 1
        };
 
        return CalculateChargeableWeight(volume, weight, factor, returnVolume);
    }

    public enum TransportMode
    {
        Sea,
        Road,
        Air
    }
}