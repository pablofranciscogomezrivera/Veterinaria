using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Veterinaria.Data;

namespace Veterinaria.Service
{
    public class RenaperService
    {
        private readonly HttpClient _httpClient;
        private const string apiUrl = "";

        public RenaperService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<Dueño> GetPersonaByDni(int dni)
        //{
        //    string url = $"{apiUrl}{dni}";

        //    try
        //    {
        //        var result = await _httpClient. buscar que metodo usan <Dueño>(url);
        //        return result;
        //    }
        //    catch(HttpRequestException ex)
        //    {
        //        Console.WriteLine($"Error");
        //        return null;
        //    }
        //}
    }
}
