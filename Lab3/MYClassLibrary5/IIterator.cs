using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    public interface IIterator<T>
    {
        T Next();
        bool HasNext();
    }
}
