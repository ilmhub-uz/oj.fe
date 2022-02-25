using System.Text.Json.Serialization;
namespace oj.fe.Dto.Tags;
public class Tags
    {
        [JsonPropertyName("error")]
        public object Error { get; set; }

        [JsonPropertyName("data")]
        public List<Tag> Data { get; set; }
    }

