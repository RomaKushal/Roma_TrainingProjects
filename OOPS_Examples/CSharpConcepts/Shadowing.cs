using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Shadowing
    {
        public class BaseClass
        {
            public virtual string GetMethodOwnerName()
            {
                return "Base Class";
            }
        }
        public class ChildClass : BaseClass
        {
            public new virtual string GetMethodOwnerName()
            {
                return "Child Class";
            }
        }

        static void Main(string[] args)
        {
            BaseClass c = new ChildClass();
            Console.WriteLine(c.GetMethodOwnerName());
            Console.ReadLine();
        }
    }
}
