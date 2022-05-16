using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance
    {
        int fullDayHour = 8;
        int partTimeHour = 4;
        int wagePerHour = 20;
        int dailyWage;
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
    }
}
