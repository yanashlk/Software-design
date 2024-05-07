using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Відвідувач для виводу вузлів в форматі Markdown
    public class MarkdownVisitor
    {
        // Метод для відвідування текстового вузла
        public void VisitTextNode(LightTextNode node)
        {
            Console.WriteLine(node.OuterHTML);
        }

        // Метод для відвідування елемента вузла
        public void VisitElementNode(LightElementNode node)
        {
            Console.WriteLine($"<{node.TagName}>{node.InnerHTML}</{node.TagName}>");
        }
    }
}
