using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private string displayType;
        private string closingType;
        private List<string> cssClasses;
        private List<LightNode> children;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.cssClasses = cssClasses;
            this.children = children;
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{tagName}");
                foreach (string cssClass in cssClasses)
                {
                    sb.Append($" class=\"{cssClass}\"");
                }
                sb.Append(">");

                if (closingType == "single")
                {
                    sb.Append("/");
                }
                else
                {
                    foreach (LightNode child in children)
                    {
                        sb.Append(child.OuterHTML);
                    }
                    sb.Append($"</{tagName}>");
                }

                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (LightNode child in children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
    }
}
