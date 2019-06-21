using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.PassportCapture.Models
{
    
    public class PassportViewModel
    {
        [Required]
        [DisplayName("Passport Number")]
        [MaxLength(9, ErrorMessage = "&nbsp;Maximum length 9 chars ")]
        [MinLength(9, ErrorMessage = "&nbsp;Minimum length 9 chars ")]
        [RegularExpression("^[a-zA-Z0-9<]*$", ErrorMessage = "&nbsp;Passport Number is Alpha, numeric and < only ")]
        public string PassportNo { get; set; }

        [Required]
        [DisplayName("Nationality")]
        public string Nationality { get; set; }


        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }


        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        
        [Required]
        [DisplayName("Date Of Expiration")]
        public DateTime DateOfExpiration { get; set; }

        [MaxLength(9, ErrorMessage = "&nbsp;Maximum length 9 chars ")]
        [MinLength(9, ErrorMessage = "&nbsp;Minimum length 9 chars ")]
        [RegularExpression("^[a-zA-Z0-9<]*$", ErrorMessage = "&nbsp;Passport Number is Alpha, numeric and < only")]
        [Required]
        [Display(Prompt = "A9<")]
        public string PassportNumber { get; set; }

        [Required]
        [MaxLength(1)]
        [Range(0, 9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Checksum is Numeric only")]
        [Display(Prompt = "0-9")]
        public string PassportNumberChecksum { get; set; }


        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        [RegularExpression("^[A-Z<]*$", ErrorMessage = "&nbsp;Nationality code is Alpha and < only")]
        [Display(Prompt = "ABC")]
        public string NationalityCode { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "&nbsp;Maximum length 6 chars")]
        [MinLength(6, ErrorMessage = "&nbsp;Minimum length 6 chars")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Date of Birth is Numeric only")]
        [Display(Prompt = "YYMMDD")]
        public string DateOfBirthMzr { get; set; }

        [Required]
        [MaxLength(1)]
        [Range(0, 9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Checksum is Numeric only")]
        [Display(Prompt = "0-9")]
        public string DOBChecksum { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression("^[F,M,<]*$", ErrorMessage = "&nbsp;Sex is F/M/< only")]
        [Display(Prompt = "F/M/<")]
        public string Sex { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "&nbsp;Maximum length 6 chars")]
        [MinLength(6, ErrorMessage = "&nbsp;Minimum length 6 chars")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Expiration Date is Numeric only")]
        [Display(Prompt = "YYMMDD")]
        public string PassportExpiration { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Checksum is Numeric only")]
        [Display(Prompt = "0-9")]
        [Range(0, 9)]
        public string ExpirationChecksum { get; set; }

        [Required]
        [MaxLength(14, ErrorMessage = "&nbsp;Maximum length is 14 chars")]
        [MinLength(14, ErrorMessage = "&nbsp;Minimum length is 14 chars")]
        [RegularExpression("^[a-zA-Z0-9<]*$", ErrorMessage = "Personal Number is Alpha, Numeric and < only")]
        [Display(Prompt = "A9<")]
        public string PersonalNumber { get; set; }

        [Required]
        [MaxLength(1)]
        [Range(0, 9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Checksum is Numeric only")]
        [Display(Prompt = "0-9")]
        public string PersonalNumberChecksum { get; set; }

        [Required]
        [MaxLength(1)]
        [Range(0, 9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "&nbsp;Checksum is Numeric only")]
        [Display(Prompt = "0-9")]
        public string FinalChecksum { get; set; }

    }
}
