using Manager_Hotel_Reservations.Data;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Manager_Hotel_Reservations.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new Manager_Hotel_ReservationsContext(
				serviceProvider.GetRequiredService<DbContextOptions<Manager_Hotel_ReservationsContext>>()))
			{
				// Look for any clients.
				if (context.Clients.Any())
				{
					return;   // DB has been seeded
				}
				context.Clients.AddRange(
					new Clients
					{
						FirstName = "Alexander",
						LastName = "Aleksandrov",
						Number = 0894457898,
						Email = "aleksandar.aleksandrov@abv.bg",
						IsAdult = true
					},
					new Clients
					{
						FirstName = "Alexander2",
						LastName = "Aleksandrov2",
						Number = 0894457897,
						Email = "aleksandar2.aleksandrov2@abv.bg",
						IsAdult = false
					},
					new Clients
					{
						FirstName = "Georgi",
						LastName = "Georgiev",
						Number = 0894457898,
						Email = "georgi.georgiev@abv.bg",
						IsAdult = true
					},
					new Clients
					{
						FirstName = "Georgi2",
						LastName = "Georgiev2",
						Number = 0894457898,
						Email = "georgi2.georgiev2@abv.bg",
						IsAdult = false
					}
				);
				context.SaveChanges();

			}

			/*using (var context = new Manager_Hotel_ReservationsContext(
				serviceProvider.GetRequiredService<DbContextOptions<Manager_Hotel_ReservationsContext>>()))
			{
				if (context.Reservations.Any())
				{
					return;   // DB has been seeded
				}

				context.Reservations.AddRange(
					new Reservations
					{
						ReservedRoom = 101,
						User = "John Doe",
						Clients = "Jane Doe, Jack Smith",
						CheckInDate = new DateTime(2023, 4, 15),
						CheckOutDate = new DateTime(2023, 4, 18),
						BreakfastIncluded = true,
						AllInclusive = false,
						AmountToPay = true
					},
					new Reservations
					{
						ReservedRoom = 102,
						User = "Jane Doe",
						Clients = "John Doe, Jack Smith",
						CheckInDate = new DateTime(2023, 4, 20),
						CheckOutDate = new DateTime(2023, 4, 22),
						BreakfastIncluded = false,
						AllInclusive = false,
						AmountToPay = true
					},
					new Reservations
					{
						ReservedRoom = 103,
						User = "Jack Smith",
						Clients = "John Doe, Jane Doe",
						CheckInDate = new DateTime(2023, 5, 1),
						CheckOutDate = new DateTime(2023, 5, 5),
						BreakfastIncluded = true,
					}
		);
				context.SaveChanges();

			*/
		}
	}
}
