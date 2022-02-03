using System;

namespace ClassObjectExample_1
{
    // Public : can access in other Projects
    public class EmployeeDetails
    {
        // Class members are private by default
        string firstName = "Roma";
        internal string middleName;
        public string lastName;

         protected string GetDay()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }

        protected internal string GetMonth()
        {
            return DateTime.Now.Month.ToString();
        }
    }

    public class ProfessionalDetails : EmployeeDetails
    {
        EmployeeDetails empData = new EmployeeDetails();

        public void PrintDayofWeek()
        {
            // Protected members can access in child class only 
            // Protected members cannot access by creating an object
            // Need to inherit Class
            GetDay();

            // Protected Internal members
            // For direct access without creating an object need to inherit class
            GetMonth();
        }

        
    }

    public class EmployeeMonthDetails 
    {
        EmployeeDetails empDetails = new EmployeeDetails();
        public void PrintMonth()
        {
            // Protected Internal members : no need to inherit class
            // can access by creating an object
            empDetails.GetMonth();
        }
    }

}