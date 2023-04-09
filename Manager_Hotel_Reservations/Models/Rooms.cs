using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
    public class Rooms:Class_Id
    {
        //da se napravi crud na tozi klas , ot scaffold item ...
        [Required]
        [Display(Name = "Capacity ")]
        [DataType(DataType.Text)]
        public int Capacity { get; set; }

		[Display(Name = "Room Type ")]
		[DataType(DataType.MultilineText)]
        [Required]
        public string? RoomType { get; set; }

		[Display(Name = "Is Free")]
		[DataType(DataType.Text)]
        [Required]
        public bool IsFree { get; set; }

		[Display(Name = "Price Bed Adult")]
		[DataType(DataType.Currency)]
        [Required]
        public decimal PricePerOccupiedBedAdult { get; set; }

		[Display(Name = "Price Bed Children")]
		[DataType(DataType.Currency)]
        [Required]
        public decimal PricePerOccupiedBedChildren { get; set; }

		[Display(Name = "Number")]
		[DataType(DataType.Text)]
        [Required]
        
        public int Number { get; set; }
    }
}

        /*
        public Rooms(int capacity, Type roomType, bool isFree, decimal pricePerOccupiedBedAdult, decimal pricePerOccupiedBedChildren, int number)
        {
            Capacity = capacity;
            RoomType = roomType;
            IsFree = isFree;
            PricePerOccupiedBedAdult = pricePerOccupiedBedAdult;
            PricePerOccupiedBedChildren = pricePerOccupiedBedChildren;
            Number = number;
        }
    }
    method da se proverqva za kolko dushi e Capacity
    Venue myVenue = new Venue();
    myVenue.Capacity = 100; // the venue can hold up to 100 people
    int numAttendees = 80;
    if (myVenue.Capacity >= numAttendees)
{
Console.WriteLine("The venue can accommodate {0} people.", numAttendees);
}
else
{
Console.WriteLine("The venue does not have enough space for {0} people.", numAttendees);
}
 */
