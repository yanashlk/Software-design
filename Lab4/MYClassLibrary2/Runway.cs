namespace MYClassLibrary2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();

        public bool IsActive { get; private set; } = false;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
        }

    }
}
