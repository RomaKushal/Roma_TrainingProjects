using System;
using ClassObjectExample_1;

namespace ClassObjectExample_2
{
    public class Organization : EmployeeDetails
    {
        EmployeeDetails empData = new EmployeeDetails();
        public void PrintData()
        {
            // Protected members can be accessible in other project\
            // Must inherit Base class
            GetDay();

            // Protected Internal members :
            // in other projects can be accessible by child class only 
            // cannot be accessible by creating an object
            GetMonth();
        }
    }

    public class Admin : IEmployee
    {
        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int EmployeeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler EmployeeNameChanged;

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
    }
}