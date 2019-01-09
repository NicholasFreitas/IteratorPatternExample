using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    interface IMonthIterator
    {
        bool IsDone();
        void Next();
        IMonth GetCurrentMonth();

    }
}
