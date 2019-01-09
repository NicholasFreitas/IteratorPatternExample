using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class MonthAggregate : IMonthAggregate
    {
        public List<Month> Months { get; }

        public MonthAggregate(List<Month> months)
        {
            Months = months;
        }

        public IMonthIterator GetMonthsIterator()
        {
            return new MonthIterator(this);
        }
    }
}
