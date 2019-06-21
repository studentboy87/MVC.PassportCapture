using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using PassportModels;
using Web.PassportCapture.Factory;
using Web.PassportCapture.Models;
using Web.PassportCapture.Utility;

namespace Web.PassportCapture.Controllers
{
    public class ReadPassportController : Controller
    {
        private readonly IOptions<ApiSettingsModel> _apiSettings;

        public ReadPassportController(IOptions<ApiSettingsModel> apiSettings)
        {
            _apiSettings = apiSettings;
            ApiAuth.WebApiUrl = apiSettings.Value.WebApiBaseUrl;
        }

        public async Task<IActionResult> Index()
        {
            var nations = await ApiClientFactory.Instance.GetNationalities();
            ViewBag.GetNations = new SelectList(nations, "Alpha3Code", "Name");
            return View();
        }

        public async Task<IActionResult> Validate(PassportViewModel model)
        {


            if (ModelState.IsValid)
            {

                var endPoint = string.Concat(_apiSettings.Value.ValidationEndPoint, "ValidateMZR");
                
                var passportModel = new PassportModel(
                    model.PassportNo,
                    model.Nationality,
                    model.Gender,
                    model.DateOfBirth.ToString("yyMMdd"),
                    model.DateOfExpiration.ToString("yyMMdd"),
                    AlphaNumericChevronOnly(model.PassportNumber),
                    NumericOnly(model.PassportNumberChecksum),
                   AlphaChevronOnly(model.NationalityCode),
                    NumericOnly(model.DateOfBirthMzr),
                    NumericOnly(model.DOBChecksum),
                    GenderString(model.Sex),
                    NumericOnly(model.PassportExpiration),
                    NumericOnly(model.ExpirationChecksum),
                    AlphaNumericChevronOnly(model.PersonalNumber),
                    NumericChevronOnly(model.PersonalNumberChecksum),
                    NumericOnly(model.FinalChecksum),
                    false,
                    false,
                    false,
                    false,
                    false,
                    false,
                    false,
                    false,
                    false,
                    false);


                var response = await ApiClientFactory.Instance.ValidatePassport(passportModel, endPoint);


                var results = new ValidationResultViewModel();
                results.PassportNumberChecksumValid = response.Data.PassportNumberChecksumValid;
                results.DOBChecksumValid = response.Data.DateOfBirthChecksumValid;
                results.ExpirationChecksumValid = response.Data.PassportExpirationChecksumValid;
                results.PersonalNumberChecksumValid = response.Data.PersonalNumberChecksumValid;
                results.FinalChecksumValid = response.Data.FinalChecksumValid;
                results.GenderCCValid = response.Data.GenderCrossCheckValid;
                results.DOBCCValid = response.Data.DateOfBirthCrossCheckValid;
                results.ExpirationDateCCValid = response.Data.PassportExpCrossCheckValid;
                results.NationalityCCValid = response.Data.NationalityCrossCheckValid;
                results.PassportNoCCValid = response.Data.PassportNoCrossCheckValid;



                ModelState.Clear();
                return View(results);

            }

            return await Index();
        }

        
        private string AlphaNumericChevronOnly(string property)
        {
            return new string(property.Where(c => char.IsLetterOrDigit(c) || c == '<').ToArray());
        }

        private string AlphaNumericOnly(string property)
        {
            return new string(property.Where(char.IsLetterOrDigit).ToArray());
        }

        private string AlphaChevronOnly(string property)
        {
            return new string(property.Where(c => char.IsLetter(c) || c == '<').ToArray());
        }

        private string AlphaOnly(string property)
        {
            return new string(property.Where(char.IsLetter).ToArray());
        }

        private string NumericChevronOnly(string property)
        {
            return new string(property.Where(c => char.IsDigit(c) || c == '<').ToArray());
        }

        private string NumericOnly(string property)
        {
            return new string(property.Where(char.IsDigit).ToArray());
        }

        private string GenderString(string property)
        {
            return new string(Regex.Replace(property, "^[^F,M,<]*$", ""));
        }
        

    }
}