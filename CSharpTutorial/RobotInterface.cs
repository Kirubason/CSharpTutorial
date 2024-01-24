using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    interface RobotInterface
    {
        void Sensor();
        void Body();
    }
    public class ChildRobot : RobotInterface
    {
        public void Body()
        {
            Console.WriteLine("This Robot has been made with different material");
        }

        public void Sensor()
        {
            Console.WriteLine("This Robot has Temp, Light, Sound and GPS sensors");
        }
    }
}
