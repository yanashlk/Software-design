using MYClassLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення обробників
        SupportHandler level1 = new Level1SupportHandler();
        SupportHandler level2 = new Level2SupportHandler();
        SupportHandler level3 = new Level3SupportHandler();
        SupportHandler level4 = new Level4SupportHandler();

        // Налаштування ланцюжка відповідальностей
        level1.SetNextHandler(level2);
        level2.SetNextHandler(level3);
        level3.SetNextHandler(level4);

        // Симуляція запитів
        Console.WriteLine("Введіть свій рівень підтримки (1-4):");
        int userLevel = Convert.ToInt32(Console.ReadLine());
        level1.HandleRequest(userLevel);

        Console.ReadLine();
    }
}