using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    //Anonymous Method
    //Summary
    public class AnonymousMethod
    {
        
        static void main()
        {
            List<Employees> listEmployees = new List<Employees>()
            {
                new Employees {ID = 101,Name = "Roma"},
                new Employees {ID = 102,Name = "Kushal"}
            };
            // delegate is anonymous method
            
            Employees employees = listEmployees.Find(delegate (Employees emp)
                { return emp.ID == 102; });

        }
    }

    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
         
    }
}