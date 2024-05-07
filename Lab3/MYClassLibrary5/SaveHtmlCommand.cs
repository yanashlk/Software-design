using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Конкретна команда для збереження HTML-коду у файл
    public class SaveHtmlCommand : ICommand
    {
        private string htmlContent;

        public SaveHtmlCommand(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public void Execute()
        {
            File.WriteAllText("output.html", htmlContent);
            Console.WriteLine("HTML code saved to output.html");
        }
    }
}
