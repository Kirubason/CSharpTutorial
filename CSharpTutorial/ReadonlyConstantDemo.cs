using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class ReadonlyConstantDemo
    {
        public readonly string Subject;
        public const float pi = 3.14f;
        public ReadonlyConstantDemo(string subject)
        {
            Subject = subject;
        }
    }
}
