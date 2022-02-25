using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class Problems
    {
        [JsonProperty("results")]
        public List<ProblemModel> ProblemModels { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

