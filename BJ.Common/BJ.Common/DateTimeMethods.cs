using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Common
{
    public class DateTimeMethods
    {
        /* Returns the current date and time.
         * Format: MM/DD/YYYY HH:MM:SS AM
         */
        public DateTime currentDateTime()
        {
            return DateTime.Now;
        }

        /* Returns the current time only
         * Format: HH:MM:SS AM
         */
        public string currentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }

        /* Return the current date only
         * Format: MM/DD/YYYY
         */
        public string TodaysDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        /* Return the full date time including date
         * Format: Saturday, December 20, 2014 3:49:12 PM
         */
        public string fullDateTime()
        {
            DateTime date = DateTime.Now;
            DateTime dateValue = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            
            return dateValue.ToString("F");
        }

        /* Return the current Month 
         * Format: Decemeber
         */
        public string currentMonth()
        {
            DateTime date = DateTime.Now;
            var month = date.ToString("MMMM");
            return month;
        }

        /* Return the current year as a string 
         * Format: 2014
         */
        public string currentYear()
        {
            DateTime date = DateTime.Now;
            var year = date.Year;
            return year.ToString();
        }

        /* Return current month as a Number
         * Format: 12
         */
        public int currentMonthInt()
        {
            DateTime date = DateTime.Now;
            return date.Month;
        }
    }
}
