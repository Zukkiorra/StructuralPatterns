namespace StructuralPatterns.Adapter.Implementation
{
	/// <summary>
	/// The 'Adaptee' class
	/// </summary>
	public class HRSystem
	{
		public string[][] GetEmployees()
		{
			string[][] employees = new string[4][];

			employees[0] = new string[] { "100", "Blagoje", "Marijanovic", "Team Leader" };
			employees[1] = new string[] { "101", "Aleksandar", "Tirnanic", "Developer" };
			employees[2] = new string[] { "102", "Milutin", "Ivkovic", "Developer" };
			employees[3] = new string[] { "103", "Ivan", "Bek", "QA" };

			return employees;
		}
	}
}
