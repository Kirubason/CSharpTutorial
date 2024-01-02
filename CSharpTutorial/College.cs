using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class College
    {
        string collegeName = "Anna University";
        public string PrincipalName = "Peter";
        public void CollegeMethod()
        {
            Console.WriteLine("This method is called from college class and college name is " + collegeName);
        }
    }
    public class Department : College
    {
        string DepartmentName = "Mechanical";
        public void DepartmentMethod()
        {
            Console.WriteLine("This method is called from department class and department name is " + DepartmentName);
            Console.WriteLine("This method is called from department class and Principal name is " + PrincipalName);
        }
    }
}
