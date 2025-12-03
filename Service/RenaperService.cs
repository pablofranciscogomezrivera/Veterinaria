using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Veterinaria.DTO;
using Microsoft.Extensions.Logging;

namespace Veterinaria.Service
{
    public class RenaperService
    {
        private readonly HttpClient _httpClient;
        private readonly string? _baseUrl;
        private readonly ILogger<RenaperService> _logger;

        public RenaperService(HttpClient httpClient, IConfiguration configuration, ILogger<RenaperService> logger)
        {
            _httpClient = httpClient;
            var apiKey = configuration["RenaperApi:ApiKey"];
            _baseUrl = configuration["RenaperApi:BaseUrl"];
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            _logger = logger;
        }

        public async Task<OwnerDTO?> GetPersonaByCuil(string cuil)
        {
            string url = $"{_baseUrl}/personas/por-cuil/{cuil}";

            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    return JsonSerializer.Deserialize<OwnerDTO>(content, options);
                }
                else
                {
                    _logger.LogWarning("API Renaper respondió con código: {StatusCode} para CUIL: {Cuil}", response.StatusCode, cuil);
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error de conexión con API Renaper para CUIL: {Cuil}", cuil);
                return null;
            }
        }
    }
}