using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Клас, що представляє збережений стан текстового документу
    public class Memento
    {
        public string Content { get; }

        public Memento(string content)
        {
            Content = content;
        }
    }
}
