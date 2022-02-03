using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    // Abstract class can have abstract as well as non abstract methods
    // behaves like interface as well
    // cannot create an object of an abstract class
    // abstract class can inherit another class
    // can inherit interface
    // cannnot declare abstract class as static
    public abstract class AbstractExample : Emp, IEmp
    {
        // can create consrtuctor
        public AbstractExample()
        {

        }

        // can declare varibales;
        int age = 20;

        // can declare static methods
        public static string GetDay()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }

        //abstract methods only have signature
        // abstract methods cannot be private
        public abstract void test();

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    public class Emp
    {
        public string GetNameofEmp()
        {
            return "Roma";
        }
    }

    interface IEmp
    {

    }
}