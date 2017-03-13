using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in MM/DD/YYYY format:");
            string date1 = Console.ReadLine();
            Console.WriteLine("Enter a second date in MM/DD/YYYY format:");
            string date2 = Console.ReadLine();
            DateTime dt1;
            DateTime dt2;
            DateTime.TryParse(date1, out dt1);
            DateTime.TryParse(date2, out dt2);
            Console.Write(dt1);
            Console.WriteLine("\n");
            Console.Write(dt2);
            Console.ReadLine();
        }
    }
}
