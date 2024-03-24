using MYClassLibrary3;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення об'єктів фігур
        Shape circle = new Circle(new VectorRenderer());
        Shape square = new Square(new RasterRenderer());
        Shape triangle = new Triangle(new VectorRenderer());

        // Відображення фігур
        circle.Draw();
        square.Draw();
        triangle.Draw();
    }
}