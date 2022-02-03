using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    // static class does not constructor
    // cannot inherit static class
    // cannot create instance iof a class
    // By default members and methods are private
    // cannot inherit other class
    // used for creating extension methods
    // features of both abstract and sealed
    //cannot have constructor
    public static class StaticClass 
    {
        // only have static members
        public static int a;
        
        // only have static methods
         public static int add(int a , int b)
        { return a = b; }

    }
    public  class Class1
    {
       public void print()
        {
           int result =  StaticClass.add(10, 20);
        }
    }
}