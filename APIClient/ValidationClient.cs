using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PassportModels;

namespace APIClient
{
    public partial class ApiClient
    {
        public async Task<Message<PassportModel>> ValidatePassport(PassportModel model, string endPoint)
        {
            var requestUrl =
                CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, endPoint));
            return await PostAsync<PassportModel>(requestUrl, model);
        }

        public async Task<List<Nationality>> GetNationalities()
        {
            var requestUrl = CreateRequestUri(String.Format(System.Globalization.CultureInfo.InvariantCulture, "PassportValidator/GetNationalities"));
            return await GetAsync<List<Nationality>>(requestUrl);
        }
    }
}