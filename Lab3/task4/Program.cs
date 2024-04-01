using MYClassLibrary4;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення екземпляру SmartTextReader
        SmartTextReader reader = new SmartTextReader();

        // Читання файлу
        char[,] textArray = reader.ReadTextFile("example.txt");

        // Виведення прочитаного тексту
        Console.WriteLine("Contents of the file:");
        for (int i = 0; i < textArray.GetLength(0); i++)
        {
            for (int j = 0; j < textArray.GetLength(1); j++)
            {
                Console.Write(textArray[i, j]);
            }
            Console.WriteLine();
        }

        // Створення екземпляру SmartTextChecker (проксі з логуванням)
        SmartTextChecker checker = new SmartTextChecker();

        // Читання файлу з логуванням
        char[,] checkedTextArray = checker.ReadTextFile("example.txt");

        // Створення екземпляру SmartTextReaderLocker (проксі з обмеженням доступу)
        SmartTextReaderLocker locker = new SmartTextReaderLocker(@"example\d+\.txt");

        // Читання лімітованого файлу
        char[,] limitedTextArray = locker.ReadTextFile("example1.txt");
    }
}