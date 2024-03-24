using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    public abstract class InventoryDecorator : Hero
    {
        protected Hero hero;

        public InventoryDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override void ShowInfo()
        {
            hero.ShowInfo();
        }
    }
}
