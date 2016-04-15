using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, 
            decimal weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Weekly salary cannot be negative !");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Working hours per day cannot be 0 or greater than 24!");
                }
                this.workHoursPerDay = value;
            }
        }



        public decimal MoneyPerHour()
        {
            decimal result = (this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5));
            return result;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} - Worker - {1:F2}", base.ToString(), this.MoneyPerHour()));
            return output.ToString();
        }
    }
    
    
}
