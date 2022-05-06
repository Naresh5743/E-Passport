namespace E_Passport.Models
{
    public interface IScheduleAppointment
    {
        ScheduleAppointment Add(ScheduleAppointment appointmentDetails);
        IEnumerable<ScheduleAppointment> GetAllAppointments();
    }
}
