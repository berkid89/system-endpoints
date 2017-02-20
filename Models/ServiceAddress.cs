namespace SystemEndpoints.Models
{
    public class ServiceAddress
    {
        public string host { get; set; }

        public string port { get; set; }

        public string GetFullUrl()
        {
            return $"{host}:{port}";
        }
    }
}