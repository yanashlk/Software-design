using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public abstract class TechDeviceFactory
    {
        public abstract Laptop CreateLaptop();
        public abstract Netbook CreateNetbook();
        public abstract EBook CreateEBook();
        public abstract Smartphone CreateSmartphone();

    }
    public class LenovoTechFactory : TechDeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new LenovoLaptop();
        }

        public override Netbook CreateNetbook()
        {
            return null;
        }

        public override EBook CreateEBook()
        {
            return null;
        }

        public override Smartphone CreateSmartphone()
        {
            return null;
        }
    }

    public class AsusTechFactory : TechDeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return null;
        }

        public override Netbook CreateNetbook()
        {
            return new AsusNetbook();
        }

        public override EBook CreateEBook()
        {
            return null;
        }

        public override Smartphone CreateSmartphone()
        {
            return null;
        }
    }

    public class AmazonTechFactory : TechDeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return null;
        }

        public override Netbook CreateNetbook()
        {
            return null;
        }

        public override EBook CreateEBook()
        {
            return new AmazonKindle();
        }

        public override Smartphone CreateSmartphone()
        {
            return null;
        }
    }

    public class GoogleTechFactory : TechDeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return null;
        }

        public override Netbook CreateNetbook()
        {
            return null;
        }

        public override EBook CreateEBook()
        {
            return null;
        }

        public override Smartphone CreateSmartphone()
        {
            return new GooglePixel();
        }
    }
}
