using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary4
{
    public interface ImageLoadingStrategy
    {
        void loadImage(String href);
    }
}
