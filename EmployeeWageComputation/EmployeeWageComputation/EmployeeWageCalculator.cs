using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageCalculator
    {
        int empWorkHours = 0;
        const int isFullTime = 1;
        const int isPartTime = 2;
        int wagePerHour = 20;
        Random random = new Random();
        int totalWorkingDays = 20;
        int maxWorkHours = 100;
        int workingDays = 0;
        public void WageAsPerWorkHrs()
        {
            while(empWorkHours <= maxWorkHours && workingDays <= totalWorkingDays)
            {
                workingDays++;
                int workMode = random.Next(0, 3);

                switch (workMode)
                {
                    case isFullTime:
                        empWorkHours += 8;
                        break;
                    case isPartTime:
                        empWorkHours += 4;
                        break;
                    default:
                        empWorkHours += 0;
                        break;
                }
            }
            int empWage = empWorkHours * wagePerHour;
            Console.WriteLine("Employee wage for {0} hrs in {1} Days is {2}",empWorkHours,workingDays-1, empWage);
        }
    }
}
