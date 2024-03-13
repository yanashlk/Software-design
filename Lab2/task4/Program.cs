using task4;

internal class Program
{
    private static void Main(string[] args)
    {
        Virus originalVirus = new Virus
        {
            Name = "Virus1",
            Species = "Influenza",
            Age = 1,
            Weight = 0.5
        };

        VirusFamily family = new VirusFamily();
        family.AddVirus(originalVirus);

        // Додаємо дітей до оригінального вірусу
        for (int i = 0; i < 3; i++)
        {
            Virus child = (Virus)originalVirus.Clone();
            child.Name += $"-Child{i + 1}";
            child.Age += i + 1;
            family.AddVirus(child);
            originalVirus.Children.Add(child);
        }

        // Клонуємо всю сім'ю вірусів
        VirusFamily clonedFamily = new VirusFamily();
        foreach (var virus in family.viruses)
        {
            Virus clonedVirus = (Virus)virus.Clone();
            clonedFamily.AddVirus(clonedVirus);
        }

        // Відображаємо інформацію про оригінальну та клоновану сім'ю вірусів
        Console.WriteLine("Original Family:");
        family.DisplayFamilyInfo();

        Console.WriteLine("\n\nCloned Family:");
        clonedFamily.DisplayFamilyInfo();
    }
}