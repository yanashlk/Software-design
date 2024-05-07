using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    public class NodeContext
    {
        private NodeState currentState;

        public NodeContext()
        {
            // Початковий стан - блоковий
            currentState = new BlockNodeState();
        }

        // Зміна стану на інлайновий
        public void SwitchToInlineState()
        {
            currentState = new InlineNodeState();
        }

        // Зміна стану на блоковий
        public void SwitchToBlockState()
        {
            currentState = new BlockNodeState();
        }

        // Метод, який використовує поточний стан
        public void Render()
        {
            currentState.Render(this);
        }
    }
}
