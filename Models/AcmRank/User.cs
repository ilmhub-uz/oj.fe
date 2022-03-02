using System.Text.Json.Serialization;

namespace oj.fe.Models.AcmRank;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("real_name")]
        public object RealName { get; set; }
    }

