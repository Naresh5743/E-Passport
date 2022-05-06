using System.ComponentModel.DataAnnotations;

namespace E_Passport.Models
{
    public class PassportOffice
    {
        public int OfficeID { get; set; }
        [Required]
        public string? OfficeName { get; set; }
        [Required]
        public string? Jurisdiction { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
    }
}
