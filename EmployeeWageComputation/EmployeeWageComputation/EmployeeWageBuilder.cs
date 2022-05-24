using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWageBuilder:ICompanyEmployeeWage
    {
        const int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        //private String company;
        //private int totalWorkingDays, maxWorkHours, wagePerHour;
        private int numOfCompany,count=0;
        List<CompanyEmployeeWage> companyEmployeeWageList = new List<CompanyEmployeeWage>();
        Dictionary<string, CompanyEmployeeWage> CompanytotalAndDailyWage = new Dictionary<string, CompanyEmployeeWage>();
        //private CompanyEmployeeWage[] companyEmployeeWageArray;
        Random random = new Random();
        public EmployeeWageBuilder(int companies)
        {
            /* this.company = company;
             this.totalWorkingDays = totalWorkingDays;
             this.maxWorkHours = maxWorkHours;
             this.wagePerHour = wagePerHour;*/
            this.numOfCompany = companies;
            //this.companyEmployeeWageArray = new CompanyEmployeeWage[this.numOfCompany];

        }

        public void AddCompanyEmpWageDetails(string company,int maxWorkingDays,int maxWorkingHrs,int wagePerHour)
        {
            //this.companyEmployeeWageArray[count] = new CompanyEmployeeWage(company,maxWorkingDays,maxWorkingHrs,wagePerHour);
            CompanyEmployeeWage companyEmployeeWage = new CompanyEmployeeWage(company, maxWorkingDays, maxWorkingHrs, wagePerHour);
            companyEmployeeWageList.Add(companyEmployeeWage);
            CompanytotalAndDailyWage.Add(company, companyEmployeeWage);
        }

        public void CalculateWageOfCompany()
        {
            foreach (CompanyEmployeeWage companyEmployeeWage in companyEmployeeWageList)
            {
                companyEmployeeWage.setEmployeeWage(this.WageAsPerCompany(companyEmployeeWage));
                //companyEmployeeWageArray[i].setEmployeeWage(this.WageAsPerCompany(this.companyEmployeeWageArray[i]));
            }
        }
        public int IdentifyWageOfCompany(string company)
        {
            return this.CompanytotalAndDailyWage[company].totalEmpWage;
        }

        public int WageAsPerCompany(CompanyEmployeeWage employeeWage)
        {
            int empWorkHours = 0, workingDays = 0;
            //Console.WriteLine(employeeWage.company+" "+employeeWage.maxWorkHours+" "+employeeWage.noOfWorkingDays);
            while (empWorkHours <= employeeWage.maxWorkHours && workingDays <= employeeWage.noOfWorkingDays)
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
            int empWage = empWorkHours * employeeWage.empRatePerHour;
            Console.WriteLine("Employee wage of firm - {0} is Rs.{1} ", employeeWage.company, empWage);
            return empWage;
        }
    }
}
