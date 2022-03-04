using Newtonsoft.Json;
namespace oj.fe.Models.Contests;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class CreatedBy
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("real_name")]
    public object RealName { get; set; }
}

