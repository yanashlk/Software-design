using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    public class LightElementNodeIterator : IIterator<LightElementNode>
    {
        private readonly LightElementNode _root;
        private readonly Stack<LightElementNode> _stack;

        public LightElementNodeIterator(LightElementNode root)
        {
            _root = root;
            _stack = new Stack<LightElementNode>();
            _stack.Push(_root);
        }

        public LightElementNode Next()
        {
            if (!HasNext()) return null;

            var currentNode = _stack.Pop();

            foreach (var child in currentNode.Children)
            {
                if (child is LightElementNode)
                {
                    _stack.Push((LightElementNode)child);
                }
            }

            return currentNode;
        }

        public bool HasNext()
        {
            return _stack.Count > 0;
        }
    }

}
