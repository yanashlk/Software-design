using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    public class ClothingDecorator : InventoryDecorator
    {
        public ClothingDecorator(Hero hero) : base(hero) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("- Clothing");
        }
    }
}
