using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Veterinaria.Data;
using Veterinaria.DTO;

namespace Veterinaria.Service
{
    public class RenaperService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://renaper-simulador.onrender.com/api";
        private const string ApiKey = "84610933fdfa42bb8d061b814fa3ab4c";

        public RenaperService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", ApiKey);
        }

        public async Task<OwnerDTO?> GetPersonaByCuil(string cuil)
        {
            string url = $"{BaseUrl}/personas/por-cuil/{cuil}";

            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    return JsonSerializer.Deserialize<OwnerDTO>(content, options);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
