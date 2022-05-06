namespace E_Passport.Models
{
    public interface IPassportOffice
    {
        IEnumerable<PassportOffice> GetAllOfficeDetails();
        PassportOffice Add(PassportOffice passportOffice);
    }
}
