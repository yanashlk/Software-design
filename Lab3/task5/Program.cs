using MYClassLibrary5;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення списку CSS класів
        List<string> cssClasses = new List<string> { "example-class" };

        // Створення текстового вузла
        LightNode textNode = new LightTextNode("This is a text node.");

        // Створення елементу вузла з дочірніми елементами
        List<LightNode> children = new List<LightNode> { new LightTextNode("Text inside element."), textNode };
        LightNode elementNode = new LightElementNode("div", "block", "double", cssClasses, children);

        // Виведення outerHTML та innerHTML елементу вузла
        Console.WriteLine("OuterHTML:");
        Console.WriteLine(elementNode.OuterHTML);
        Console.WriteLine("\nInnerHTML:");
        Console.WriteLine(elementNode.InnerHTML);
    }
}