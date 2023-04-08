using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manager_Hotel_Reservations.Models;

namespace Manager_Hotel_Reservations.Data
{
    public class Manager_Hotel_ReservationsContext : DbContext
    {
		internal object Rooms;

		public Manager_Hotel_ReservationsContext (DbContextOptions<Manager_Hotel_ReservationsContext> options)
			: base(options)
        {
        }

        public DbSet<Manager_Hotel_Reservations.Models.Clients> Clients { get; set; } = default!;

        public DbSet<Manager_Hotel_Reservations.Models.Users> Users { get; set; } = default!;

        public DbSet<Manager_Hotel_Reservations.Models.Rooms> Rooms_1 { get; set; } = default!;

        public DbSet<Manager_Hotel_Reservations.Models.Reservations> Reservations { get; set; } = default!;
    }
}
