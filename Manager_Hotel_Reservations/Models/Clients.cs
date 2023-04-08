using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
    public class Clients:Class_Id
    {
		[Display(Name = "First Name")]
		[DataType(DataType.Text)]
		public string? FirstName { get; set; }

		[Display(Name = "Last Name")]
		[DataType(DataType.Text)]
		public string?LastName { get; set; }

		[Display(Name = "Phone Number")]
		[DataType(DataType.PhoneNumber)]
		public int Number { get; set; }

		[Display(Name = "Email Address")]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		[Display(Name = "Is Adult")]
		[DataType(DataType.Text)]
		public bool IsAdult { get; set; } //trqbva da se napravi method za licata nad 18 godini da se schitat za vuzraastni

        /*
        public Clients(string firstName, string lastName, int number, string email, bool isAdult)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Email = email;
            IsAdult = isAdult;

        }
        */
    }
}


