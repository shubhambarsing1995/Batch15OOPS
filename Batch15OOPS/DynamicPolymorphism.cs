using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{ 
    //dynamic polymorphism //method overriding //late binding //run time polymorphism
    //method name same also parameter same but different class and we follow paraent child relationship

    //base class- parent class
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("drawing shape");
        }

    }

    //derived class-chield class
    class circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {

            Console.WriteLine("drawing Rectangle");
        }
    }

    internal class DynamicPolymorphism
    {
        static void Main()
        {
            Shape Shape1 = new Shape();
            Shape Shape2 = new circle();
            Shape Shape3 = new Rectangle();

            //calling method







        }




    }

}
