namespace MYClassLibrary3
{
    public abstract class Shape
    {
        protected Renderer renderer;

        // Конструктор з параметром типу Renderer
        protected Shape(Renderer renderer)
        {
            this.renderer = renderer;
        }

        // Абстрактний метод для відображення фігури
        public abstract void Draw();
    }
}
