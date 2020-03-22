/* Author: Henry Felerski
 * Date: 3/21/20
 * Class Description:
 * This class does the bulk of processing records. It has a data
 * member for the other manager classes as well as a List of Records.
 * Change Log:
 * 01. Forgot to alter loop condition, causing infinite loop
 * 02. Make a record, validate it, add it
 * 03. Add ProcessType to enforce correct plan types
 * 04. Update length check
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enrollment_Application
{
    class ProcessManager
    {
        private static int ValsLength = 5;
        private static string EOF = "EOF";

        private FileManager files;
        private ConsoleManager output;
        private List<Record> records;

        /* Initialize the data members */
        public ProcessManager()
        {
            files = new FileManager();
            output = new ConsoleManager();
            records = new List<Record>();
        }

        /* Processes each record and controls files, output, and
         * records.
         */
        public void Process()
        {
            string[] vals = new string[ValsLength];
            int dob = 0;
            int effective = 0;
            Record temp;

            vals = files.ReadLine();

            while (vals[0] != EOF)
            {
                //Check that we have 5 strings. Only way to validate names and type
                if (vals.Length != ValsLength)
                {
                    output.writeError();
                    return;
                }

                if(!ProcessDate(vals[2], ref dob) || !ProcessDate(vals[4], ref effective)
                    || !ProcessType(vals[3]))
                {
                    output.writeError();
                    return;
                }

                temp = new Record(vals[0], vals[1], vals[3], dob, effective);
                temp.Validate();
                records.Add(temp);

                vals = files.ReadLine();
            }
            foreach (Record rec in records)
                output.writeRecord(rec.ToString());
        }

        /* Parses a date from a string. Returns true if succesful,
         * otherwise returns false. Takes a string passed by
         * value and a DateTime object passed by reference as input.
         */
        public bool ProcessDate(string d, ref int day)
        {
            if(d.Length != 8)
                return false;
            try
            {
                day = Int32.Parse(d);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        public bool ProcessType(string t)
        {
            if (t == "HSA" || t == "HRA" || t == "FSA")
                return true;
            return false;
        }
    }
}
