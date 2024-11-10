using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Car
    {
		#region properties
		public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
		#endregion properties

		#region constructors
		public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
		public Car()
		{

		}
		public Car(string make, string model, int year)
		{
			Make = make;
			Model = model;
			Year = year;
		}
		#endregion constructors

		#region Methods
		public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting.");
        }

        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} has stopped.");
        }
        private void CheckEngine()
        {
            Console.WriteLine("Checking the engine.");
        }
		#endregion Methods
	}
}
