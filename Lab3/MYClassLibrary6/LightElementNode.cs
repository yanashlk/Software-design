using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary6
{
    // Клас LightElementNode для елементу вузла
    public class LightElementNode : LightNode
    {
        private string tagName;
        private List<LightNode> children;

        public LightElementNode(string tagName, List<LightNode> children)
        {
            this.tagName = tagName;
            this.children = children;
        }

        public override string ToHtml()
        {
            string html = $"<{tagName}>";
            foreach (var child in children)
            {
                html += child.ToHtml();
            }
            html += $"</{tagName}>";
            return html;
        }
    }
}
