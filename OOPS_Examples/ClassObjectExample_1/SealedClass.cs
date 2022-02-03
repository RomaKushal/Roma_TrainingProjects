namespace ClassObjectExample_1
{
    // sealed class cannot be inherited
    // can create constructor
    // members and methods are private by deault
    // can inherit other class
     sealed class SealedClass 
    {
      
        public int a;
        static int sum;
        public int Sum(int a, int b)
        { return a + b; }

    }

    public class Class2
    {
        SealedClass class2 = new SealedClass();
        public void print()
        {int result =  class2.Sum(1, 2); }
    }
}