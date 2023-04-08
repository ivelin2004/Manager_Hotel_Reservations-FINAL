using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
    public class Users:Class_Id
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
		[Display(Name = "First Name")]
		[DataType(DataType.Text)]
		public string? FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string? LastName { get; set; }
        public int EGN { get; set; }
        public int Number { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public bool IsAccountActive { get; set; }
        public DateTime DateOfDismissal { get; set; } //tova ima da se misli

       /*
        // Constructor with parameters
        public Users(string username, string password, string firstName, string lastName, int egn, int number, string email, DateTime dateOfAppointment, bool isAccountActive, DateTime? dateOfDismissal)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            EGN = egn;
            Number = number;
            Email = email;
            DateOfAppointment = dateOfAppointment;
            IsAccountActive = isAccountActive;
            DateOfDismissal = dateOfDismissal;
        }

        */
    }
}
