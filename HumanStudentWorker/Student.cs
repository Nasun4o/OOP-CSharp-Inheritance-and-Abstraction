using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;


namespace HumanStudentWorker
{
   
   public class Student : Human
    {
        private const string FacultyNumFormat = @"[\d\w]{5,10}";
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (!Regex.IsMatch(value, FacultyNumFormat))
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be between 5 - 10 charas or numbers!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} - Student {1}", base.ToString(), this.facultyNumber));
            return output.ToString();
               
        }
    }
}
