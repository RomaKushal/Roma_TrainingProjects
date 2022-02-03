using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 50;

            // output : age = 50
            Console.WriteLine("Start Age is :" + age);

            GetValData(age);
            Console.WriteLine("After Val Method Call Age is :" + age);

            GetRefData(ref age);
            Console.WriteLine("After Ref Method Call Age is :" + age);
        }
        private static void GetValData(int val1)
        {
            // output : 50
            Console.WriteLine("value is :" + val1);
            val1 = 60;
        }
        private static void GetRefData(ref int val2)
        {

            Console.WriteLine("value is :" + val2);
            val2 = 60;
        }
    }
}
