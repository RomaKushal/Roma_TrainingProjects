using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLExample;

namespace AssemblyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.GetDLLMessage());

            Console.WriteLine("Hello");
            Console.Read();
        }
    }
}
