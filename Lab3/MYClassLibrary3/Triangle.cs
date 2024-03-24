using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary3
{
    public class Triangle : Shape
    {
        public Triangle(Renderer renderer) : base(renderer) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
            renderer.Render();
        }
    }
}
