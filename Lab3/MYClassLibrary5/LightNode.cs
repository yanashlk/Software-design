namespace MYClassLibrary5
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        // Шаблонний метод для виклику методу Render
        public virtual void Render()
        {
            Console.WriteLine("Rendering node...");
            // Виклик перевизначеного методу Render в дочірньому класі
        }
        // Метод для прийняття відвідувача
        public abstract void Accept(MarkdownVisitor visitor);
    }
}
