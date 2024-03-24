using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    // Декоратор для артефактів
    public class ArtifactDecorator : InventoryDecorator
    {
        public ArtifactDecorator(Hero hero) : base(hero) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("- Artifact");
        }
    }
}
