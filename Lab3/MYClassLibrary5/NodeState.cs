using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Базовий клас стану
    public abstract class NodeState
    {
        public abstract void Render(NodeContext context);
    }
}
