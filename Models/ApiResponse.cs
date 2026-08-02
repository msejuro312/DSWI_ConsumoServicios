namespace WebApplication1.Models
{
    public class ApiResponse
    {
        public string message { get; set; }
        public bool success { get; set; }
        public T data { get; set; }
    }
}
