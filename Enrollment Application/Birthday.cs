/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * Inherits from the CustomDate class. Contains no unique 
 * datamembers. Has a method to validate that the person is
 * atleast 18.
 * Change Log:
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class Birthday : CustomDate
    {

        public Birthday(DateTime d) : base(d)
        {

        }

        /* Validates that the person is atleast 18 years old. Returns
         * true if so, otherwise, false.S
         */
        public override bool Validate()
        {
            int Age = DateTime.Today.Year - date.Year;
            if (Age < 18) // Not 18, Sorry
                return false;
            else if (Age > 18) // You're 18, proceed
                return true;
            else if (Age == 18) // You may be 18 today, may be 18 later this year
            {
                if (date.Month < DateTime.Today.Month) // Your Birth Month hasn't happened yet
                    return false;
                else if (date.Month > DateTime.Today.Month) // Your Birth Day has already happened
                    return true;
                else // Your Birth Month is this Month!
                {
                    if (date.Day < DateTime.Today.Day) // Your Birth Day hasn't happened yet
                        return false;
                    if (date.Day >= DateTime.Today.Day) // Your Birth Day happened recently or is today
                        return true;
                }
            }
            return false; //Some error has occured, we shouldn't be here.
        }
    }
}
