using Utilities;

class Program
{
    static void Main(string[] args)
    {
        var incoterms = GetThreeIncoterms();
        foreach (var incoterm in incoterms)
        {
            Console.WriteLine();
            Console.WriteLine($"Id: {incoterm.Id}, Name: {incoterm.Name}, Description: {incoterm.Description}, Transfer Risk: {incoterm.TransferOfRisk}" );
            foreach (var charge in incoterm.ChargeResponsibilities)
            {
                Console.WriteLine($"Charge Category: {charge.Key}, Party: {charge.Value}");
            }
        }
    }

    static List<Incoterm> GetThreeIncoterms()
    {
        return new List<Incoterm>
        {
            Incoterms.EXW,
            Incoterms.FCA,
            Incoterms.FAS
        };
    }
}