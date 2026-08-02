using Microsoft.AspNetCore.Mvc;

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

        
    }
}
