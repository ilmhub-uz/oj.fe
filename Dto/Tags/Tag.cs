using System.Text.Json.Serialization;
namespace oj.fe.Dto.Tags;
public class Tag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

