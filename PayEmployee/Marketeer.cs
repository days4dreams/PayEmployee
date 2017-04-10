using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayEmployee
{
    class Marketeer : Employee

    {
        public double marketeerMonthlySales = 0;
        public string marketeerSpecialism = "Marketing";
        //here we declare variables that are used only in this child class

        /* start properties */
        public string Specialism
        {
            get { return this.marketeerSpecialism; }
            set { this.marketeerSpecialism = value; }
        }
        //this the declaration of a property, Specialism. It allows get and set; it can be changed.

        public double employeeInput
        {
            get { return this.marketeerMonthlySales; }
            set { this.marketeerMonthlySales = value; }
        }
        //we use the double employeInput globally in the Employee class. Here we set it for Marketeers as
        //equal to marketeerMonthlySales
        /*end properties*/

        /* start constructors */
        public Marketeer(double employeeSalary, string employeeFirstName, string employeeSecondName, string employeeType) : base(employeeSalary, employeeFirstName, employeeSecondName, employeeType)
        {
            this.employeeSalary = employeeSalary;
            this.employeeFirstName = employeeFirstName;
            this.employeeSecondName = employeeSecondName;
            this.employeeType = employeeType;
        }
        //this is a constructor, as per the Employee object.
        /* end constructors */

        /* start functions */
        public string MarketeersSummary(double marketeerMonthlySales)
        {
            if (marketeerMonthlySales <= 10)
            {
                return "This month " + employeeFirstName + " achieved " + marketeerMonthlySales + " sales. Things have been slow this month! Next month, we need to see improvement";
            }
            else if (marketeerMonthlySales >= 11)
            {
                return "This month " + employeeFirstName + " achieved " + marketeerMonthlySales + " sales. Good Job! Keep up the sales targets next month";
            }
            else return "This month " + employeeFirstName + " achieved " + marketeerMonthlySales;

        }
        //this month produces a short summary based on the MonthlySales of the employee.
        /* end functions */

    }
}
