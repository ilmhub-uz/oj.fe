using Newtonsoft.Json;

namespace oj.fe.Models.SingleSubmission;
public class Datum
{
    [JsonProperty("error")]
    public int Error { get; set; }

    [JsonProperty("score")]
    public int Score { get; set; }

    [JsonProperty("memory")]
    public int Memory { get; set; }

    [JsonProperty("output")]
    public object Output { get; set; }

    [JsonProperty("result")]
    public int Result { get; set; }

    [JsonProperty("signal")]
    public int Signal { get; set; }

    [JsonProperty("cpu_time")]
    public int CpuTime { get; set; }

    [JsonProperty("exit_code")]
    public int ExitCode { get; set; }

    [JsonProperty("real_time")]
    public int RealTime { get; set; }

    [JsonProperty("test_case")]
    public string TestCase { get; set; }

    [JsonProperty("output_md5")]
    public string OutputMd5 { get; set; }
}

public class Info
{
    [JsonProperty("err")]
    public object Err { get; set; }

    [JsonProperty("data")]
    public List<Datum> Data { get; set; }
}

public class Data
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("create_time")]
    public DateTime CreateTime { get; set; }

    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }
    [JsonProperty("result")]
    public int Result { get; set; }

    [JsonProperty("info")]
    public Info Info { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("shared")]
    public bool Shared { get; set; }

    [JsonProperty("statistic_info")]
    public StatisticInfo StatisticInfo { get; set; }

    [JsonProperty("ip")]
    public string Ip { get; set; }

    [JsonProperty("contest")]
    public object Contest { get; set; }

    [JsonProperty("problem")]
    public int Problem { get; set; }

    [JsonProperty("can_unshare")]
    public bool CanUnshare { get; set; }
}

public class StatisticInfo
{
    [JsonProperty("score")]
    public int Score { get; set; }

    [JsonProperty("time_cost")]
    public int TimeCost { get; set; }

    [JsonProperty("memory_cost")]
    public int MemoryCost { get; set; }
}

public class SubmissionModel
{
    [JsonProperty("error")]
    public object Error { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }
}

