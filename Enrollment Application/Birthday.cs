/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * Inherits from the CustomDate class. Contains no unique 
 * datamembers. Has a method to validate that the person is
 * atleast 18.
 * Change Log:
 * 01. Add constant for age of 18
 * 02. Update Constructor Comment
 * 03. Reflect changes made to CustomDate
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class Birthday : CustomDate
    {
        private static int MinAge = 18;

        /* Call the base class constructor */
        public Birthday(int d) : base(d) {}

        /* Validates that the person is atleast 18 years old. Returns
         * true if so, otherwise, false.S
         */
        public override bool Validate()
        {
            int Age = DateTime.Today.Year - year;
            if (Age < MinAge) // Not 18, Sorry
                return false;
            else if (Age > MinAge) // You're 18, proceed
                return true;
            else if (Age == MinAge) // You may be 18 today, may be 18 later this year
            {
                if (month < DateTime.Today.Month) // Your Birth Month hasn't happened yet
                    return false;
                else if (month > DateTime.Today.Month) // Your Birth Day has already happened
                    return true;
                else // Your Birth Month is this Month!
                {
                    if (day < DateTime.Today.Day) // Your Birth Day hasn't happened yet
                        return false;
                    if (day >= DateTime.Today.Day) // Your Birth Day happened recently or is today
                        return true;
                }
            }
            return false; //Some error has occured, we shouldn't be here.
        }
    }
}
