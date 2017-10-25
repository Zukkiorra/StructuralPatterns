using StructuralPatterns.Adapter.Abstractions;
using StructuralPatterns.Adapter.Model;
using System.Collections.Generic;

namespace StructuralPatterns.Adapter.Implementation
{
	/// <summary>
	/// The 'Adapter' class
	/// </summary>
	public class HRSystemAdapter : HRSystem, IHRSystemAdapter
	{
		public List<Employee> GetEmployeeList()
		{
			string[][] employees = base.GetEmployees();
			List<Employee> employeeList = new List<Employee>();
			
			foreach(string[] employee in employees)
			{
				employeeList.Add(new Employee(employee[0], employee[1], employee[2], employee[3]));
			}

			return employeeList;
		}
	}
}
