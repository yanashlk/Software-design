using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    // Декоратор для зброї
    public class WeaponDecorator : InventoryDecorator
    {
        public WeaponDecorator(Hero hero) : base(hero) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("- Weapon");
        }
    }
}
