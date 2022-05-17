using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeDetails
    {
        int fullDayHour = 8;
        int partTimeHour = 4;
        int wagePerHour = 20;
        int dailyWage;
        int empWorkHours = 0;
        const int isFullTime = 1;
        const int isPartTime = 2;
        int totalWorkingDays = 20;
        int maxWorkHours = 100;
        int workingDays = 0;
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
            dailyWage = fullDayHour * wagePerHour;
            Console.WriteLine("Daily wage is"+dailyWage);
        }
        public void CalculatePartTimeWage()
        {
            int partTimeWage = partTimeHour * wagePerHour;
            Console.WriteLine("Part Time wage is" + partTimeWage);
        }

        public void WageAsPerWorkHrs()
        {
            while (empWorkHours <= maxWorkHours && workingDays <= totalWorkingDays)
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
            Console.WriteLine("Employee wage for {0} hrs in {1} Days is {2}", empWorkHours, workingDays - 1, empWage);
        }
    }
}
