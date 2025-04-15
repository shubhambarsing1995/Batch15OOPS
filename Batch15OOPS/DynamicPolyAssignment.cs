using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    //base/parrent class
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("vechile engine started");
        }
    }
    //child class
    class Car: Vehicle
    {

        public override void StartEngine()
        {
            Console.WriteLine("car engine started");
        }
    }

    class Truck : Vehicle
    {

        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started");
        }
    }
    class DynamicPolyAssignment
    {
        public void Main()
        {
            Vehicle vechile1 = new Vehicle();
            Vehicle vechile2 = new Car();
            Vehicle vechile3 = new Truck();
            //Calling method
            vechile1.StartEngine();
            vechile2.StartEngine();
            vechile3.StartEngine();
        }

    }
}
