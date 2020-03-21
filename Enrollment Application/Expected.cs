using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class Expected : CustomDate
    {
        public Expected(DateTime d) : base(d)
        {

        }

        public override bool Validate()
        {
            int yearDif = date.Year - DateTime.Today.Year;
            int monthDif = date.Month - DateTime.Today.Month;
            int dayDif = date.Day - DateTime.Today.Day; // absolute value!
            if (yearDif < 1)
            {
                if (monthDif < 1 || monthDif == -11)
                {
                    if (dayDif <= 30)
                        return true;
                    return false;
                }
            }
            return false;
        }
    }
}
