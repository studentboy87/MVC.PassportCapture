﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PassportModels
{
    [DataContract]
    public class PassportModel
    {
        public PassportModel(string passportNumber, string nationality, string gender, string dateOfBirth, string dateOfExpiration, string mzrPassportNumber, string passportNumberChecksum, string mzrNationalityCode, string mzrDateOfBirth, string dobChecksum, string sex, string passportExpiration, string expirationChecksum, string personalNumber, string personalNumberChecksum, string finalChecksum, bool passportNumberChecksumValid, bool dateOfBirthChecksumValid, bool passportExpirationChecksumValid, bool personalNumberChecksumValid, bool finalChecksumValid, bool genderCrossCheckValid, bool dateOfBirthCrossCheckValid, bool passportExpCrossCheckValid, bool nationalityCrossCheckValid, bool passportNoCrossCheckValid)
        {
            PassportNumber = passportNumber;
            Nationality = nationality;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            DateOfExpiration = dateOfExpiration;
            MzrPassportNumber = mzrPassportNumber;
            PassportNumberChecksum = passportNumberChecksum;
            MzrNationalityCode = mzrNationalityCode;
            MzrDateOfBirth = mzrDateOfBirth;
            DOBChecksum = dobChecksum;
            Sex = sex;
            PassportExpiration = passportExpiration;
            ExpirationChecksum = expirationChecksum;
            PersonalNumber = personalNumber;
            PersonalNumberChecksum = personalNumberChecksum;
            FinalChecksum = finalChecksum;
            PassportNumberChecksumValid = passportNumberChecksumValid;
            DateOfBirthChecksumValid = dateOfBirthChecksumValid;
            PassportExpirationChecksumValid = passportExpirationChecksumValid;
            PersonalNumberChecksumValid = personalNumberChecksumValid;
            FinalChecksumValid = finalChecksumValid;
            GenderCrossCheckValid = genderCrossCheckValid;
            DateOfBirthCrossCheckValid = dateOfBirthCrossCheckValid;
            PassportExpCrossCheckValid = passportExpCrossCheckValid;
            NationalityCrossCheckValid = nationalityCrossCheckValid;
            PassportNoCrossCheckValid = passportNoCrossCheckValid;
        }

        

        [DataMember(Name = "PassportNumber", IsRequired = true)]
        [MaxLength(9)]
        public string PassportNumber { get; set; }

        [DataMember(Name = "NationalityCode", IsRequired = true)]
        [MaxLength(3)]
        public string Nationality { get; set; }

        [DataMember(Name = "Gender", IsRequired = true)]
        [MaxLength(1)]
        public string Gender { get; set; }

        [DataMember(Name = "DOB", IsRequired = true)]
        [MaxLength(6)]
        public string DateOfBirth { get; set; }

        [DataMember(Name = "DateOfExpiration")]
        [MaxLength(6)]
        public string DateOfExpiration { get; set; }

        [DataMember(Name = "MzrPassportNumber", IsRequired = true)]
        [MaxLength(9)]
        public string MzrPassportNumber { get; set; }

        [DataMember(Name = "PNChecksum", IsRequired = true)]
        [MaxLength(1)]
        public string PassportNumberChecksum { get; set; }

        [DataMember(Name = "MzrNationalityCode", IsRequired = true)]
        [MaxLength(3)]
        public string MzrNationalityCode { get; set; }

        [DataMember(Name = "MzrDOB", IsRequired = true)]
        [MaxLength(6)]
        public string MzrDateOfBirth { get; set; }

        [DataMember(Name = "DOBChecksum", IsRequired = true)]
        [MaxLength(1)]
        public string DOBChecksum { get; set; }

        [DataMember(Name = "Sex", IsRequired = true)]
        [MaxLength(1)]
        public string Sex { get; set; }

        [DataMember(Name = "PassportExpiration", IsRequired = true)]
        [MaxLength(6)]
        public string PassportExpiration { get; set; }

        [DataMember(Name = "ExpirationChecksum", IsRequired = true)]
        [MaxLength(1)]
        public string ExpirationChecksum { get; set; }

        [DataMember(Name = "PersonalNumber", IsRequired = true)]
        [MaxLength(14)]
        public string PersonalNumber { get; set; }

        [DataMember(Name = "PersonalNumberChecksum", IsRequired = true)]
        [MaxLength(1)]
        public string PersonalNumberChecksum { get; set; }

        [DataMember(Name = "FinalChecksum", IsRequired = true)]
        [MaxLength(1)]
        public string FinalChecksum { get; set; }

        [DataMember(Name = "PassportNumberCSPass", IsRequired = true)]
        public bool PassportNumberChecksumValid { get; set; }

        [DataMember(Name = "DOBCSPass",IsRequired = true)]
        public bool DateOfBirthChecksumValid { get; set; }

        [DataMember(Name = "PassportExpCSPass",IsRequired = true)]
        public bool PassportExpirationChecksumValid { get; set; }

        [DataMember(Name = "PersonalNumberCSPass",IsRequired = true)]
        public bool PersonalNumberChecksumValid { get; set; }

        [DataMember(Name = "FinalCSPass", IsRequired = true)]
        public bool FinalChecksumValid { get; set; }

        [DataMember(Name = "GenderCrossCheckPass", IsRequired = true)]
        public bool GenderCrossCheckValid { get; set; }

        [DataMember(Name = "DOBCrossCheckPass",IsRequired = true)]
        public bool DateOfBirthCrossCheckValid { get; set; }

        [DataMember(Name = "PassportExpCrossCheckPass", IsRequired = true)]
        public bool PassportExpCrossCheckValid { get; set; }

        [DataMember(Name = "NationalityCrossCheck", IsRequired = true)]
        public bool NationalityCrossCheckValid { get; set; }

        [DataMember(Name = "PassportNoCrossCheckPass",IsRequired = true)]
        public bool PassportNoCrossCheckValid { get; set; }
    }
}

