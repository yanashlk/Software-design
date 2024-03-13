using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class HuaweiSmartphone : Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Huawei Smartphone - Brand: {Brand}, OS: {OS}");
        }
    }
}
