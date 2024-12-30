using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class VotingCountChangedEventArgs
	{
		public string Thoguthi { get; }
		public int NewVotingCount { get; }

		public VotingCountChangedEventArgs(string thoguthi, int newVotingCount)
		{
			Thoguthi = thoguthi;
			NewVotingCount = newVotingCount;
		}
	}
}
