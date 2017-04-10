using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayEmployee
{
    class Developer : Employee
    {
        public double developerOvertime = 0;
        public string[] developerLanguages = {"C Sharp", "Javascript", "Python"};
        public bool isStarWarsFan = true;
        //here we declare variables that are used only in this child class

        /* start properties */
        public string[] Languages
        {
            get { return this.developerLanguages; }
            set { this.developerLanguages = value; }
        }
        //this the declaration of a property, Languages. It allows get and set; it can be changed.

        public double employeeInput
        {
            get { return this.developerOvertime; }
            set { this.developerOvertime = value; }
        }
        //we use the double employeInput globally in the Employee class. Here we set it for developers as
        //equal to developerOvertime
        /*end properties*/

        /* start constructors */
        public Developer(double employeeSalary, string employeeFirstName, string employeeSecondName, string employeeType) : base(employeeSalary, employeeFirstName, employeeSecondName, employeeType)
        {
            this.employeeSalary = employeeSalary;
            this.employeeFirstName = employeeFirstName;
            this.employeeSecondName = employeeSecondName;
            this.employeeType = employeeType;
        }
        //this is a constructor, as per the Employee object.
        /* end constructors */

        /* start functions */
        public string DeveloperSummary(double developerOvertime)
        {
            if (developerOvertime <= 2)
            {
                return "This month " + employeeFirstName + " worked an extra " + developerOvertime + " hours. Take Friday afternoon off";
            }
            else if (developerOvertime >= 5)
            {
                return "This month " + employeeFirstName + " worked an extra " + developerOvertime + " hours!";
            }
            else return "This month " + employeeFirstName + " didnt work any overtime." ;

        }
        //this month produces a short summary based on the DeveloperOvertime.
        /* end functions */
    }
}
