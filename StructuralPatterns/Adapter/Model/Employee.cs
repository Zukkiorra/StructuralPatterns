using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Model
{
	public class Employee
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Position { get; set; }

		public Employee(string Id, string Name, string LastName, string Position)
		{
			this.Id = Id;
			this.Name = Name;
			this.LastName = LastName;
			this.Position = Position;
		}
	}
}
