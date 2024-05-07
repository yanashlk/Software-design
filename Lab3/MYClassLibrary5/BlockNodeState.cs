using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Конкретний стан - блоковий
    public class BlockNodeState : NodeState
    {
        public override void Render(NodeContext context)
        {
            Console.WriteLine("Rendering block node...");
        }
    }
}
