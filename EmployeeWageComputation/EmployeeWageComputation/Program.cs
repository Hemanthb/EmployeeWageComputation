// See https://aka.ms/new-console-template for more information
EmployeeWageComputation.EmployeeAttendance employeeAttendance = new EmployeeWageComputation.EmployeeAttendance();
EmployeeWageComputation.EmployeeWageCalculator wageCalculator = new EmployeeWageComputation.EmployeeWageCalculator();
employeeAttendance.CheckAttendance();
employeeAttendance.CalculateDailyWage();
employeeAttendance.CalculatePartTimeWage();
wageCalculator.WageAsPerWorkHrs();
