/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * This Class is for file reading. There are two constants declared
 * to handle size and comma delimitation in the data file. The class
 * has a StreamReader as a data member to read files. There is only
 * one method, which reads in one line from the file at a time and
 * formats it.
 * Change Log:
 * 01. Update to return end of file message
 * 02. Add Method to close Reader
 * 03. Bad Array Length
 * 04. Bad Path. Fixed
 * 05. Use Constant EOF
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Enrollment_Application
{
    class FileManager
    {
        private static char comma    = ',';
        private static int DataCount = 5;
        private static string EOF    = "EOF";

        private StreamReader sr;

        /* Initializes the StreamReader with a relative path */
        public FileManager()
        {
            sr = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/EnrollmentData.csv");
        }

        /* A method to read in a line from the file containing the
         * records. It is expected that sr is initialized correctly
         * and the input file is formatted correctly. Takes no 
         * inputs, outputs a string array containing data to be used
         * in a Report object. Returns EOF in the 0th index if we are
         * at the end of the file.
         */
        public string[] ReadLine()
        {
            string line;
            string[] values = new string[DataCount];
            
            if ((line = sr.ReadLine()) != null)
                return values = line.Split(comma, DataCount);
            values[0] = EOF;
            return values;
        }

        /* Close the StreamReader */
        public void Close()
        {
            sr.Close();
        }
    }
}
