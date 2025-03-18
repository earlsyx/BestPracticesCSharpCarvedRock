using System;
using System.Globalization;

namespace carvedrock.bl.principles
{
    public class KISS
    {
        public string GetMonth(int month)
        {
            if ((month < 1) || (month > 12)) throw new InvalidOperationException("The month must be in range 1 to 12");

            return (new DateTimeFormatInfo()).GetMonthName(month);
        }

       
    }
}
