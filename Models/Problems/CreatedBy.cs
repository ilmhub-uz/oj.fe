using Newtonsoft.Json;

namespace oj.fe.Models.Problems;

public class CreatedBy
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("real_name")]
        public object RealName { get; set; }
    }

