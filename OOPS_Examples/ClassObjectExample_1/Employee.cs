namespace ClassObjectExample_1
{
    // by default access modifier is Internal
    // Internal : can access within same project 
    class Employee
    {
        // Creation of an object
        EmployeeDetails empDetails = new EmployeeDetails();

        public void GetBasicDetails()
        {
            // can access lastName because it is public 
            empDetails.lastName = "Patel";

            // can access middleName as it is Internal
            empDetails.middleName = "Kushal";
        }
    }
}