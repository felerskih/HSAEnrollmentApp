/* Author: Henry Felerski
 * Date: 3/20/20
 * Class Description:
 * This Class is for file reading. There are two constants declared
 * to handle size and comma delimitation in the data file. The class
 * has a StreamReader as a data member to read files. There is only
 * one method, which reads in one line from the file at a time and
 * formats it.
 * Change Log:
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Enrollment_Application
{
    class FileManager
    {
        private static char comma = ',';
        private static int DataCount = 5;

        private StreamReader sr;

        /* Initializes the StreamReader with a relative path */
        public FileManager()
        {
            sr = new StreamReader(Directory.GetCurrentDirectory() + @"Data/EnrollmentData.csv");
        }

        /* A method to read in a line from the file containing the
         * records. It is expected that sr is initialized correctly
         * and the input file is formatted correctly. Takes no 
         * inputs, outputs a string array containing data to be used
         * in a Report object.
         */
        public string[] ReadLine()
        {
            string line;
            string[] values = new string[DataCount - 1];
            line = sr.ReadLine();
            return values = line.Split(",", DataCount);
        }
    }
}
