using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    public class Polymorphism
    {
        // Polymorphism : one name many forms
        //Two Types : Overloading and Overrriding

        #region Method Overloading

        // Different Methods with the same name but different parameters in a single class
        // also called Early Binding, Complite time and Static
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // This will work as C# is case sensitive
        public int sum(int a, int b)
        {
            return a + b;
        }

        //This will not work as it has same parameters with same datatypes
        //public string Sum(int a, int b)
        //{
        //    return (a + b).ToString();
        //}

        public long sum(long a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        #endregion

        #region Method Overriding

    }


    // inherited from Base class
    // Ovverriden by override declaration
    // Overriden Base method must have same signature as the Override method
    // Also called Dynamic,Late Binding and Runtime
    // Cannot override 
    public class CustomerDetails
    {
        public virtual string GetCustomerName()
        {
            return "Roma";
        }

        protected virtual string GetCustomerFirstName()
        {
            return "Roma";
        }

        internal virtual string GetCustomerMiddleName()
        {
            return "Kushal";
        }

        protected internal virtual string GetCustomerLastName()
        {
            return "Patel";
        }
    }

    public class SuperAdmin : CustomerDetails
    {
        public override string GetCustomerName()
        {
            return "Patel";
        }

        protected override string GetCustomerFirstName()
        {
            return "Romna";
        }

        internal override string GetCustomerMiddleName()
        {
            return "Kushal";
        }

        protected internal override string GetCustomerLastName()
        {
            return "Patel";
        }
    }
    #endregion
}