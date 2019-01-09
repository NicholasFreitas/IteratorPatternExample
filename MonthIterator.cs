using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class MonthIterator : IMonthIterator
    {
        MonthAggregate MonthAggregate;
        int _currentIndex = 0;

        public MonthIterator(MonthAggregate monthAgg)
        {
            MonthAggregate = monthAgg;
        }

        public IMonth GetCurrentMonth()
        {
            return MonthAggregate.Months[_currentIndex];
        }

        public bool IsDone()
        {
            if (_currentIndex == MonthAggregate.Months.Count) 
            {
                return true;
            }

            return false;
        }

        public void Next()
        {
            _currentIndex++;
        }
    }
}
