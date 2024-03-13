using MYClassLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        TechDeviceFactory lenovoFactory = new LenovoTechFactory();
        TechDeviceFactory asusFactory = new AsusTechFactory();
        TechDeviceFactory amazonFactory = new AmazonTechFactory();
        TechDeviceFactory googleFactory = new GoogleTechFactory();

        Laptop lenovoLaptop = lenovoFactory.CreateLaptop();
        Netbook asusNetbook = asusFactory.CreateNetbook();
        EBook amazonKindle = amazonFactory.CreateEBook();
        Smartphone googlePixel = googleFactory.CreateSmartphone();

        lenovoLaptop?.DisplayInfo();
        asusNetbook?.DisplayInfo();
        amazonKindle?.DisplayInfo();
        googlePixel?.DisplayInfo();
    }
}