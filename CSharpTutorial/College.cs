using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class College
    {
        static string collegeName = "Anna University";
        static string DepartmentName = "Mechanical";
        static int Year;
        public static string CollegeMethod()
        {
            return collegeName + " and " + DepartmentName + " and " + Year;
        }
        static College()
        {
            Year++;
        }
    }

}
