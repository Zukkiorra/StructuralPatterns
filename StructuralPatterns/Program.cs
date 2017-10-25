using StructuralPatterns.Adapter.Abstractions;
using StructuralPatterns.Adapter.Implementation;
using StructuralPatterns.Bridge.BridgeAbstraction;
using StructuralPatterns.Bridge.Implementation;
using System;
using System.Collections.Generic;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			int index;
			Menu();

			do
			{
				index = int.Parse(Console.ReadLine());
				switch (index)
				{
					case 0:
						Environment.Exit(0);
						break;
					case 1:
						AdapterExample();
						break;
					case 2:
						BridgeExample();
						break;
					case 4:
						Menu();
						break;
					default:
						Menu();
						break;
				}

			} while (true);
		}

		#region Pattern Examples
		private static void AdapterExample()
		{
			Console.Clear();
			Console.WriteLine("///////////////////// Adapter Example ///////////////////// \n");

			IHRSystemAdapter Itarget = new HRSystemAdapter();
			ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
			client.ShowEmployeeList();

			ReturnOrExit();
		}

		private static void BridgeExample()
		{
			Console.Clear();
			Console.WriteLine("///////////////////// Bridge Example ///////////////////// \n");

			var listOfMessages = new List<Message>
									{
										new Message
										{
											Body = "Body text",
											Importance = 1,
											Title = "General message title"
										},
										new UserEditedMessage(new WebServiceSender())
										{
											Body = "User Edited Message",
											Importance = 3,
											UserComments = "Comments",
											Title = "User Edited Title"
										}
									};

			foreach (var message in listOfMessages)
			{
				message.Send();
			}

			ReturnOrExit();
		}
		#endregion Pattern Examples

		#region Menu
		private static void Menu()
		{
			Console.Clear();
			string options = "1. Adapter Example\n2. Bridge Example\n3. Proxy Example\n4. Return\n0: Exit\n\n";
			Console.WriteLine(options + "Enter index: ");
		}

		private static void ReturnOrExit()
		{
			Console.WriteLine("----------------------------------------\n" +
								"Press 4 to return, or 0 to EXIT: "); ;
		}
		#endregion Menu
	}
}
