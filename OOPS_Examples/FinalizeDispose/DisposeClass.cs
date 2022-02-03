using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDispose
{
    public class DisposeClass : IDisposable
    {
        private bool disposed = false;

        public void Print(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
        ~DisposeClass()
        {
            Console.WriteLine("Inside Finalize");
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Inside disposing");
                    // To cleanup managed code objects
                }
                disposed = true;
            }
        }
    }
}
