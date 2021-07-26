using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse {
        [Required(ErrorMessage = "Please enter your full name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your e-mail")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a telephone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid telephone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please state whether you will attend or not")]
        public bool? WillAttend { get; set; }
    }

}