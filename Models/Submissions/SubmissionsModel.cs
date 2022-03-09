using Newtonsoft.Json;

namespace oj.fe.Models.Submissions;

public class StatisticInfo
{
    [JsonProperty("score")]
    public int Score { get; set; }

    [JsonProperty("err_info")]
    public string ErrInfo { get; set; }

    [JsonProperty("time_cost")]
    public int? TimeCost { get; set; }

    [JsonProperty("memory_cost")]
    public int? MemoryCost { get; set; }
}

public class Result
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("problem")]
    public string Problem { get; set; }

    [JsonProperty("show_link")]
    public bool ShowLink { get; set; }

    [JsonProperty("create_time")]
    public DateTime CreateTime { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("result")]
    public int Status { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("shared")]
    public bool Shared { get; set; }

    [JsonProperty("statistic_info")]
    public StatisticInfo StatisticInfo { get; set; }
}

public class Data
{
    [JsonProperty("results")]
    public List<Result> Results { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}

public class SubmissionsModel
{
    [JsonProperty("error")]
    public object Error { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }
}

