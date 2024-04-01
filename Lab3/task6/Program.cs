using MYClassLibrary6;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        // Зчитування тексту книги з файлу
        string[] lines = File.ReadAllLines("book.txt");

        // Розбийття тексту на рядки
        List<LightNode> nodes = new List<LightNode>();
        foreach (string line in lines)
        {
            // Визначення типу елементу в HTML
            LightNode node;
            if (line.Length < 20)
            {
                node = new LightElementNode("h2", new List<LightNode> { new LightTextNode(line) });
            }
            else if (line.StartsWith(" "))
            {
                node = new LightElementNode("blockquote", new List<LightNode> { new LightTextNode(line.Trim()) });
            }
            else
            {
                node = new LightTextNode(line);
            }

            // Додавання елемента вузла до списку
            nodes.Add(node);
        }

        LightElementNode htmlBody = new LightElementNode("body", nodes);
        LightElementNode htmlDocument = new LightElementNode("html", new List<LightNode> { htmlBody });
        string fullHtml = htmlDocument.ToHtml();

        // Виведення HTML верстки
        Console.WriteLine(fullHtml);

        // Виміренняе обсягу пам'яті
        MeasureMemory(fullHtml);
    }

    static void MeasureMemory(string html)
    {
        using (Process proc = Process.GetCurrentProcess())
        {
            // Отримуємо використання пам'яті у байтах
            long memoryUsed = proc.PrivateMemorySize64;

            // Конвертуємо байти у кілобайти для кращого читання
            double memoryUsedKB = memoryUsed / 1024.0;

            Console.WriteLine($"Використання пам'яті: {memoryUsedKB} KB");
        }
    }
}