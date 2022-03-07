namespace oj.fe.Models.CustomModels;

public class SubmissionTableData
{
    public DateTimeOffset When { get; set; }
    
    public string Id { get; set; }
    
    public string StatusString { get; set; }
    public int StatusInteger { get; set; }
    
    public string ProblemNumber { get; set; }
    
    public int? TimeCostInMilliseconds { get; set; }
    
    public int? MemoryCostInBytes { get; set; }
    
    public string Language { get; set; }
    
    public string Author { get; set; }
}