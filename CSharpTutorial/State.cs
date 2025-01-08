using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class State
	{
		public static void UpdateToStateOffice(object sender, string Thoguthi, int newVotingCount)
		{
			Console.WriteLine($"The voting count of {Thoguthi} changed to {newVotingCount} and updated in State office");
		}
	}
}
