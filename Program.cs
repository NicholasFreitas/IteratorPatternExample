using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Month> months = new List<Month>();
            months.Add(new Month(1, "January", 31));
            months.Add(new Month(2, "February", 28));
            months.Add(new Month(3, "March", 31));
            months.Add(new Month(4, "April", 30));
            months.Add(new Month(5, "May", 31));
            months.Add(new Month(6, "June", 30));
            months.Add(new Month(7, "July", 31));
            months.Add(new Month(8, "August", 31));
            months.Add(new Month(9, "September", 30));
            months.Add(new Month(10, "October", 31));
            months.Add(new Month(11, "November", 30));
            months.Add(new Month(12, "December", 31));


            var monthAgg = new MonthAggregate(months);
            var monIter = monthAgg.GetMonthsIterator();


            while (!monIter.IsDone())
            {
                monIter.GetCurrentMonth().GetMonthDetails();
                monIter.Next();
            }



        }
    }
}
