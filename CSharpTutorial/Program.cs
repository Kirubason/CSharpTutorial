using System;
using System.Collections;
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

			Election election = new Election("Tirunelveli", 0);

			election.VotingCountChanged += UpdateToDistrictOffice;
			election.VotingCountChanged += UpdateToStateOffice;
			election.VotingCountChanged += UpdateToUnionOffice;

			election.VotingCount = 1121;
			Console.WriteLine();

			election.VotingCount = 3450;
			Console.WriteLine();

			election.VotingCount = 8150;
			Console.WriteLine();
		}

		private static void UpdateToDistrictOffice(object sender, VotingCountChangedEventArgs e)
		{
			Console.WriteLine($"The voting count of {e.Thoguthi} changed to {e.NewVotingCount} and updated in District office");
		}

		private static void UpdateToStateOffice(object sender, VotingCountChangedEventArgs e)
		{
			Console.WriteLine($"The voting count of {e.Thoguthi} changed to {e.NewVotingCount} and updated in State office");
		}

		private static void UpdateToUnionOffice(object sender, VotingCountChangedEventArgs e)
		{
			Console.WriteLine($"The voting count of {e.Thoguthi} changed to {e.NewVotingCount} and updated in Union office");
		}
	}
}
