using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    public class DepthFirstIterator<T> : IIterator<T>
    {
        private Stack<T> stack = new Stack<T>();

        public DepthFirstIterator(T root)
        {
            stack.Push(root);
        }

        public T Next()
        {
            T next = stack.Pop();

            List<T> children = GetChildren(next).ToList();
            for (int i = children.Count - 1; i >= 0; i--)
            {
                stack.Push(children[i]);
            }

            return next;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        private IEnumerable<T> GetChildren(T node)
        {
            // Перевіряємо, чи має поточний вузол дочірні елементи
            if (node.Children != null && node.Children.Any())
            {
                // Якщо так, повертаємо дочірні елементи
                return node.Children;
            }
            else
            {
                // Якщо немає дочірніх елементів, повертаємо порожню колекцію
                return Enumerable.Empty<T>();
            }
        }

    }
}
