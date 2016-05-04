using System;

namespace Entities
{
    public class Employment
    {
        public Person Employee { get; set; }

        public DateTime EmployementStartDate { get; set; }

        public DateTime? EmploymentEndDate { get; set; }

        /// <summary>
        ///     Return the number of Years that a employee has been Employed
        /// </summary>
        /// <returns></returns>
        public double NumberOfYearsEmployed
        {
            get
            {
                double numberOfDays = this.EmploymentEndDate == null ? (DateTime.Now - EmployementStartDate).TotalDays : (((DateTime)EmploymentEndDate) - EmployementStartDate).TotalDays;

                // calculate the number of years as a double, including fractional part
                return numberOfDays / 365;
            }
        }
    }
}