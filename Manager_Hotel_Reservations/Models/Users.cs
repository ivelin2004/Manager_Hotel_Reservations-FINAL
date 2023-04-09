using System.ComponentModel.DataAnnotations;

namespace Manager_Hotel_Reservations.Models
{
    public class Users:Class_Id
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
		[Display(Name = "First Name")]
		[DataType(DataType.Text)]
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int EGN { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        public bool IsAccountActive { get; set; }
        [Required]
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
