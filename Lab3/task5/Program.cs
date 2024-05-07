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

        // Створення об'єкту команди для збереження HTML-коду
        string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
        ICommand saveHtmlCommand = new SaveHtmlCommand(htmlContent);

        // Створення та налаштування інвокера команди
        CommandInvoker invoker = new CommandInvoker();
        invoker.SetCommand(saveHtmlCommand);

        // Виконання команди
        invoker.ExecuteCommand();

        // Створення контексту
        NodeContext context = new NodeContext();

        // Рендеринг початкового стану - блокового
        context.Render();

        // Зміна стану на інлайновий
        context.SwitchToInlineState();

        // Рендеринг зміненого стану - інлайнового
        context.Render();

        // Створення списку дочірніх вузлів
        List<LightNode> newChildren = new List<LightNode> { new LightTextNode("Text inside element.") };

        // Створення нового елемента вузла з визначеним closingType
        LightNode newElementNode = new LightElementNode("div", "block", "double", cssClasses, newChildren);

        // Створення відвідувача
        MarkdownVisitor markdownVisitor = new MarkdownVisitor();

        // Відвідування нового вузла
        newElementNode.Accept(markdownVisitor);
    }
}
