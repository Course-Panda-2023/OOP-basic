using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    internal class Person 
    {
		private string name;

		public Person(string _name)
		{
			name = _name;
		}

		public string FirstName
		{
			get { return name; }
			set { name = value; }
		}

		protected virtual void PrintInfo()
		{
			Console.WriteLine($"Name is {name}");
		}
	}
}
