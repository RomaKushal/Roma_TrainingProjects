using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassObjectExample_1
{
    public class ExtensionExample
    {
        public static void PrintName()
        {
            string strName = "roma";
            string result = strName.ChangeFirstLetterCase();
        }
        
    }
}