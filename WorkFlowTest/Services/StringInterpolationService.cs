using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowTest.Utils;

namespace WorkFlowTest.Services
{
    // INSTRUCTIONS

    public class StringInterpolationService : IStringInterpolationService
    {
        private readonly ISystemDate _date;

        public StringInterpolationService(ISystemDate date)
        {
            _date = date;
        }

        //1. January 22, 2019 (right aligned in a 40 character field)
        public string Number1()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            return $"{date,40}";
        }

        //2.2019.01.22
        public string Number2()
        {
            throw new NotImplementedException();
        }

        //3.Day 22 of January, 2019
        public string Number3()
        {
            throw new NotImplementedException();
        }

        //4.Year: 2019, Month: 01, Day: 22
        public string Number4()
        {
            throw new NotImplementedException();
        }

        //5.            Tuesday(10 spaces total, right aligned)
        public string Number5()
        {
            throw new NotImplementedException();
        }

        //6.     11:01 PM Tuesday(10 spaces total for each including the day-of-week, both right-aligned)
        public string Number6()
        {
            throw new NotImplementedException();
        }

        //7.h:11, m:01, s:27
        public string Number7()
        {
            throw new NotImplementedException();
        }

        //8.2019.01.22.11.01.27
        public string Number8()
        {
            throw new NotImplementedException();
        }

        //If you have PI(3.1415) - use var pi = Math.PI;
        //9. Output as currency
        public string Number9()
        {
            throw new NotImplementedException();
        }

        //If you have PI(3.1415) - use var pi = Math.PI;
        //10. Output as right-aligned(10 spaces), number with 3 decimal places
        public string Number10()
        {
            throw new NotImplementedException();
        }
    }
}
