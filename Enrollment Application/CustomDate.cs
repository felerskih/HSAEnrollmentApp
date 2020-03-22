/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * An abstract class for our two Date classes to inherit from. The
 * reason for doing this is the constructor is identical so now it
 * is only written once, and they share a common behavior to Validate,
 * although the implementation will be different.
 * Change Log:
 * 01. Rework Class to support string date format.
 * 02. Add ToString override
 * 03. Alter ToString to correct order and padding, alter constructor
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    abstract class CustomDate
    {
        protected int day;
        protected int month;
        protected int year;

        /* Initializes the data members. */
        public CustomDate(int d)
        {
            month = d / 1000000;
            day = (d / 10000) % 100;
            year = d % 10000;
        }

        public override string ToString()
        {
            string format = "00";
            string yearFormat = "0000";

            return month.ToString(format) + day.ToString(format) 
                                  + year.ToString(yearFormat);
        }

        /* Stub to be used when inherited. */
        public abstract bool Validate();
    }
}
