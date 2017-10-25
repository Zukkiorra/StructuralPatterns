using StructuralPatterns.Adapter.Abstractions;
using StructuralPatterns.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace StructuralPatterns.Adapter.Implementation
{
	public class ThirdPartyBillingSystem
	{
		private IHRSystemAdapter employeeSource;

		public ThirdPartyBillingSystem(IHRSystemAdapter employeeSource)
		{
			this.employeeSource = employeeSource;
		}

		public void ShowEmployeeList()
		{
			List<Employee> employee = employeeSource.GetEmployeeList();

			Console.WriteLine("######### Employee List ##########");
			foreach (var item in employee)
			{
				var json = new JavaScriptSerializer().Serialize(item);
				Console.WriteLine(json);
			}

		}
	}
}
