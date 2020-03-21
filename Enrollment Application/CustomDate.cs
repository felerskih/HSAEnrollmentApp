/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * An abstract class for our two Date classes to inherit from. The
 * reason for doing this is the constructor is identical so now it
 * is only written once, and they share a common behavior to Validate,
 * although the implementation will be different.
 * Change Log:
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    abstract class CustomDate
    {
        protected DateTime date;
        
        /* Initializes the date */
        public CustomDate(DateTime d)
        {
            date = d;
        }

        /* Stub to be used when inherited. */
        public abstract bool Validate();
    }
}
