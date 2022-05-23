using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeDetails
    {
        const int FULL_DAY_HOUR = 8,PART_TIME_HOUR = 4, IS_FULL_TIME = 1, IS_PART_TIME = 2;
        int dailyWage, wagePerHour = 20;

        Random random = new Random();
        public void CheckAttendance()
        {
            
            if (random.Next(0, 2) == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        public void CalculateDailyWage()
        {
            dailyWage = FULL_DAY_HOUR * wagePerHour;
            Console.WriteLine("Daily wage is"+dailyWage);
        }
        public void CalculatePartTimeWage()
        {
            int partTimeWage = PART_TIME_HOUR * wagePerHour;
            Console.WriteLine("Part Time wage is" + partTimeWage);
        }

        public void WageAsPerWorkHrs(String companyName,int totalWorkingDays, int maxWorkHours, int wagePerHour)
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
            Console.WriteLine("Employee wage of firm - {0} for {1} hrs in {2} Days is {3}", companyName, empWorkHours, workingDays - 1, empWage);
        }
    }
}
