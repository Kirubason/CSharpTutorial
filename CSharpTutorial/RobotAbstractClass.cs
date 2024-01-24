using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public abstract class RobotAbstractClass
    {
        public string sensors = "Temp, Light, Sound and GPS";
        public abstract void Sensor();
        public void Body()
        {
            Console.WriteLine("This Robot has been made with different material");
        }
    }
    public class ChildRobotClass : RobotAbstractClass
    {
        public override void Sensor()
        {
            Console.WriteLine("This Robot has " + sensors + "sensors");
        }
    }
}
