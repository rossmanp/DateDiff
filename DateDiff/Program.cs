﻿using System;
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
            bool isUserWrong = true;
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Now;
            while (isUserWrong)

            {
                Console.WriteLine("This program calculates the difference in time between two dates.");
                Console.WriteLine("Enter the earlier of the two dates in MM/DD/YYYY format:");
                string date1 = Console.ReadLine();
                Console.WriteLine("Enter the later of the two dates in MM/DD/YYYY format:");
                string date2 = Console.ReadLine();
                DateTime.TryParse(date1, out dt1);
                DateTime.TryParse(date2, out dt2);
                if (dt1 < dt2)
                {
                    isUserWrong = false;
                }
                else
                {
                    Console.WriteLine("Whoops, your first date was later than your second date!");
                    Console.WriteLine("Please try again.");
                }
            }
            
            int month1 = dt1.Month;
            int month2 = dt2.Month;
            int year1 = dt1.Year;
            int year2 = dt2.Year;
            int day1 = dt1.Day;
            int day2 = dt2.Day;
            int yearDiff = year2 - year1;
            int monthDiff = month2 - month1;
            int dayDiff = day2 - day1;

            if (month2 < month1)
                {
                    yearDiff--;
                }
            if (month1 == month2 && day2 < day1)
                {
                    yearDiff--;
                    monthDiff = 11;
                }
            if (monthDiff < 0)
                {
                    monthDiff = monthDiff + 12;
                }
            if (day2 < day1)
                {
                    if (month1 == 2)
                    {
                        dayDiff = day2 + (28 - day1);
                    }
                    else if (month1 == 4 || month1 == 6 || month1 == 9 || month1 == 11)
                    {
                        dayDiff = day2 + (30 - day1);
                    }
                    else
                    {
                        dayDiff = day2 + (31 - day1);
                    }
                }

            Console.WriteLine("The Year difference is: {0}", yearDiff);
            Console.WriteLine("The Month difference is: {0}", monthDiff);
            Console.WriteLine("The Day difference is: {0}", dayDiff);
            Console.WriteLine("Press Enter to exit the program.");
            Console.ReadLine();
        }
    }
}
