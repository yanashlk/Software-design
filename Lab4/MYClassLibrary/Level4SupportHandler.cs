using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class Level4SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 4)
            {
                Console.WriteLine("Підтримка рівня 4 обробляє ваш запит.");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Відповідний рівень підтримки не знайдено.");
            }
        }
    }
}
