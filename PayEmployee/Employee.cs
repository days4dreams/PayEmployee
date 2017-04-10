using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayEmployee
{
    class Employee
    {
        public double employeeSalary = 0;
        public string employeeTitle = "Employee";
        public string employeeFirstName = string.Empty;
        public string employeeSecondName = string.Empty;
        public double employeeBonus = 0;
        public double monthlyGross = 0;
        public string employeeType = string.Empty;
        public string[] employeeKind = { "Marketeer", "SalesPerson", "Developer" };
        //here we declare variables that are shared by the two constructors and the properties, and child classes


        /* start properties */
        public double Salary
        {
            get { return this.employeeSalary; }
            set { this.employeeSalary = value; }
        }
        //this the declaration of a property, Salary. It allows get and set; the amount can be changed.

        public string JobTitle
        {
            get { return this.employeeTitle; }
        }
        //this the declaration of a property, JobTitle. It has no set function; all titles are final.

        public double Bonus
        {
            get { return this.employeeBonus; }
            set { this.employeeBonus = value; }
        }
        //this is a another property, Bonus  

        public string FirstName
        {
            get { return this.employeeFirstName; }
            set { this.employeeFirstName = value; }
        }

        public string SecondName
        {
            get { return this.employeeSecondName; }
            set { this.employeeSecondName = value; }
        }
        //this is a another property, Bonus     
        /* end properties */


        /* start constructors */
        public Employee(double employeeSalary, string employeeFirstName, string employeeSecondName, string employeeType)
        {
            this.employeeSalary = employeeSalary;
            this.employeeFirstName = employeeFirstName;
            this.employeeSecondName = employeeSecondName;
            this.employeeType = employeeType;
        }
        //this is a constructor, for the Employee object. It requires a full Name, Type and Salary to be input.
        /* end constructors */


        /* start functions */
        public double CalculateBonus(double employeeInput)
        {
            if (employeeType == "Marketeer")
            {
                employeeBonus = employeeInput * 2;
                return employeeBonus;
            }
            else if (employeeType == "SalesPerson")
            {
                employeeBonus = employeeInput * 3;
                return employeeBonus;
            }
            else if (employeeType == "Developer")
            {
                employeeBonus = employeeInput * 4;
                return employeeBonus;
            }
            else Console.WriteLine("Invalid Input");
            employeeBonus = 0;
            return employeeBonus;
        }
        //this is a function. when we call it in the program, it takes the employeeInput and calculates the bonus 
        //based on their title. See use of void for the distinction of a function

        public double MonthlyGross()
        {
            monthlyGross = Math.Ceiling(this.employeeSalary / 12) + this.employeeBonus;
            return monthlyGross;
        }
        //this function returns the gross monthly pay for the employee for that month

        public string EmployeeSummary()
        {
            return "\n Employee Summary\n Employee Type: "
                    + this.employeeType
                    + "\n Employee Name: "
                    + this.employeeFirstName + " " + this.employeeSecondName
                    + "\n Employee Annual Gross Salary: "
                    + this.employeeSalary
                    + "\n Employee Bonus: "
                    + this.employeeBonus
                    + "\n Monthly Gross Pay: "
                    + this.monthlyGross;
        }
        //this function produces a summary of the employee
        /* end functions */
    }
}
