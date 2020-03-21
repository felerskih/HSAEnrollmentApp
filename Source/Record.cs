/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * This class makes up the Data Members of an individual Record. It
 * has no methods.
 * Change Log:
 * 01. Update to handle new Custom Date inheriting objects
 * 02. Update Constructor Definition
 * 03. Reflect changes to CustomDate
 * 04. Add ToString override
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
        private Birthday DOB;
        private string PlanType;
        private Expected EffectiveDate;
        private string Status;

        /* Constructor for a report object. Takes a string array and
         * two dates. The array is expected to be in the same order 
         * as the string data members of the class are listed.
         */
        public Record(string first, string last, string plan, int birth, int effective)
        {
            FirstName     = first;
            LastName      = last;
            PlanType      = plan;
            DOB           = new Birthday(birth);
            EffectiveDate = new Expected(effective);
        }

        public void Validate()
        {
            if (DOB.Validate() && EffectiveDate.Validate())
                Status = "Approved";
            Status = "Rejected";
        }

        public override string ToString()
        {
            return FirstName + LastName + DOB.ToString() + PlanType + EffectiveDate.ToString();
        }
    }
}
