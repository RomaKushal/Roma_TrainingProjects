using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger1(int n);
namespace CSharpConcepts
{
    class MulticastDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger1 nc;
            NumberChanger1 nc1 = new NumberChanger1(AddNum);
            NumberChanger1 nc2 = new NumberChanger1(MultNum);

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(10);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}

