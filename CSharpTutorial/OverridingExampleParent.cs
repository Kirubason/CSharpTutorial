using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class OverridingExampleParent
    {
        public virtual void Job(string job)
        {
            Console.WriteLine("The parent primary job is " + job);
        }
    }

    public class OverridingExampleChild : OverridingExampleParent
    {
        public override void Job(string job)
        {
            Console.WriteLine("The child's primary job is " + job);
        }
    }
}
