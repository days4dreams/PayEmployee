using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            /*start example Employee object */
            Employee lauren = new Employee(10000, "Lauren", "Wilson", "Marketeer");
            lauren.employeeTitle = "Mrs";
            //create a new object Employee, set the attribute of Title for lauren object

            lauren.CalculateBonus(200);
            //call the function CalculateBonus. We manually pass the employeeInput as we created an instance of Employee

            lauren.MonthlyGross();
            //call the function MonthlyGross. This takes the earlier input salary and bonus to work out
            //this months total pay

            Console.WriteLine(lauren.EmployeeSummary());
            //call the Employee summary; print to screen
            /*end example Employee object */


            /* start Marketeer example */
            Marketeer jane = new Marketeer(12000, "Jane", "Young", "Marketeer");
            jane.marketeerSpecialism = "Digital Marketing";
            jane.marketeerMonthlySales = 10;
            //create an object of Marketeer, set some attributes for the object jane.

            jane.CalculateBonus(jane.employeeInput);
            //we know that the function - in Employee - takes the employeeInput as marketeerMonthlySales, becuase
            //jane is a marketeer

            jane.MonthlyGross();
            //call the function - in Marketeer - to work out this months pay

            Console.WriteLine(jane.EmployeeSummary());
            Console.WriteLine(jane.MarketeersSummary(jane.marketeerMonthlySales));
            //call the function EmployeeSummary from Employee Class and function Marketeer Summary from the Marketeer
            //class. Pass in the earlier set MonthlySales to produce a summary to screen
            //print the employee summary and marketeer summary to screen
            /* end Marketeer example */

            /*start Developer example */
            Developer dave = new Developer(12000, "Dave", "Mawer", "Developer");
            dave.isStarWarsFan = true;
            dave.developerOvertime = 9;

            dave.CalculateBonus(dave.employeeInput);
            //we know that the function - in Employee - takes the employeeInput as developerOvetime, becuase
            //dave is a developer

            dave.MonthlyGross();
            //call the function - in Developer - to work out this months pay


            Console.WriteLine(dave.EmployeeSummary());
            Console.WriteLine(dave.DeveloperSummary(dave.developerOvertime));
            //call the function EmployeeSummary from Employee Class and function DeveloperSummary from Developer
            //class. Pass in the earlier set DeveloperOvertime to produce a summary to screen
            //print the employee summary and developer summary to screen
            /*end Developer example */

            Console.ReadLine();
        }
    }
}
