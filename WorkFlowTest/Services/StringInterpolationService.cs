using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowTest.Utils;

namespace WorkFlowTest.Services
{
    // INSTRUCTIONS

    //From provided date

    //1.                January 22, 2019 (right aligned in a 40 character field)
    //2.2019.01.22
    //3.Day 22 of January, 2019
    //4.Year: 2019, Month: 01, Day: 22
    //5.            Tuesday(10 spaces total, right aligned)
    //6.     11:01 PM Tuesday(10 spaces total for each including the day-of-week, both right-aligned)
    //7.h:11, m:01, s:27
    //8.2019.01.22.11.01.27

    //If you have PI(3.1415) - use var pi = Math.PI;
    //1. Output as currency
    //2. Output as right-aligned(10 spaces), number with 3 decimal places
    public class StringInterpolationService : IStringInterpolationService
    {
        private readonly ISystemDate _date;

        public StringInterpolationService(ISystemDate date)
        {
            _date = date;
        }

        public string Number1()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            return $"{date,40}";
        }
    }
}
