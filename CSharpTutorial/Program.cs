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
			TaminNadu taminNadu = new TaminNadu();
		}
	}

	public class India
	{
		public int medicalColleges = 706;
        public India()
        {
            Console.WriteLine("This is parameterless constructor in India");
		}
        public India(bool value)
        {
			Console.WriteLine("This is parameter constructor in India");
		}
    }

	public class TaminNadu : India
	{
		public int medicalColleges = 74;

		public TaminNadu() : base(true)
		{
			Console.WriteLine("Total medical colleges in India: " + base.medicalColleges);
			Console.WriteLine("Total medical colleges in Tamilnadu:" + this.medicalColleges);
		}

	}
}
