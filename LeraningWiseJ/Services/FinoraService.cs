using LeraningWiseJ.Models;
using LeraningWiseJ.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Wisej.Web;

namespace LeraningWiseJ.Services
{
    public class FinoraService : IFinoraService
    {
        private readonly string BaseUrl = "https://localhost:7007/";
        private readonly HttpClient _http;

        public FinoraService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Finora>> GetFinoras()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<List<Finora>>(BaseUrl + API.GetFin);
                return result ?? new List<Finora>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar dados: {ex.Message}");
                return new List<Finora>();
            }
        }
    }
}
