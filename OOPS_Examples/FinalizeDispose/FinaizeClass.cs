using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDispose
{
    public class FinaizeClass
    {
        ~FinaizeClass()
        {
            Console.WriteLine("Finalize Called");
            //Console.Read();
        }
    }
}
