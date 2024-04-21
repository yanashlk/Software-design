namespace MYClassLibrary5
{
    // Клас, що представляє текстовий документ
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
