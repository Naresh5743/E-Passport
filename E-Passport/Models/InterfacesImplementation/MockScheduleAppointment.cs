namespace E_Passport.Models
{
    public class MockScheduleAppointment : IScheduleAppointment
    {
        private List<ScheduleAppointment> _scheduleAppointmentList;

        public MockScheduleAppointment()
        {
            _scheduleAppointmentList = new List<ScheduleAppointment>()
            {new ScheduleAppointment() { MonthID=1, MonthName="January", AvailableDays="3, 4, 5", TimeSlots="10-12, 2-4"} };
        }
        public ScheduleAppointment Add(ScheduleAppointment appointmentDetails)
        {
            
            appointmentDetails.MonthID = _scheduleAppointmentList.Max(s => s.MonthID) + 1;
            _scheduleAppointmentList.Add(appointmentDetails);
            return appointmentDetails;
        }

        public IEnumerable<ScheduleAppointment> GetAllAppointments()
        {
            return _scheduleAppointmentList;
        }
    }
}
