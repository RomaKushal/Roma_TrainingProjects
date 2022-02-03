using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            //FinaizeClass fc = new FinaizeClass();
            //fc = null;
            //Console.WriteLine("Destructor is called");
            //GC.Collect();
            //Console.ReadLine();

            DisposeClass dc = new DisposeClass();
            Console.WriteLine("Dispose object created");
            dc.Print("Roma Patel");
            dc.Dispose();
            dc = null;
            Console.WriteLine("object dtructing..");
            Console.ReadLine();
        }
    }
}
