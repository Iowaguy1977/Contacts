using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings= false,ErrorMessage ="First name is required")]
        public string? FirstName { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        public string? LastName { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string? Address { get; set; } = string.Empty;
        public string? Address2 { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; } = string.Empty;
        public string? PhoneNumber2 { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailAddress is required")]
        public string EmailAddress { get; set; }=string.Empty;
        public string? EmailAddress2 { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
