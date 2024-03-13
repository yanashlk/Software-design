namespace MYClassLibrary
{
    public abstract class Laptop
    {
        public string Model { get; set; }
        public string Processor { get; set; }
        public abstract void DisplayInfo();
    }
}
