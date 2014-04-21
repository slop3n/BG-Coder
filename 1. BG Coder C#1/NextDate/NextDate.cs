using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime enteredDate = new DateTime(year, month,day);
            DateTime newDate = enteredDate.AddDays(1);
            Console.WriteLine("{0}.{1}.{2}", newDate.Day, newDate.Month, newDate.Year);
        }
    }
}
