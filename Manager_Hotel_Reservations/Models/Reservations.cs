using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
	public class Reservations:Class_Id
	{
		[Display(Name = "Reserved Room")]
		[DataType(DataType.Text)]
		public int ReservedRoom { get; set; }
		public string? User { get; set; }
		public string? Clients { get; set; }

		[Display(Name = "Check In  Date")]
		[DataType(DataType.Date)]
		public DateTime CheckInDate { get; set; }

		[Display(Name = "Check Out  Date")]
		[DataType(DataType.Date)]
		public DateTime CheckOutDate { get; set; }

		[Display(Name = "Breakfast Included")]
		[DataType(DataType.Text)]
		public bool BreakfastIncluded { get; set; }

		[Display(Name = "All Inclusive")]
		[DataType(DataType.Text)]
		public bool AllInclusive { get; set; }

		[Display(Name = "Amount To Pay")]
		[DataType(DataType.Currency)]
		public bool AmountToPay { get; set; }
		/*public decimal AmountDue
		{
			get
			{
				// Calculate amount due based on selected room, clients, and options
				// and return the calculated value
				decimal roomCost = // cost of reserved room
				decimal clientCost = // cost per client
				decimal optionCost = 0;
				if (BreakfastIncluded)
				{
					optionCost += // cost of breakfast per client

			}
				if (AllInclusive)
				{
					optionCost += // cost of all-inclusive per client

			}
				return roomCost + (Clients.Count * clientCost) + optionCost;
			}
		}
		*/
	}
}
