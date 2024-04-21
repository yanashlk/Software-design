using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary3
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private string displayType;
        private string closingType;
        private List<string> cssClasses;
        private List<LightNode> children;
        private Dictionary<string, List<Action>> eventListeners;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.cssClasses = cssClasses;
            this.children = children;
            this.eventListeners = new Dictionary<string, List<Action>>();
        }

        public void AddEventListener(string eventType, Action listener)
        {
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = new List<Action>();
            }
            eventListeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in eventListeners[eventType])
                {
                    listener.Invoke();
                }
            }
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

                foreach (var eventType in eventListeners.Keys)
                {
                    sb.Append($" {eventType}=\"{eventType}_handler()\"");
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

                foreach (var eventType in eventListeners.Keys)
                {
                    sb.Append($"<script>function {eventType}_handler(){{}};</script>");
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
