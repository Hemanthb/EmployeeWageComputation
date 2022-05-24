// See https://aka.ms/new-console-template for more information
/*EmployeeWageComputation.EmployeeDetails employeeAttendance = new EmployeeWageComputation.EmployeeDetails();
EmployeeWageComputation.EmployeeWageBuilder wageBuilder = new EmployeeWageComputation.EmployeeWageBuilder("Lixil", 24, 160, 80);
EmployeeWageComputation.EmployeeWageBuilder wageBuilder1 = new EmployeeWageComputation.EmployeeWageBuilder("Blabz", 25, 160, 100);
wageBuilder.WageAsPerCompany();
wageBuilder1.WageAsPerCompany();
employeeAttendance.CheckAttendance();
employeeAttendance.CalculateDailyWage();
employeeAttendance.CalculatePartTimeWage();
employeeAttendance.WageAsPerWorkHrs("XYZ&Co",25,200,50);
employeeAttendance.WageAsPerWorkHrs("AbC Industries", 22, 160, 60)*/
Console.WriteLine("Enter number of companies for which wages have to be calculated:");
int noOfCompanies = Convert.ToInt32(Console.ReadLine());
EmployeeWageComputation.EmployeeWageBuilder employeeWage = new EmployeeWageComputation.EmployeeWageBuilder(noOfCompanies);
String[][] companyDetails = new String[noOfCompanies][];
for(int i= 0; i < noOfCompanies; i++)
{
    Console.WriteLine("Enter Conpany name,num Of working Days,total working hours and employee wage/hour");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    companyDetails[i] = Console.ReadLine().Split(",");
#pragma warning restore CS8602 // Dereference of a possibly null reference.

}
for (int i = 0; i < noOfCompanies; i++)
{
    
    employeeWage.AddCompanyEmpWageDetails(companyDetails[i][0], Convert.ToInt32(companyDetails[i][1]),
       Convert.ToInt32(companyDetails[i][2]), Convert.ToInt32(companyDetails[i][3]));
    
}
employeeWage.CalculateWageOfCompany();
Console.WriteLine("Enter the Company Name to obtain total wage");
string companyName = Console.ReadLine();
Console.WriteLine("Total wage of company - {0} is {1}",companyName,employeeWage.IdentifyWageOfCompany(companyName));

