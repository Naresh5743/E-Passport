namespace E_Passport.Models
{
    public class MockPassportOffice : IPassportOffice
    {
        private List<PassportOffice> _passportOfficeList;

        public MockPassportOffice()
        {
            _passportOfficeList = new List<PassportOffice>()
            {
                new PassportOffice() {OfficeID=1, OfficeName="PSK Delhi", Jurisdiction="RPO Delhi", Address="MM Towers, Plot No. 8 & 9, Phase IV, Udyog Vihar, Gurgaon", PhoneNumber=1234567890},
                new PassportOffice() {OfficeID=2, OfficeName="PSK Chennai", Jurisdiction="RPO Chennai", Address="Claret Complex, Duraisamy Reddy Street, Tambaram, Chennai", PhoneNumber=1234567890},
                new PassportOffice() {OfficeID=3, OfficeName="PSK Goa", Jurisdiction="RPO Goa", Address="Passport Seva Kendra, Passport Bhavan, EDC Complex, Patto, Panaji", PhoneNumber=1234567890}
            };
        }

        public PassportOffice Add(PassportOffice passportOffice )
        {
            passportOffice.OfficeID = _passportOfficeList.Max(p => p.OfficeID) + 1;
            _passportOfficeList.Add(passportOffice);
            return passportOffice;
        }

        public IEnumerable<PassportOffice> GetAllOfficeDetails()
        {
            return _passportOfficeList;
        }
    }
}
