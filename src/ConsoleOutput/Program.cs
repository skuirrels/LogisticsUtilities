using Utilities;
using Utilities.MovementTypes;
using Incoterm = Utilities.Incoterm;

class Program
{
    static void Main(string[] args)
    {
        //IncotermsWithOutCharges();
        IncotermsWithCharges();
        PrintTransportModesWithPackingModes();

        void IncotermsWithOutCharges()
        {
            var incoterms = new List<Incoterm>
            {
                Incoterms.EXW,
                Incoterms.FCA,
                Incoterms.FAS,
                Incoterms.FOB,
                Incoterms.CFR,
                Incoterms.CIF,
                Incoterms.CPT,
                Incoterms.CIP,
                Incoterms.DAP,
                Incoterms.DPU,
                Incoterms.DDP
            };

            foreach (var incoterm in incoterms)
            {
                Console.WriteLine(
                    $"Id: {incoterm.Id}, Name: {incoterm.Name}, Description: {incoterm.Description}, Transfer Risk: {incoterm.TransferOfRisk}");
            }
        }

        void IncotermsWithCharges()
        {
            var incoterms = new List<Incoterm>
            {
                Incoterms.EXW,
                Incoterms.FCA,
                Incoterms.FAS,
                Incoterms.FOB,
                Incoterms.CFR,
                Incoterms.CIF,
                Incoterms.CPT,
                Incoterms.CIP,
                Incoterms.DAP,
                Incoterms.DPU,
                Incoterms.DDP
            };

            foreach (var incoterm in incoterms)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"Id: {incoterm.Id}, Name: {incoterm.Name}, Description: {incoterm.Description}, Transfer Risk: {incoterm.TransferOfRisk}");
                foreach (var charge in incoterm.ChargeResponsibilities)
                {
                    Console.WriteLine($"Charge Category: {charge.Key}, Party: {charge.Value}");
                }
            }
        }

        void PrintTransportModesWithPackingModes()
        {
            var transportModes = new List<TransportMode>
            {
                TransportModes.SEA,
                TransportModes.AIR,
                TransportModes.ROAD,
                TransportModes.RAIL,
                TransportModes.COURIER,
                TransportModes.POST,
                TransportModes.MULTIMODAL,
                TransportModes.PIPELINE,
                TransportModes.INLANDWATER,
                TransportModes.OTHER
            };

            foreach (var transportMode in transportModes)
            {
                Console.WriteLine(
                    $"Id: {transportMode.Id}, Name: {transportMode.Name}, Description: {transportMode.Description}");
                Console.WriteLine("Packing Modes:");
                foreach (var packingMode in transportMode.PackingModes)
                {
                    Console.WriteLine(
                        $"Id: {packingMode.Id}, Name: {packingMode.Name}, Description: {packingMode.Description}");
                }

                Console.WriteLine();
            }
        }
    }
}