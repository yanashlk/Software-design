using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class Level1SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Підтримка рівня 1 обробляє ваш запит.");
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
