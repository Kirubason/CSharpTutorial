using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class District
	{
		public static void UpdateToDistrictOffice(object sender, VotingCountChangedEventArgs e)
		{
			Console.WriteLine($"The voting count of {e.Thoguthi} changed to {e.NewVotingCount} and updated in District office");
		}
	}
}
