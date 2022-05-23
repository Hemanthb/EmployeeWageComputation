// See https://aka.ms/new-console-template for more information
EmployeeWageComputation.EmployeeDetails employeeAttendance = new EmployeeWageComputation.EmployeeDetails();
EmployeeWageComputation.EmployeeWageBuilder wageBuilder = new EmployeeWageComputation.EmployeeWageBuilder("Lixil", 24, 160, 80);
EmployeeWageComputation.EmployeeWageBuilder wageBuilder1 = new EmployeeWageComputation.EmployeeWageBuilder("Blabz", 25, 160, 100);
wageBuilder.WageAsPerCompany();
wageBuilder1.WageAsPerCompany();
/*employeeAttendance.CheckAttendance();
employeeAttendance.CalculateDailyWage();
employeeAttendance.CalculatePartTimeWage();
employeeAttendance.WageAsPerWorkHrs("XYZ&Co",25,200,50);
employeeAttendance.WageAsPerWorkHrs("AbC Industries", 22, 160, 60);*/

