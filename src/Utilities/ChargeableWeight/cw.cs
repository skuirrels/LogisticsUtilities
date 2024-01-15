namespace Utilities.ChargeableWeight
{
    public static class ChargeableWeightCalculator
    {
        // Constants for conversion factors
        private const decimal DefaultSeaConversionFactor = 1m;
        private const decimal DefaultRoadConversionFactor = 2.265m;
        private const decimal DefaultAirConversionFactor = 6m;

        // Method Overloads for Custom Conversion Factor
        public static decimal CalculateChargeableWeight(decimal volume, decimal weight, decimal volumetricConversionFactor)
            => Math.Max(volume * 1000 / volumetricConversionFactor, weight);

        public static decimal CalculateVolumeChargeableWeight(decimal volume, decimal weight, decimal volumetricConversionFactor)
            => CalculateChargeableWeight(volume, weight, volumetricConversionFactor) / 1000;

        // Overload allowing optional custom conversion factor
        public static decimal CalculateChargeableWeight(TransportMode transportMode, decimal volume, decimal weight, decimal? customConversionFactor = null)
        {
            decimal factor = customConversionFactor ?? GetDefaultConversionFactor(transportMode);
            return CalculateChargeableWeight(volume, weight, factor);
        }

        private static decimal GetDefaultConversionFactor(TransportMode transportMode)
        {
            return transportMode switch
            {
                TransportMode.Sea => DefaultSeaConversionFactor,
                TransportMode.Road => DefaultRoadConversionFactor,
                TransportMode.Air => DefaultAirConversionFactor,
                _ => throw new ArgumentOutOfRangeException(nameof(transportMode), $"Unsupported transport mode: {transportMode}")
            };
        }

        public enum TransportMode
        {
            Sea,
            Road,
            Air
        }
    }
}