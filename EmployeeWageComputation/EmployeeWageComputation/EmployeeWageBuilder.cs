using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilder
    {
        const int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        private String company;
        private int totalWorkingDays, maxWorkHours, wagePerHour;
        Random random = new Random();
        public EmployeeWageBuilder(String company,int totalWorkingDays,int maxWorkHours,int wagePerHour)
        {
            this.company = company;
            this.totalWorkingDays = totalWorkingDays;
            this.maxWorkHours = maxWorkHours;
            this.wagePerHour = wagePerHour;

        }
        public void WageAsPerCompany()
        {
            int empWorkHours = 0, workingDays = 0;
            while (empWorkHours <= maxWorkHours && workingDays <= totalWorkingDays)
            {
                workingDays++;
                int workMode = random.Next(0, 3);

                switch (workMode)
                {
                    case IS_FULL_TIME:
                        empWorkHours += 8;
                        break;
                    case IS_PART_TIME:
                        empWorkHours += 4;
                        break;
                    default:
                        empWorkHours += 0;
                        break;
                }
            }
            int empWage = empWorkHours * wagePerHour;
            Console.WriteLine("Employee wage of firm - {0} is Rs.{1} ", company, empWage);
        }
    }
}
