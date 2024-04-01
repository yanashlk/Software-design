using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary6
{
    // Клас LightTextNode для текстового вузла
    public class LightTextNode : LightNode
    {
        private string text;

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override string ToHtml()
        {
            return $"<p>{text}</p>";
        }
    }
}
