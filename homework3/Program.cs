using System;

namespace Drive
{
    class program
    {
        static void Main(string[] args)
        {
            Driving driving = new Driving();
            driving.Drive(new Bicycle());
        }
    }
}
