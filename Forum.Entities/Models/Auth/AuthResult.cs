using Newtonsoft.Json;

namespace Forum.Entities.Models.Auth
{
    public class AuthResult
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
