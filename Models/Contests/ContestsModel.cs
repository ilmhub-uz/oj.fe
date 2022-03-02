using Newtonsoft.Json;
namespace oj.fe.Models.Contests;

public class ContestsModel
{
    [JsonProperty("error")]
    public object Error { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }
}

