using MYClassLibrary2;
internal class Program
{
    private static void Main(string[] args)
    {
        Runway[] runways = { new Runway(), new Runway() };
        CommandCentre commandCentre = new CommandCentre(runways);
        Aircraft aircraft1 = new Aircraft("Boeing", commandCentre);
        Aircraft aircraft2 = new Aircraft("Airbus", commandCentre);

        // Посадка першого літака
        Console.WriteLine("Attempting to land aircraft 1...");
        aircraft1.Land();

        // Посадка другого літака
        Console.WriteLine("\nAttempting to land aircraft 2...");
        aircraft2.Land();

        // Взліт першого літака
        Console.WriteLine("\nAttempting to take off aircraft 1...");
        aircraft1.TakeOff();

        // Взліт другого літака
        Console.WriteLine("\nAttempting to take off aircraft 2...");
        aircraft2.TakeOff();

        Console.ReadLine();
    }
}