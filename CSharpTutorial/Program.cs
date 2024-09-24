using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine(GetEnumDescription(CollegeRank.AnnaUniversity) + " college councelling code is " + (int)CollegeRank.AnnaUniversity);
			Console.WriteLine(GetEnumDescription(CollegeRank.GovtClgTvl) + " councelling code is " + (int)CollegeRank.GovtClgTvl);

			Console.ReadLine();
		}

		public enum CollegeRank
		{
			[Description("Anna University")]
			AnnaUniversity = 1,

			[Description("Government College of Technology, Coimbatore")]
			GovtClgCoimbatore = 7177,

			[Description("Government College of Engineering, Tirunelveli")]
			GovtClgTvl = 9508,

			[Description("Mepco Schlenk Engineering College")]
			MepcoClg = 9517
		}

		public static string GetEnumDescription(Enum value)
		{
			var field = value.GetType().GetField(value.ToString());
			var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
			return attribute == null ? value.ToString() : attribute.Description;
		}


	}
}
