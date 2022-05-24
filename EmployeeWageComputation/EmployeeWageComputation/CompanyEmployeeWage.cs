using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmployeeWage
    {
        public string company;
        public int maxWorkHours, noOfWorkingDays, empRatePerHour, totalEmpWage;

        public CompanyEmployeeWage(string company, int noOfWorkingDays, int maxWorkHours, int empRatePerHour)
        {
            this.company = company;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkHours = maxWorkHours;
            this.empRatePerHour = empRatePerHour;
            
        }

        public void setEmployeeWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
    }
}
