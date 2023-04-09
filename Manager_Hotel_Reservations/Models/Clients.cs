using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
    public class Clients:Class_Id
    {
		[Display(Name = "First Name")]
		[DataType(DataType.Text)]
        [Required]
        public string? FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		[DataType(DataType.Text)]
        
        public string?LastName { get; set; }

		[Display(Name = "Phone Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
		public int Number { get; set; }

		[Display(Name = "Email Address")]
		[DataType(DataType.EmailAddress)]
        [Required]
        public string? Email { get; set; }
		[Display(Name = "Is Adult")]
		[DataType(DataType.Text)]
        [Required]
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


