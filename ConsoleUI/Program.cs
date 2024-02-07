using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Start counting guests at 0
			int totalguests = 0;
			// Initialize guest list
			List<string> guestlist = new List<string>();
			// Initialize done checker
			string done;

			do
			{
				//Get user name
				string guestname = GetGuestName();
				//Add name to guest list
				guestlist.Add(guestname);
				//Get # of people in party
				int partysize = GetPartySize();
				//Add # of people to total guests
				totalguests += partysize;
				//Ask if done
				Console.Write("Done (yes/no): ");
				done = Console.ReadLine();
				//If not done loop back to get user name
				//If done move on
			} while ( done.ToLower() != "yes" );

			//Print out list of people
			//Print out total # of people
			DisplayGuestList(guestlist, totalguests);

			_ = Console.ReadLine();
		}

		private static string GetGuestName()
		{
			Console.Write("What is the name of your party: ");
			string output = Console.ReadLine();
			return output;
		}

		private static int GetPartySize()
		{
			bool issizevalid;
			int output;

			do
			{
				Console.Write("How many people in your party: ");
				string partysize = Console.ReadLine();
				issizevalid = int.TryParse(partysize, out output);
				if ( !issizevalid )
				{
					Console.WriteLine("Please enter the number using digits.");
				}
			} while ( !issizevalid );

			return output;
		}

		private static void DisplayGuestList(List<string> guestList, int totalGuests)
		{
			Console.WriteLine("Party Guest List");
			foreach ( string guest in guestList )
			{
				Console.WriteLine(guest);
			}

			Console.WriteLine($"Total Guests: {totalGuests}");
		}
	}
}
