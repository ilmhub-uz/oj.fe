using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class ProblemData
{
    [JsonProperty("error")]
    public object Error { get; set; }

    [JsonProperty("data")]
    public ProblemModel Data { get; set; }
}