using Newtonsoft.Json;
namespace oj.fe.Models.Contests;

public class Data
{
    [JsonProperty("results")]
    public List<Result> Results { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}

