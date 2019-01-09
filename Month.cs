using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    class Month : IMonth
    {
        string Name;
        int NumberOfDays;
        int Index;

        public Month(int index, string name, int days)
        {
            Index = index;
            Name = name;
            NumberOfDays = days;
        }

        public void GetMonthDetails()
        {
            Console.WriteLine($"Month index: {Index} , Month name: {Name} and there are {NumberOfDays} days in the month.");
        }
    }
}
