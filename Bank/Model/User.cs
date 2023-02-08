using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    internal class User : Person
    {
		private string userID;
		
		public User(string name, string _userID) : base(name)
		{
			userID = _userID;
		}

		
	}
}
