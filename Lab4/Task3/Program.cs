using MYClassLibrary3;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створюємо текстовий елемент
        LightNode textNode = new LightTextNode("Hello, World!");

        // Створюємо елемент div з класом "container" та додамо до нього текстовий елемент
        LightNode divElement = new LightElementNode("div", "block", "double", new List<string> { "container" }, new List<LightNode> { textNode });

        // Додаємо слухача події "click" до елементу div
        LightElementNode divWithEvent = (LightElementNode)divElement;
        divWithEvent.AddEventListener("click", () => Console.WriteLine("Div was clicked!"));

        // Виводимо результат
        Console.WriteLine(divElement.OuterHTML);

        // Викликаємо подію "click"
        divWithEvent.TriggerEvent("click");

        Console.ReadLine();
    }
}