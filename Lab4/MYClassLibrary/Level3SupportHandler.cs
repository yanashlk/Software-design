﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class Level3SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Підтримка рівня 3 обробляє ваш запит.");
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
