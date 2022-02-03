using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(50);
            rect.Width = 20;
            Console.WriteLine($"Rectangle area: {rect.Area()}");

            Console.ReadKey();
        }

        // Rectangle class 
        public class Rectangle : Shape
        {
            private int width;
            private int height;

            public Rectangle(int height)
            {
                this.height = height;
            }

            public override int Height { set => height = value; }
            public int Width { set => width = value; }

            public override int Area()
            {
                return this.height * this.width;
            }
        }
      
        // Abstract class  
        abstract public class Shape
        {
            // Abstract properties  
            public abstract int Height { set; }

            // Abstract method  
            public abstract int Area();
        }
    }
}
