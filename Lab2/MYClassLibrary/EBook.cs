using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public abstract class EBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public abstract void DisplayInfo();
    }
}
