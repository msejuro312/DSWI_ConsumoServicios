using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AutorController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string apiBase = "https://localhost:7092";

        public AutorController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(apiBase);
        }

        public async Task<IActionResult> Index()
        {
            var resp = await _httpClient.GetAsync("api/Autor");
            var contenido = resp.Content.ReadAsStringAsync();
            List<Autor> lista = JsonSerializer.Deserialize <List<Autor>> (contenido.Result);
            return View(await Task.Run(() => lista));
        }

        
    }
}
