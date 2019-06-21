using System.ComponentModel;

namespace Web.PassportCapture.Models
{
    public class ValidationResultViewModel
    {
        [DisplayName("Passport Number Check Digit")]
        public bool PassportNumberChecksumValid { get; set; }

        [DisplayName("Date Of Birth Check Digit")]
        public bool DOBChecksumValid { get; set; }

        [DisplayName("Passport Expiration Date Check Digit")]
        public bool ExpirationChecksumValid { get; set; }

        [DisplayName("Personal Number Check Digit")]
        public bool PersonalNumberChecksumValid { get; set; }

        [DisplayName("Final Check Digit")]
        public bool FinalChecksumValid { get; set; }

        [DisplayName("Gender Cross Check")]
        public bool GenderCCValid { get; set; }

        [DisplayName("Date Of Birth Cross Check")]
        public bool DOBCCValid { get; set; }

        [DisplayName("Expiration Date Cross Check")]
        public bool ExpirationDateCCValid { get; set; }

        [DisplayName("Nationality Cross Check")]
        public bool NationalityCCValid { get; set; }

        [DisplayName("Passport Number Cross Check")]
        public bool PassportNoCCValid { get; set; }

        public string Outcome(bool b) => b ? "Pass" : "Fail";
    }
}
