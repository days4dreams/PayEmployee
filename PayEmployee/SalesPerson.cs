using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayEmployee
{
    class SalesPerson : Employee
    {
        public double salesSalesAchieved = 0;
        public double salesTarget = 0;
        //here we declare variables that are used only in this child class

        /* start properties */
        public double Target
        {
            get { return this.salesTarget; }
            set { this.salesTarget = value; }
        }
        //this the declaration of a property, Target. It allows get and set; it can be changed.

        public double Sales
        {
            get { return this.salesSalesAchieved; }
            set { this.salesSalesAchieved = value; }
        }
        //we use the double employeInput globally in the Employee class. Here we set it for SalesPerson as
        //equal to salesSalesAchieved
        /*end properties*/

        /* start constructors */
        public SalesPerson(double employeeSalary, string employeeFirstName, string employeeSecondName, string employeeType) : base(employeeSalary, employeeFirstName, employeeSecondName, employeeType)
        {
            this.employeeSalary = employeeSalary;
            this.employeeFirstName = employeeFirstName;
            this.employeeSecondName = employeeSecondName;
            this.employeeType = employeeType;
        }
        //this is a constructor, as per the Employee object.
        /* end constructors */

        /* start functions */
        public string SalesSummary(double salesSalesAchieved)
        {
            if (salesSalesAchieved >= salesTarget)
            {
                return "Good News " + employeeFirstName + " achieved their target";
            }
            else if (salesSalesAchieved <= salesTarget)
            {
                return "Bad News " + employeeFirstName + " did not achieve target ";
            }
            else return "This month " + employeeFirstName + " achieved " + salesSalesAchieved;

        }
        //this month produces a short summary based on the salesSalesAchieved of the employee against salesTarget
        /* end functions */
    }
}
