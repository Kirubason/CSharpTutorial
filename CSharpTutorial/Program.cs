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

			election.VotingCountChanged += District.UpdateToDistrictOffice;
			election.VotingCountChanged += State.UpdateToStateOffice;
			election.VotingCountChanged += Union.UpdateToUnionOffice;

			election.VotingCount = 1121;
			Console.WriteLine();

			election.VotingCount = 3450;
			Console.WriteLine();

			election.VotingCount = 8150;
			Console.WriteLine();
		}
		
	}
}
