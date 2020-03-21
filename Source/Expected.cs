/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * This class represents an Expected Start Date for a plan. It
 * inherits from abstract class CustomDate. It has no data members
 * other than those inherited. It has multiple constants to represent
 * months and Date Arithmetic. It uses the base constructor. It
 * overrides the Validate method.
 * Change Log:
 * 01. Reflect changes to CustomDate
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class Expected : CustomDate
    {
        //Months
        private static int January  = 1;
        private static int February = 2;
        private static int March    = 3;
        private static int May      = 5;
        private static int July     = 7;
        private static int August   = 8;
        private static int October  = 10;
        private static int December = 12;

        private static int LeapMod          = 4;
        private static int Next             = 1;
        private static int Last             = -1;
        private static int Current          = 0;
        private static int NewYearNextMonth = -11;

        /* Call the base class constructor */
        public Expected(int d) : base(d) {}

        /* Validates that the Date data member occurs within 30 days
         * from today. Returns true if so, false otherwise.
         */
        public override bool Validate()
        {
            int yearDif = year - DateTime.Today.Year;
            int monthDif = month - DateTime.Today.Month;
            int dayDif = day - DateTime.Today.Day;
            int modifier = 0;

            if (yearDif < Next && yearDif > Last) // This year or next year
            {
                if (monthDif == Next || monthDif == NewYearNextMonth) //Next Month
                {
                    if (DateTime.Today.Month == January 
                        || DateTime.Today.Month == March
                        || DateTime.Today.Month == May
                        || DateTime.Today.Month == July
                        || DateTime.Today.Month == August 
                        || DateTime.Today.Month == October
                        || DateTime.Today.Month == December) //This month has 31 days
                        modifier = -1;
                    else if (DateTime.Today.Month == February) //February
                    {
                        if (DateTime.Today.Year % LeapMod == LeapMod) //It's a Leap Year
                            modifier = 1;
                        else //Not a leap year
                            modifier = 2;
                    }
                    //If Month is 30 days, don't alter modifier
                    if (day < DateTime.Today.Day + modifier)
                        return true;
                }
                else if (monthDif == Current)
                {
                    if (dayDif < 0) //Day hasn't occured yet this month
                        return true;
                }
            }
            return false;
        }
    }
}
