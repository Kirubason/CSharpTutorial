using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public delegate void VotingCountChangedHandler(object sender, string Thoguthi, int newVotingCount);
	public class Election
	{

		public event VotingCountChangedHandler VotingCountChanged;
		private int votingCount;
		public string Thoguthi { get; }

		public Election(string thoguthi, int InitialVotingCount)
		{
			Thoguthi = thoguthi;
			votingCount = InitialVotingCount;
		}

		public int VotingCount
		{
			get { return votingCount; }
			set
			{
				if (VotingCount != value)
				{
					votingCount = value;
					OnVotingCountChanged(Thoguthi, value);
				}
			}
		}
		protected virtual void OnVotingCountChanged(string Thoguthi,int newVotingCount)
		{
			VotingCountChanged?.Invoke(this, Thoguthi, newVotingCount);
		}
	}
}
