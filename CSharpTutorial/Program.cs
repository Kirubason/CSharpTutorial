using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildRobot Interfaceobj = new ChildRobot();
            Interfaceobj.Sensor();
            Interfaceobj.Body();
            ChildRobotClass AbstractObj = new ChildRobotClass();
            AbstractObj.Sensor();
            AbstractObj.Body();
        }
    }
}
