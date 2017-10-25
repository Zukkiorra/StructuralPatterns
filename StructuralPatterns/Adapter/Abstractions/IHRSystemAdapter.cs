using StructuralPatterns.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Abstractions
{
	/// <summary>
	/// The 'IHRSystemAdapter' is target
	/// </summary>
	public interface IHRSystemAdapter
	{
		List<Employee> GetEmployeeList();
	}
}
