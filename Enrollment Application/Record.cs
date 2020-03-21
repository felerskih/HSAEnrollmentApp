/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * This class makes up the Data Members of an individual Record. It
 * has no methods.
 * Change Log:
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class Record
    {
        private string FirstName;
        private string LastName;
        private string DOB;
        private string PlanType;
        private string EffectiveDate;
        private string Status;

        /* Constructor for a report object. Takes a string array. The
         * array is expected to be in the same order as the data
         * members of the class are listed.
         */
        public Record(string[] fields)
        {
            FirstName     = fields[0];
            LastName      = fields[1];
            DOB           = fields[2];
            PlanType      = fields[3];
            EffectiveDate = fields[4];
            Status        = fields[5];
        }
    }
}
