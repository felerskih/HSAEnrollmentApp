/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * A simple class to write data to the console.
 * Change Log:
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class ConsoleManager
    {
        private static string ErrorString = "Invalid Record. Processing Stopped.";

        /* Write a record out to the Console */
        public void writeRecord(string[] output)
        {
            Console.WriteLine(output);
        }

        /* Write an error message to the Console. Will only happen if
         * a record is flagged as invalid.
         */
        public void writeError()
        {
            Console.WriteLine(ErrorString);
        }
    }
}
