using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary
{
    public class AmazonKindle : EBook
    {
        public AmazonKindle()
        {
            Title = "The Great Gatsby";
            Author = "F. Scott Fitzgerald";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Amazon Kindle - Title: {Title}, Author: {Author}");
        }
    }
}
