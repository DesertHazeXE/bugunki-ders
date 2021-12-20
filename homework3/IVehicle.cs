using System;
using System.Collections.Generic;
using System.Text;


namespace Drive
{
    interface IVehicle
    {
        void Drive();
    }
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("car is driving");
        }
    }
     
    class Bicycle : Car
    {
        public void drive()
        {
            Console.WriteLine("bicycle is driving");
        }
    }
    class Driving
    {
        public void Drive(IVehicle vehicle)
        {
            vehicle.Drive();
        }
    }
}
   