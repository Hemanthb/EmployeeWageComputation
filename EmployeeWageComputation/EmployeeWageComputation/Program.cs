// See https://aka.ms/new-console-template for more information
EmployeeWageComputation.EmployeeDetails employeeAttendance = new EmployeeWageComputation.EmployeeDetails();
employeeAttendance.CheckAttendance();
employeeAttendance.CalculateDailyWage();
employeeAttendance.CalculatePartTimeWage();
employeeAttendance.WageAsPerWorkHrs("XYZ&Co",25,200,50);
employeeAttendance.WageAsPerWorkHrs("AbC Industries", 22, 160, 60);
