using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    public class InterfaceExample
    {
        // cannot create an instance of an object
        // IEmployee emp = new IEmployee();
        
    }

    // Default interface is internal
    // contains methods , properties, events and indexers
    public interface IEmployee
    {
        // cannot create constructor
        //public IEmployee()
        //{

        //}
        event EventHandler EmployeeNameChanged;
        string this [int index] { get;set; }

        // can create properties
        int EmployeeId { get; set; }

        //cannot create constructors
        // Only Signature no implementation

        // By default all methods are public so no need to define access modifier 
        // it gives an error
        // public  string GetName();


        // cannot create/define variables
        // int age = 20;
        string GetName();
    }

    // interface can inherit another interface

    // when inherit interface need to implement all methods
    public class class3 : IEmployee
    {
        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int EmployeeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler EmployeeNameChanged;

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
    interface I2 : IEmployee
    {

    }

    interface I3
    { void Save(); }

    interface I4
    { void Save();  }


    // interface cannot inherit class
    //interface I3 : Employee
    //{

    //}

    #region Multiple inheritance achieve by interface

    // for implementing multiple inheritance , order should be in this manner
    // means class should inherit first if user want then interface will be inherited
    // it gives an error if you inherit class after interface (I3,I4,InterfaceExample)
    public class class1 : InterfaceExample, I3, I4
    {
        // If two interfaces have same methods then implement interface explicitly
        // called explicit implementation 
        void I3.Save()
        {
            throw new NotImplementedException();
        }

        void I4.Save()
        {
            throw new NotImplementedException();
        }

        // implicit implementataion / Direct implementataion
        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region calling implicit/explicit methods of interface

    
    // implicit Implementation
    public class Class4 : I3, I4
    {
        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    // Explicit Implementation
    public class Class5 : I3, I4
    {
        void I3.Save()
        {
            throw new NotImplementedException();
        }

        void I4.Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Class6
    {
        Class4 cls4 = new Class4();

        // cannot create object for explict implementation in such a way
        //Class5 cls5 = new Class5();
        I3 interface3 = new Class5();

        void print()
        {
            cls4.Save();
            interface3.Save();
        }
    }

    #endregion
}