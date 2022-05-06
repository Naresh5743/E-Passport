using System.ComponentModel.DataAnnotations;

namespace E_Passport.Models
{
    public class ScheduleAppointment
    {
        public int MonthID { get; set; }
        [Required]
        public string? MonthName { get; set; }
        [Required]
        public string? AvailableDays { get; set; }
        [Required]
        public string? TimeSlots { get; set; }
    }
}
